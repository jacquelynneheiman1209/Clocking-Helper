namespace Timehelper
{
    partial class ClockingHelper
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClockingHelper));
            this.HourTextBox = new System.Windows.Forms.TextBox();
            this.InstructionsLabel = new System.Windows.Forms.Label();
            this.HourLabel = new System.Windows.Forms.Label();
            this.MinuteLabel = new System.Windows.Forms.Label();
            this.MinuteTextBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.StartTimeLabel = new System.Windows.Forms.Label();
            this.ClockOutLunchLabel = new System.Windows.Forms.Label();
            this.ClockInLunchLabel = new System.Windows.Forms.Label();
            this.ClockOutDayLabel = new System.Windows.Forms.Label();
            this.ClockOutLunchTimeLabel = new System.Windows.Forms.Label();
            this.ClockInLunchTimeLabel = new System.Windows.Forms.Label();
            this.ClockOutDayTimeLabel = new System.Windows.Forms.Label();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.SettingsLabel = new System.Windows.Forms.Label();
            this.TimeFrameLabel = new System.Windows.Forms.Label();
            this.MorningTextBox = new System.Windows.Forms.TextBox();
            this.AMLabel = new System.Windows.Forms.Label();
            this.LunchLabel = new System.Windows.Forms.Label();
            this.LunchTextBox = new System.Windows.Forms.TextBox();
            this.PMLabel = new System.Windows.Forms.Label();
            this.AfternoonTextBox = new System.Windows.Forms.TextBox();
            this.Use24HourTimeCheckbox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.InstructionLabel = new System.Windows.Forms.Label();
            this.SettingsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // HourTextBox
            // 
            this.HourTextBox.Location = new System.Drawing.Point(129, 49);
            this.HourTextBox.Name = "HourTextBox";
            this.HourTextBox.Size = new System.Drawing.Size(92, 20);
            this.HourTextBox.TabIndex = 0;
            // 
            // InstructionsLabel
            // 
            this.InstructionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionsLabel.Location = new System.Drawing.Point(212, 12);
            this.InstructionsLabel.Name = "InstructionsLabel";
            this.InstructionsLabel.Size = new System.Drawing.Size(500, 58);
            this.InstructionsLabel.TabIndex = 1;
            this.InstructionsLabel.Text = "Please enter your start time below to calculate clock out times.";
            this.InstructionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HourLabel
            // 
            this.HourLabel.AutoSize = true;
            this.HourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HourLabel.Location = new System.Drawing.Point(150, 26);
            this.HourLabel.Name = "HourLabel";
            this.HourLabel.Size = new System.Drawing.Size(44, 20);
            this.HourLabel.TabIndex = 2;
            this.HourLabel.Text = "Hour";
            // 
            // MinuteLabel
            // 
            this.MinuteLabel.AutoSize = true;
            this.MinuteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinuteLabel.Location = new System.Drawing.Point(257, 26);
            this.MinuteLabel.Name = "MinuteLabel";
            this.MinuteLabel.Size = new System.Drawing.Size(57, 20);
            this.MinuteLabel.TabIndex = 4;
            this.MinuteLabel.Text = "Minute";
            // 
            // MinuteTextBox
            // 
            this.MinuteTextBox.Location = new System.Drawing.Point(240, 49);
            this.MinuteTextBox.Name = "MinuteTextBox";
            this.MinuteTextBox.Size = new System.Drawing.Size(92, 20);
            this.MinuteTextBox.TabIndex = 3;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(363, 26);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(101, 43);
            this.CalculateButton.TabIndex = 5;
            this.CalculateButton.Text = "Calculate ";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // StartTimeLabel
            // 
            this.StartTimeLabel.AutoSize = true;
            this.StartTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTimeLabel.Location = new System.Drawing.Point(31, 49);
            this.StartTimeLabel.Name = "StartTimeLabel";
            this.StartTimeLabel.Size = new System.Drawing.Size(86, 20);
            this.StartTimeLabel.TabIndex = 6;
            this.StartTimeLabel.Text = "Start Time:";
            // 
            // ClockOutLunchLabel
            // 
            this.ClockOutLunchLabel.AutoSize = true;
            this.ClockOutLunchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockOutLunchLabel.Location = new System.Drawing.Point(84, 11);
            this.ClockOutLunchLabel.Name = "ClockOutLunchLabel";
            this.ClockOutLunchLabel.Size = new System.Drawing.Size(166, 20);
            this.ClockOutLunchLabel.TabIndex = 7;
            this.ClockOutLunchLabel.Text = "Clock out for lunch at: ";
            // 
            // ClockInLunchLabel
            // 
            this.ClockInLunchLabel.AutoSize = true;
            this.ClockInLunchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockInLunchLabel.Location = new System.Drawing.Point(84, 41);
            this.ClockInLunchLabel.Name = "ClockInLunchLabel";
            this.ClockInLunchLabel.Size = new System.Drawing.Size(168, 20);
            this.ClockInLunchLabel.TabIndex = 8;
            this.ClockInLunchLabel.Text = "Clock in from lunch at: ";
            // 
            // ClockOutDayLabel
            // 
            this.ClockOutDayLabel.AutoSize = true;
            this.ClockOutDayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockOutDayLabel.Location = new System.Drawing.Point(84, 73);
            this.ClockOutDayLabel.Name = "ClockOutDayLabel";
            this.ClockOutDayLabel.Size = new System.Drawing.Size(176, 20);
            this.ClockOutDayLabel.TabIndex = 9;
            this.ClockOutDayLabel.Text = "Clock out for the day at:";
            // 
            // ClockOutLunchTimeLabel
            // 
            this.ClockOutLunchTimeLabel.AutoSize = true;
            this.ClockOutLunchTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockOutLunchTimeLabel.Location = new System.Drawing.Point(298, 11);
            this.ClockOutLunchTimeLabel.Name = "ClockOutLunchTimeLabel";
            this.ClockOutLunchTimeLabel.Size = new System.Drawing.Size(77, 20);
            this.ClockOutLunchTimeLabel.TabIndex = 10;
            this.ClockOutLunchTimeLabel.Text = "12:00 AM";
            // 
            // ClockInLunchTimeLabel
            // 
            this.ClockInLunchTimeLabel.AutoSize = true;
            this.ClockInLunchTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockInLunchTimeLabel.Location = new System.Drawing.Point(298, 41);
            this.ClockInLunchTimeLabel.Name = "ClockInLunchTimeLabel";
            this.ClockInLunchTimeLabel.Size = new System.Drawing.Size(77, 20);
            this.ClockInLunchTimeLabel.TabIndex = 11;
            this.ClockInLunchTimeLabel.Text = "12:00 AM";
            // 
            // ClockOutDayTimeLabel
            // 
            this.ClockOutDayTimeLabel.AutoSize = true;
            this.ClockOutDayTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockOutDayTimeLabel.Location = new System.Drawing.Point(298, 73);
            this.ClockOutDayTimeLabel.Name = "ClockOutDayTimeLabel";
            this.ClockOutDayTimeLabel.Size = new System.Drawing.Size(77, 20);
            this.ClockOutDayTimeLabel.TabIndex = 12;
            this.ClockOutDayTimeLabel.Text = "12:00 AM";
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.BackColor = System.Drawing.SystemColors.Control;
            this.SettingsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SettingsPanel.Controls.Add(this.InstructionLabel);
            this.SettingsPanel.Controls.Add(this.Use24HourTimeCheckbox);
            this.SettingsPanel.Controls.Add(this.PMLabel);
            this.SettingsPanel.Controls.Add(this.AfternoonTextBox);
            this.SettingsPanel.Controls.Add(this.LunchLabel);
            this.SettingsPanel.Controls.Add(this.LunchTextBox);
            this.SettingsPanel.Controls.Add(this.AMLabel);
            this.SettingsPanel.Controls.Add(this.MorningTextBox);
            this.SettingsPanel.Controls.Add(this.TimeFrameLabel);
            this.SettingsPanel.Controls.Add(this.SettingsLabel);
            this.SettingsPanel.Location = new System.Drawing.Point(12, 12);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(200, 295);
            this.SettingsPanel.TabIndex = 14;
            // 
            // SettingsLabel
            // 
            this.SettingsLabel.AutoSize = true;
            this.SettingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsLabel.Location = new System.Drawing.Point(12, 12);
            this.SettingsLabel.Name = "SettingsLabel";
            this.SettingsLabel.Size = new System.Drawing.Size(76, 24);
            this.SettingsLabel.TabIndex = 0;
            this.SettingsLabel.Text = "Settings";
            // 
            // TimeFrameLabel
            // 
            this.TimeFrameLabel.AutoSize = true;
            this.TimeFrameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeFrameLabel.Location = new System.Drawing.Point(12, 48);
            this.TimeFrameLabel.Name = "TimeFrameLabel";
            this.TimeFrameLabel.Size = new System.Drawing.Size(101, 20);
            this.TimeFrameLabel.TabIndex = 1;
            this.TimeFrameLabel.Text = "Time Frames";
            // 
            // MorningTextBox
            // 
            this.MorningTextBox.Location = new System.Drawing.Point(96, 77);
            this.MorningTextBox.Name = "MorningTextBox";
            this.MorningTextBox.Size = new System.Drawing.Size(67, 20);
            this.MorningTextBox.TabIndex = 2;
            // 
            // AMLabel
            // 
            this.AMLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AMLabel.Location = new System.Drawing.Point(31, 78);
            this.AMLabel.Name = "AMLabel";
            this.AMLabel.Size = new System.Drawing.Size(57, 23);
            this.AMLabel.TabIndex = 3;
            this.AMLabel.Text = "AM: ";
            // 
            // LunchLabel
            // 
            this.LunchLabel.AutoSize = true;
            this.LunchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LunchLabel.Location = new System.Drawing.Point(31, 104);
            this.LunchLabel.Name = "LunchLabel";
            this.LunchLabel.Size = new System.Drawing.Size(51, 17);
            this.LunchLabel.TabIndex = 5;
            this.LunchLabel.Text = "Lunch:";
            // 
            // LunchTextBox
            // 
            this.LunchTextBox.Location = new System.Drawing.Point(96, 104);
            this.LunchTextBox.Name = "LunchTextBox";
            this.LunchTextBox.Size = new System.Drawing.Size(67, 20);
            this.LunchTextBox.TabIndex = 4;
            // 
            // PMLabel
            // 
            this.PMLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PMLabel.Location = new System.Drawing.Point(31, 130);
            this.PMLabel.Name = "PMLabel";
            this.PMLabel.Size = new System.Drawing.Size(51, 17);
            this.PMLabel.TabIndex = 7;
            this.PMLabel.Text = "PM: ";
            // 
            // AfternoonTextBox
            // 
            this.AfternoonTextBox.Location = new System.Drawing.Point(96, 130);
            this.AfternoonTextBox.Name = "AfternoonTextBox";
            this.AfternoonTextBox.Size = new System.Drawing.Size(67, 20);
            this.AfternoonTextBox.TabIndex = 6;
            // 
            // Use24HourTimeCheckbox
            // 
            this.Use24HourTimeCheckbox.AutoSize = true;
            this.Use24HourTimeCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Use24HourTimeCheckbox.Location = new System.Drawing.Point(16, 192);
            this.Use24HourTimeCheckbox.Name = "Use24HourTimeCheckbox";
            this.Use24HourTimeCheckbox.Size = new System.Drawing.Size(149, 24);
            this.Use24HourTimeCheckbox.TabIndex = 8;
            this.Use24HourTimeCheckbox.Text = "Use 24 hour time";
            this.Use24HourTimeCheckbox.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CalculateButton);
            this.panel1.Controls.Add(this.HourTextBox);
            this.panel1.Controls.Add(this.HourLabel);
            this.panel1.Controls.Add(this.MinuteTextBox);
            this.panel1.Controls.Add(this.MinuteLabel);
            this.panel1.Controls.Add(this.StartTimeLabel);
            this.panel1.Location = new System.Drawing.Point(217, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 100);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ClockInLunchLabel);
            this.panel2.Controls.Add(this.ClockOutLunchTimeLabel);
            this.panel2.Controls.Add(this.ClockOutDayTimeLabel);
            this.panel2.Controls.Add(this.ClockOutLunchLabel);
            this.panel2.Controls.Add(this.ClockInLunchTimeLabel);
            this.panel2.Controls.Add(this.ClockOutDayLabel);
            this.panel2.Location = new System.Drawing.Point(219, 198);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(493, 109);
            this.panel2.TabIndex = 16;
            // 
            // InstructionLabel
            // 
            this.InstructionLabel.Location = new System.Drawing.Point(16, 226);
            this.InstructionLabel.Name = "InstructionLabel";
            this.InstructionLabel.Size = new System.Drawing.Size(168, 52);
            this.InstructionLabel.TabIndex = 9;
            this.InstructionLabel.Text = "Note: If you want to work for 4 hours and 30 minutes in the morning enter 4.5 int" +
    "o the AM textbox.";
            this.InstructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ClockingHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 332);
            this.Controls.Add(this.SettingsPanel);
            this.Controls.Add(this.InstructionsLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClockingHelper";
            this.Text = "Clocking Helper";
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox HourTextBox;
        private System.Windows.Forms.Label InstructionsLabel;
        private System.Windows.Forms.Label HourLabel;
        private System.Windows.Forms.Label MinuteLabel;
        private System.Windows.Forms.TextBox MinuteTextBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label StartTimeLabel;
        private System.Windows.Forms.Label ClockOutLunchLabel;
        private System.Windows.Forms.Label ClockInLunchLabel;
        private System.Windows.Forms.Label ClockOutDayLabel;
        private System.Windows.Forms.Label ClockOutLunchTimeLabel;
        private System.Windows.Forms.Label ClockInLunchTimeLabel;
        private System.Windows.Forms.Label ClockOutDayTimeLabel;
        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.TextBox MorningTextBox;
        private System.Windows.Forms.Label TimeFrameLabel;
        private System.Windows.Forms.Label SettingsLabel;
        private System.Windows.Forms.Label AMLabel;
        private System.Windows.Forms.Label PMLabel;
        private System.Windows.Forms.TextBox AfternoonTextBox;
        private System.Windows.Forms.Label LunchLabel;
        private System.Windows.Forms.TextBox LunchTextBox;
        private System.Windows.Forms.CheckBox Use24HourTimeCheckbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label InstructionLabel;
    }
}

