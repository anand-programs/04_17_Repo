namespace Timer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.HoursLabel = new System.Windows.Forms.Label();
            this.MinutesLabel = new System.Windows.Forms.Label();
            this.SecondsLabel = new System.Windows.Forms.Label();
            this.TimerDisplay = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.HoursComboBox = new System.Windows.Forms.ComboBox();
            this.MinutesComboBox = new System.Windows.Forms.ComboBox();
            this.SecondsComboBox = new System.Windows.Forms.ComboBox();
            this.TimerClock = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // HoursLabel
            // 
            this.HoursLabel.AutoSize = true;
            this.HoursLabel.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HoursLabel.Location = new System.Drawing.Point(30, 9);
            this.HoursLabel.Name = "HoursLabel";
            this.HoursLabel.Size = new System.Drawing.Size(86, 28);
            this.HoursLabel.TabIndex = 0;
            this.HoursLabel.Text = "Hours";
            // 
            // MinutesLabel
            // 
            this.MinutesLabel.AutoSize = true;
            this.MinutesLabel.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MinutesLabel.Location = new System.Drawing.Point(166, 9);
            this.MinutesLabel.Name = "MinutesLabel";
            this.MinutesLabel.Size = new System.Drawing.Size(111, 28);
            this.MinutesLabel.TabIndex = 1;
            this.MinutesLabel.Text = "Minutes";
            // 
            // SecondsLabel
            // 
            this.SecondsLabel.AutoSize = true;
            this.SecondsLabel.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SecondsLabel.Location = new System.Drawing.Point(307, 9);
            this.SecondsLabel.Name = "SecondsLabel";
            this.SecondsLabel.Size = new System.Drawing.Size(119, 28);
            this.SecondsLabel.TabIndex = 2;
            this.SecondsLabel.Text = "Seconds";
            // 
            // TimerDisplay
            // 
            this.TimerDisplay.AutoSize = true;
            this.TimerDisplay.Font = new System.Drawing.Font("MS UI Gothic", 67.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TimerDisplay.Location = new System.Drawing.Point(2, 110);
            this.TimerDisplay.Name = "TimerDisplay";
            this.TimerDisplay.Size = new System.Drawing.Size(444, 114);
            this.TimerDisplay.TabIndex = 3;
            this.TimerDisplay.Text = "00:00:00";
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StartButton.Location = new System.Drawing.Point(12, 302);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(121, 34);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PauseButton.Location = new System.Drawing.Point(161, 302);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(121, 34);
            this.PauseButton.TabIndex = 4;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ResetButton.Location = new System.Drawing.Point(306, 302);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(121, 34);
            this.ResetButton.TabIndex = 5;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // HoursComboBox
            // 
            this.HoursComboBox.FormattingEnabled = true;
            this.HoursComboBox.Location = new System.Drawing.Point(12, 40);
            this.HoursComboBox.Name = "HoursComboBox";
            this.HoursComboBox.Size = new System.Drawing.Size(121, 23);
            this.HoursComboBox.TabIndex = 6;
            // 
            // MinutesComboBox
            // 
            this.MinutesComboBox.FormattingEnabled = true;
            this.MinutesComboBox.Location = new System.Drawing.Point(161, 40);
            this.MinutesComboBox.Name = "MinutesComboBox";
            this.MinutesComboBox.Size = new System.Drawing.Size(121, 23);
            this.MinutesComboBox.TabIndex = 7;
            // 
            // SecondsComboBox
            // 
            this.SecondsComboBox.FormattingEnabled = true;
            this.SecondsComboBox.Location = new System.Drawing.Point(306, 40);
            this.SecondsComboBox.Name = "SecondsComboBox";
            this.SecondsComboBox.Size = new System.Drawing.Size(121, 23);
            this.SecondsComboBox.TabIndex = 8;
            // 
            // TimerClock
            // 
            this.TimerClock.Interval = 1000;
            this.TimerClock.Tick += new System.EventHandler(this.TimerClock_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 364);
            this.Controls.Add(this.SecondsComboBox);
            this.Controls.Add(this.MinutesComboBox);
            this.Controls.Add(this.HoursComboBox);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.TimerDisplay);
            this.Controls.Add(this.SecondsLabel);
            this.Controls.Add(this.MinutesLabel);
            this.Controls.Add(this.HoursLabel);
            this.MaximumSize = new System.Drawing.Size(466, 411);
            this.MinimumSize = new System.Drawing.Size(466, 411);
            this.Name = "Form1";
            this.Text = "Timer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HoursLabel;
        private System.Windows.Forms.Label MinutesLabel;
        private System.Windows.Forms.Label SecondsLabel;
        private System.Windows.Forms.Label TimerDisplay;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.ComboBox HoursComboBox;
        private System.Windows.Forms.ComboBox MinutesComboBox;
        private System.Windows.Forms.ComboBox SecondsComboBox;
        private System.Windows.Forms.Timer TimerClock;
    }
}

