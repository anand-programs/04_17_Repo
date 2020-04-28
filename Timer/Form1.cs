﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimersDotTimer = System.Timers.Timer;

namespace Timer
{
    public partial class Form1 : Form
    {
        #region Initializing Component Constructor
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        //Initializing variables to be used further
        int totalseconds;
        bool pauseButtonIndicator = false;

        #region Initializing Combo box values
        private void Form1_Load(object sender, EventArgs e)
        {
            //Disable Pause and Reset buttons at the start
            this.PauseButton.Enabled = false;
            this.ResetButton.Enabled = false;

            //Entering values in the Combo boxes of Seconds, Minutes and Hours
            for (int i = 0; i < 60; i++)
            {
                this.SecondsComboBox.Items.Add(i.ToString());
                this.MinutesComboBox.Items.Add(i.ToString());
                this.HoursComboBox.Items.Add(i.ToString());

            }

            //Entering a default number in each of the boxes
            ComboBoxDefaultValues();
        }
        #endregion

        #region Start, Pause and Reset Methods
        private void StartButton_Click(object sender, EventArgs e)
        {
            //Get values of seconds, minutes and hourse from ComboBox
            int seconds = int.Parse(this.SecondsComboBox.SelectedIndex.ToString());
            int minutes = int.Parse(this.MinutesComboBox.SelectedIndex.ToString());
            int hours = int.Parse(this.HoursComboBox.SelectedIndex.ToString());

            //Calculate total seconds
            totalseconds = (hours * 60 * 60) + (minutes * 60) + seconds;

            if (totalseconds == 0)
            {
                return;
            }

            //Diable Start button after it has been clicked once and enable Pause and Reset buttons
            this.StartButton.Enabled = false;
            this.PauseButton.Enabled = true;
            this.ResetButton.Enabled = true;

            //Enable Timer according to the radio button checked
            if (FormsTimer.Checked)
            {
                this.TimerClock.Enabled = true;
            }

            else if (ThreadTimer.Checked)
            {
                MessageBox.Show("thread timer start");
            }

            else
            {
                TimersDotTimerClock();
            }
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            //If pause button has not been pressed before
            if (!pauseButtonIndicator)
            {
                //Stop the timer
                if (FormsTimer.Checked)
                {
                    MessageBox.Show("forms timer pause");
                    this.TimerClock.Enabled = false;
                }

                else if (ThreadTimer.Checked)
                {
                    MessageBox.Show("thread timer pause");
                }

                else
                {
                    MessageBox.Show("timers timer pause");
                }

                //Set the pause button indicator to true
                pauseButtonIndicator = true;
            }

            //If pause button has been pressed again
            else
            {
                //Resume the timer
                if (FormsTimer.Checked)
                {
                    MessageBox.Show("forms timer pause again");
                    this.TimerClock.Enabled = true;
                }

                else if (ThreadTimer.Checked)
                {
                    MessageBox.Show("thread timer pause again");
                }

                else
                {
                    MessageBox.Show("timers timer pause again");
                }
                

                //Set the pause button indicator to false
                pauseButtonIndicator = false;
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            //Reset totalseconds
            totalseconds = 0;

            //Disable Timer
            if (FormsTimer.Checked)
            {
                this.TimerClock.Enabled = false;
            }

            else if (ThreadTimer.Checked)
            {
                
            }

            else
            {
                
            }

            //Enable Start button, and disable Pause and Reset buttons
            this.StartButton.Enabled = true;
            this.PauseButton.Enabled = false;
            this.ResetButton.Enabled = false;

            //Reset Timer display
            this.TimerDisplay.Text = "00:00:00";

            ////Enter a default number in each of the boxes
            ComboBoxDefaultValues();
        }
        #endregion
            
        #region Forms.Timer Clock Method
        private void TimerClock_Tick(object sender, EventArgs e)
        {
            //Run the timer till total seconds becomex 0
            if (totalseconds > 0)
            {
                RunTimer();
            }

            //If total seconds is 0, stop the timer
            else
            {
                this.TimerClock.Stop();
                MessageBox.Show("Time Over!");
            }
        }
        #endregion

        #region Timers.Timer Clock Method

        private TimersDotTimer tiTimer;
        private void TimersDotTimerClock()
        {
            //Create a Timers.Timer object with an interval of one second
            tiTimer = new TimersDotTimer(1000);

            //Call the TiTimer_Elapsed method when the timer has elapsed
            tiTimer.Elapsed += TiTimer_Elapsed;

            //Enable the timer
            tiTimer.Enabled = true;
        }

        private void TiTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            //Run the timer till total seconds becomes 0
            if (totalseconds > 0)
            {
                //The TimerDisplay element of RunTimer() belongs to System.Windows.Forms, so using it from a different thread needs following statement
                this.BeginInvoke((Action)delegate ()
                {
                    RunTimer();
                });
                
            }

            //If total seconds is 0, stop the timer
            else
            {
                tiTimer.Stop();
                tiTimer.Dispose();
                MessageBox.Show("Time Over!");
                return;
            }
        }
        #endregion

        #region Assigning Default ComboBox Values Method
        private void ComboBoxDefaultValues()
        {
            this.SecondsComboBox.SelectedIndex = 00;
            this.MinutesComboBox.SelectedIndex = 00;
            this.HoursComboBox.SelectedIndex = 00;
        }

        #endregion

        #region RunTimer Method
        private void RunTimer()
        {
            totalseconds--;

            //Get the hours, minutes and seconds values to be displayed
            int hours = totalseconds / 3600;
            int minutes = (totalseconds - hours * 3600) / 60;
            int seconds = totalseconds - hours * 3600 - minutes * 60;

            //Assign empty values to indicator strings for hours, minutes and seconds values being one digit numbers
            string hoursZeroIndicator = "";
            string minutesZeroIndicator = "";
            string secondsZeroIndicator = "";

            //If hours is a one digit number, add a 0 before it; and similarly for minutes and seconds
            if (hours < 10)
            {
                hoursZeroIndicator = "0";
            }
            if (minutes < 10)
            {
                minutesZeroIndicator = "0";
            }
            if (seconds < 10)
            {
                secondsZeroIndicator = "0";
            }

            //Display the timer
            this.TimerDisplay.Text = hoursZeroIndicator + hours.ToString() + ":" + minutesZeroIndicator + minutes.ToString() + ":" + secondsZeroIndicator + seconds.ToString();

            return;
        }
        #endregion
    }
}
