namespace QuizExpert
{
    partial class Form3
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
            components = new System.ComponentModel.Container();
            lbTimer = new Label();
            lblResult = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            lblQuestion = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            Timer2 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lbTimer
            // 
            lbTimer.AutoSize = true;
            lbTimer.BackColor = Color.Azure;
            lbTimer.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbTimer.Location = new Point(710, 35);
            lbTimer.Name = "lbTimer";
            lbTimer.Size = new Size(28, 35);
            lbTimer.TabIndex = 13;
            lbTimer.Text = "0";
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.White;
            lblResult.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lblResult.ForeColor = SystemColors.ActiveCaptionText;
            lblResult.Location = new Point(333, 17);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(116, 73);
            lblResult.TabIndex = 12;
            lblResult.Text = "0/10";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            button4.BackColor = Color.LightSkyBlue;
            button4.Location = new Point(403, 355);
            button4.Name = "button4";
            button4.Size = new Size(228, 78);
            button4.TabIndex = 11;
            button4.Tag = "4";
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += CheckAnswer;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSkyBlue;
            button3.Location = new Point(128, 355);
            button3.Name = "button3";
            button3.Size = new Size(243, 78);
            button3.TabIndex = 10;
            button3.Tag = "3";
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += CheckAnswer;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSkyBlue;
            button2.Location = new Point(403, 267);
            button2.Name = "button2";
            button2.Size = new Size(228, 82);
            button2.TabIndex = 9;
            button2.Tag = "2";
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += CheckAnswer;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSkyBlue;
            button1.Location = new Point(128, 267);
            button1.Name = "button1";
            button1.Size = new Size(243, 82);
            button1.TabIndex = 8;
            button1.Tag = "1";
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += CheckAnswer;
            // 
            // lblQuestion
            // 
            lblQuestion.BackColor = Color.LightSteelBlue;
            lblQuestion.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuestion.Location = new Point(62, 104);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(656, 110);
            lblQuestion.TabIndex = 7;
            lblQuestion.Text = "label1";
            lblQuestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            // 
            // Timer2
            // 
            Timer2.Enabled = true;
            Timer2.Interval = 1000;
            Timer2.Tick += Timer2_Tick_1;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(lbTimer);
            Controls.Add(lblResult);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblQuestion);
            Name = "Form3";
            Text = "QuizExpert - Hard Mode";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lbTimer;
        public Label lblResult;
        public Button button4;
        public Button button3;
        public Button button2;
        public Button button1;
        public Label lblQuestion;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Timer Timer2;
    }
}