namespace McColloughEffect {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.pattern1Button = new System.Windows.Forms.Button();
            this.pattern2Button = new System.Windows.Forms.Button();
            this.autoButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.pattern1Hex1 = new System.Windows.Forms.TextBox();
            this.pattern1Hex2 = new System.Windows.Forms.TextBox();
            this.pattern2Hex1 = new System.Windows.Forms.TextBox();
            this.pattern2Hex2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.timeLeft = new System.Windows.Forms.Label();
            this.minutesBox = new System.Windows.Forms.TextBox();
            this.enableSecondColor = new System.Windows.Forms.Button();
            this.intervalBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pattern1Button
            // 
            this.pattern1Button.Location = new System.Drawing.Point(1, 1);
            this.pattern1Button.Name = "pattern1Button";
            this.pattern1Button.Size = new System.Drawing.Size(58, 23);
            this.pattern1Button.TabIndex = 0;
            this.pattern1Button.Text = "Pattern 1";
            this.pattern1Button.UseVisualStyleBackColor = true;
            this.pattern1Button.Click += new System.EventHandler(this.pattern1Button_Click);
            // 
            // pattern2Button
            // 
            this.pattern2Button.Location = new System.Drawing.Point(1, 30);
            this.pattern2Button.Name = "pattern2Button";
            this.pattern2Button.Size = new System.Drawing.Size(58, 23);
            this.pattern2Button.TabIndex = 1;
            this.pattern2Button.Text = "Pattern 2";
            this.pattern2Button.UseVisualStyleBackColor = true;
            this.pattern2Button.Click += new System.EventHandler(this.pattern2Button_Click);
            // 
            // autoButton
            // 
            this.autoButton.Location = new System.Drawing.Point(1, 173);
            this.autoButton.Name = "autoButton";
            this.autoButton.Size = new System.Drawing.Size(58, 23);
            this.autoButton.TabIndex = 2;
            this.autoButton.Text = "Auto";
            this.autoButton.UseVisualStyleBackColor = true;
            this.autoButton.Click += new System.EventHandler(this.autoButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(1, 202);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(58, 23);
            this.stopButton.TabIndex = 3;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // pattern1Hex1
            // 
            this.pattern1Hex1.Location = new System.Drawing.Point(2, 322);
            this.pattern1Hex1.Name = "pattern1Hex1";
            this.pattern1Hex1.Size = new System.Drawing.Size(57, 20);
            this.pattern1Hex1.TabIndex = 6;
            this.pattern1Hex1.Text = "#FF0000";
            // 
            // pattern1Hex2
            // 
            this.pattern1Hex2.Location = new System.Drawing.Point(2, 348);
            this.pattern1Hex2.Name = "pattern1Hex2";
            this.pattern1Hex2.Size = new System.Drawing.Size(57, 20);
            this.pattern1Hex2.TabIndex = 7;
            this.pattern1Hex2.Text = "#000000";
            this.pattern1Hex2.Visible = false;
            // 
            // pattern2Hex1
            // 
            this.pattern2Hex1.Location = new System.Drawing.Point(2, 400);
            this.pattern2Hex1.Name = "pattern2Hex1";
            this.pattern2Hex1.Size = new System.Drawing.Size(57, 20);
            this.pattern2Hex1.TabIndex = 8;
            this.pattern2Hex1.Text = "#00FF00";
            // 
            // pattern2Hex2
            // 
            this.pattern2Hex2.Location = new System.Drawing.Point(2, 426);
            this.pattern2Hex2.Name = "pattern2Hex2";
            this.pattern2Hex2.Size = new System.Drawing.Size(57, 20);
            this.pattern2Hex2.TabIndex = 9;
            this.pattern2Hex2.Text = "#000000";
            this.pattern2Hex2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pattern 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Pattern 2";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(1, 260);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(58, 23);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // timeLeft
            // 
            this.timeLeft.AutoSize = true;
            this.timeLeft.Location = new System.Drawing.Point(-2, 94);
            this.timeLeft.Name = "timeLeft";
            this.timeLeft.Size = new System.Drawing.Size(65, 13);
            this.timeLeft.TabIndex = 15;
            this.timeLeft.Text = "Length(min):";
            // 
            // minutesBox
            // 
            this.minutesBox.Location = new System.Drawing.Point(1, 110);
            this.minutesBox.Name = "minutesBox";
            this.minutesBox.Size = new System.Drawing.Size(57, 20);
            this.minutesBox.TabIndex = 16;
            this.minutesBox.Text = "10";
            // 
            // enableSecondColor
            // 
            this.enableSecondColor.Location = new System.Drawing.Point(1, 452);
            this.enableSecondColor.Name = "enableSecondColor";
            this.enableSecondColor.Size = new System.Drawing.Size(58, 50);
            this.enableSecondColor.TabIndex = 18;
            this.enableSecondColor.Text = "Enable second color";
            this.enableSecondColor.UseVisualStyleBackColor = true;
            this.enableSecondColor.Click += new System.EventHandler(this.enableSecondColor_Click);
            // 
            // intervalBox
            // 
            this.intervalBox.Location = new System.Drawing.Point(1, 149);
            this.intervalBox.Name = "intervalBox";
            this.intervalBox.Size = new System.Drawing.Size(57, 20);
            this.intervalBox.TabIndex = 20;
            this.intervalBox.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-2, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Interval(sec):";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(-1, 542);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(47, 13);
            this.linkLabel1.TabIndex = 21;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "ihatecsv";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-1, 529);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Written by";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.intervalBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.enableSecondColor);
            this.Controls.Add(this.minutesBox);
            this.Controls.Add(this.timeLeft);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pattern2Hex2);
            this.Controls.Add(this.pattern2Hex1);
            this.Controls.Add(this.pattern1Hex2);
            this.Controls.Add(this.pattern1Hex1);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.autoButton);
            this.Controls.Add(this.pattern2Button);
            this.Controls.Add(this.pattern1Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "McCollough Effect Inducer";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pattern1Button;
        private System.Windows.Forms.Button pattern2Button;
        private System.Windows.Forms.Button autoButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.TextBox pattern1Hex1;
        private System.Windows.Forms.TextBox pattern1Hex2;
        private System.Windows.Forms.TextBox pattern2Hex1;
        private System.Windows.Forms.TextBox pattern2Hex2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label timeLeft;
        private System.Windows.Forms.TextBox minutesBox;
        private System.Windows.Forms.Button enableSecondColor;
        private System.Windows.Forms.TextBox intervalBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label4;
    }
}

