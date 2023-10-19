using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace Timehelper
{
    public partial class ClockingHelper : Form
    {
        private Settings settings;

        private readonly int minutesInHour = 60;

        public ClockingHelper()
        {
            InitializeComponent();
            SetupEventListeners();

            settings = new Settings();

            LoadSettings();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            int startHour = GetInteger(HourTextBox.Text);
            int startMinute = GetInteger(MinuteTextBox.Text);

            float morningDuration = GetFloat(MorningTextBox.Text);
            float lunchDuration = GetFloat(LunchTextBox.Text);
            float afternoonDuration = GetFloat(AfternoonTextBox.Text);

            ClockOutLunchTimeLabel.Text = GetTimeText(morningDuration, startHour, startMinute, out startHour, out startMinute);
            ClockInLunchTimeLabel.Text = GetTimeText(lunchDuration, startHour, startMinute, out startHour, out startMinute);
            ClockOutDayTimeLabel.Text = GetTimeText(afternoonDuration, startHour, startMinute, out startHour, out startMinute);
        }

        private string GetTimeText(float duration, int hour, int minute, out int newHour, out int newMinutes)
        {
            int totalHour = 0;

            CalculateTime(duration, hour, minute, out totalHour, out newMinutes);

            newHour = totalHour;

            if (!Use24HourTimeCheckbox.Checked)
            {
                totalHour = (totalHour > 12 ? totalHour - 12 : totalHour);
            }

            return totalHour.ToString("00") + ":" + newMinutes.ToString("00") + (newHour > 11 ? " PM" : " AM");
        }

        private void CalculateTime(float timespan, int startHour, int startMinute, out int hour, out int minute)
        {
            int durationHours = (int)timespan;
            int durationMinutes = (int)((timespan - durationHours) * minutesInHour);

            hour = startHour + durationHours;
            minute = startMinute + durationMinutes;

            int maxLoops = 0;

            while (minute >= 60 || maxLoops == 10)
            {
                minute -= 60;
                hour += 1;

                maxLoops++;
            }
        }

        private int GetInteger(string intString)
        {
            int intValue = -1;

            if (!string.IsNullOrWhiteSpace(intString))
            {
                int.TryParse(intString, out intValue);
            }

            return intValue;
        }

        private float GetFloat(string floatString)
        {
            float floatValue = -1;

            if (!string.IsNullOrWhiteSpace(floatString))
            {
                float.TryParse(floatString, out floatValue);
            }

            return floatValue;
        }

        private void MorningTextBox_GotFocus(object sender, EventArgs e)
        {
            if (MorningTextBox.Text == "0.00")
            {
                MorningTextBox.Text = "";
                MorningTextBox.ForeColor = Color.Black;
            }
        }

        private void MorningTextBox_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MorningTextBox.Text))
            {
                MorningTextBox.Text = "0.00";
                MorningTextBox.ForeColor = Color.Gray;
            }

            settings.morningDuration = GetFloat(MorningTextBox.Text);
            SaveSettings();
        }

        private void LunchTextBox_GotFocus(object sender, EventArgs e)
        {
            if (LunchTextBox.Text == "0.00")
            {
                LunchTextBox.Text = "";
                LunchTextBox.ForeColor = Color.Black;
            }
        }

        private void LunchTextBox_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LunchTextBox.Text))
            {
                LunchTextBox.Text = "0.00";
                LunchTextBox.ForeColor = Color.Gray;
            }

            settings.lunchDuration = GetFloat(LunchTextBox.Text);
            SaveSettings();
        }

        private void AfternoonTextBox_GotFocus(object sender, EventArgs e)
        {
            if (AfternoonTextBox.Text == "0.00")
            {
                AfternoonTextBox.Text = "";
                AfternoonTextBox.ForeColor = Color.Black;
            }
        }

        private void AfternoonTextBox_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AfternoonTextBox.Text))
            {
                AfternoonTextBox.Text = "0.00";
                AfternoonTextBox.ForeColor = Color.Gray;
            }

            settings.afternoonDuration = GetFloat(AfternoonTextBox.Text);
            SaveSettings();
        }

        private void Use24HourTimeCheckbox_CheckChanged(object sender, EventArgs e)
        {
            settings.use24HourTime = Use24HourTimeCheckbox.Checked;
            SaveSettings();
        }

        private void SetupEventListeners()
        {
            MorningTextBox.GotFocus += MorningTextBox_GotFocus;
            MorningTextBox.LostFocus += MorningTextBox_LostFocus;

            LunchTextBox.GotFocus += LunchTextBox_GotFocus;
            LunchTextBox.LostFocus += LunchTextBox_LostFocus;

            AfternoonTextBox.GotFocus += AfternoonTextBox_GotFocus;
            AfternoonTextBox.LostFocus += AfternoonTextBox_LostFocus;

            Use24HourTimeCheckbox.CheckedChanged += Use24HourTimeCheckbox_CheckChanged;
        }

        private void SaveSettings()
        {
            string json = JsonConvert.SerializeObject(settings);
            File.WriteAllText("durations.json", json);
        }

        private void LoadSettings()
        {
            if (File.Exists("durations.json"))
            {
                string json = File.ReadAllText("durations.json");
                settings = JsonConvert.DeserializeObject<Settings>(json);
            }

            SetupDurationTextboxes();
            SetupTimeFormatCheckbox();
        }

        private void SetupDurationTextboxes()
        {
            MorningTextBox.Text = settings.morningDuration.ToString("0.00");
            LunchTextBox.Text = settings.lunchDuration.ToString("0.00");
            AfternoonTextBox.Text = settings.afternoonDuration.ToString("0.00");

            MorningTextBox.ForeColor = MorningTextBox.Text == "0.00" ? Color.Gray : Color.Black;
            LunchTextBox.ForeColor = LunchTextBox.Text == "0.00" ? Color.Gray : Color.Black;
            AfternoonTextBox.ForeColor = AfternoonTextBox.Text == "0.00" ? Color.Gray : Color.Black;
        }

        private void SetupTimeFormatCheckbox()
        {
            Use24HourTimeCheckbox.Checked = settings.use24HourTime;
        }
    }
}
