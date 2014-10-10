using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace McColloughEffect {
    public partial class Form1: Form {
        #region Define variables
        int currentTime = 0; //holds seconds since timer has been enabled
        Boolean currentPattern = false; //keeps current pattern state for timer
        Boolean timerOn = false;
        Timer timer = new Timer();
        #endregion

        #region Initialize stuff and setup timer
        public Form1() {
            InitializeComponent();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 1000 * 1;
            timer.Enabled = true;
            timer.Start();
        }
        #endregion

        #region Initial paint
        private void Form1_Paint(object sender, PaintEventArgs e) { //initial paint (disabled for now)
            /*e.Graphics.Clear(SystemColors.Control);
            for (int i = 0; i < 600; i=i+9) {
                if (i % 2 == 0) { //check if even
                    Pen pen = new Pen(Color.Black, 9);
                    e.Graphics.DrawLine(pen, 70, i, 600, i);
                } else {
                    Pen pen = new Pen(Color.White, 9);
                    e.Graphics.DrawLine(pen, 70, i, 600, i);
                }
            }
            e.Graphics.Dispose();*/
        }
        #endregion

        #region Pattern buttons
        private void pattern1Button_Click(object sender, EventArgs e) {
            Graphics g = this.CreateGraphics();
            g.Clear(SystemColors.Control);

            for (int i = 0; i < 600; i = i + 9) { //draws lines
                if (i % 2 == 0) { //check if even to alternate colors
                    Pen pen = new Pen(ColorTranslator.FromHtml(pattern1Hex2.Text), 9);
                    g.DrawLine(pen, 70, i, 600, i);
                } else {
                    Pen pen = new Pen(ColorTranslator.FromHtml(pattern1Hex1.Text), 9);
                    g.DrawLine(pen, 70, i, 600, i);
                }
            }
            g.Dispose(); //allows other things to use graphics
        }

        private void pattern2Button_Click(object sender, EventArgs e) {
            Graphics g = this.CreateGraphics();
            g.Clear(SystemColors.Control);

            for (int i = 0; i < 600; i = i + 9) {
                if (i % 2 == 0) { //check if even
                    Pen pen = new Pen(ColorTranslator.FromHtml(pattern2Hex2.Text), 9);
                    g.DrawLine(pen, i+73, 0, i+73, 600);
                } else {
                    Pen pen = new Pen(ColorTranslator.FromHtml(pattern2Hex1.Text), 9);
                    g.DrawLine(pen, i+73, 0, i+73, 600);
                }
            }
            g.Dispose();
        }
        #endregion

        #region Auto/stop buttons
        private void autoButton_Click(object sender, EventArgs e) {
            int n;
            if (int.TryParse(minutesBox.Text, out n) && int.TryParse(intervalBox.Text, out n)) { //makes sure that values are valid
                timerOn = true;
                autoButton.Enabled = false;
                clearButton.Enabled = false;
                minutesBox.Enabled = false;
                intervalBox.Enabled = false;
                pattern1Button.Enabled = false;
                pattern2Button.Enabled = false;
                enableSecondColor.Enabled = false;
                pattern1Hex1.Enabled = false;
                pattern2Hex1.Enabled = false;
                pattern1Hex2.Enabled = false;
                pattern2Hex2.Enabled = false;

                stopButton.Enabled = true;
            } else {
                MessageBox.Show("You did not enter a correct value for the length or the interval.");
            }
        }

        private void stopButton_Click(object sender, EventArgs e) {
            timerOn = false;
            currentTime = 0;
            timeLeft.Text = "Minutes:";
            stopButton.Enabled = false;

            autoButton.Enabled = true;
            clearButton.Enabled = true;
            minutesBox.Enabled = true;
            intervalBox.Enabled = true;
            pattern1Button.Enabled = true;
            pattern2Button.Enabled = true;
            enableSecondColor.Enabled = true;
            pattern1Hex1.Enabled = true;
            pattern2Hex1.Enabled = true;
            pattern1Hex2.Enabled = true;
            pattern2Hex2.Enabled = true;
        }
        #endregion

        #region Clear button
        private void clearButton_Click(object sender, EventArgs e) {
            Graphics g = this.CreateGraphics();
            g.Clear(SystemColors.Control); //clear graphics to "Control" color
            g.Dispose();
        }
        #endregion

        #region Enable second color button
        private void enableSecondColor_Click(object sender, EventArgs e) {
            MessageBox.Show("Notice:\nChanging the second color from black may ruin the\neffectiveness of the induction of the McCollough effect!");
            pattern1Hex2.Visible = true;
            pattern2Hex2.Visible = true;
            enableSecondColor.Enabled = false;
        }
        #endregion

        #region Timer logic
        void timer_Tick(object sender, EventArgs e) {
            if (timerOn) { //if timer is required
                currentTime++; //add second to currentTime
                if (currentTime == 1) {
                    currentPattern = !currentPattern;
                    if (currentPattern) { //if first second of timer (prevent blankness for first interval)
                        pattern1Button_Click(null, null); //print pattern 1
                    } else {
                        pattern2Button_Click(null, null); //print pattern 2
                    }
                }
                timeLeft.Text = TimeSpan.FromSeconds((Int32.Parse(minutesBox.Text)*60)-currentTime).ToString(); //display time left in label
                if (currentTime % Int32.Parse(intervalBox.Text) == 0) { //finding if current time is multiple of interval
                    currentPattern = !currentPattern; //swap pattern
                    if (currentPattern) {
                        pattern1Button_Click(null, null); //print pattern 1
                    } else {
                        pattern2Button_Click(null, null); //print pattern 2
                    }
                }
                if (currentTime > Int32.Parse(minutesBox.Text) * 60) { //if we reach the end of the timer
                    stopButton_Click(null, null); //just do the same thing as the stop button
                }
            }
        }
        #endregion

        #region Credit link
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start("https://github.com/ihatecsv");
        }
        #endregion
    }
}