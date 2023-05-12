namespace QuizExpert
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblQuestion = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // lblQuestion
            // 
            lblQuestion.BackColor = Color.LightSteelBlue;
            lblQuestion.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuestion.Location = new Point(70, 96);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(656, 110);
            lblQuestion.TabIndex = 0;
            lblQuestion.Text = "label1";
            lblQuestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSkyBlue;
            button1.Location = new Point(136, 259);
            button1.Name = "button1";
            button1.Size = new Size(243, 82);
            button1.TabIndex = 1;
            button1.Tag = "1";
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += CheckAnswer;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSkyBlue;
            button2.Location = new Point(411, 259);
            button2.Name = "button2";
            button2.Size = new Size(228, 82);
            button2.TabIndex = 2;
            button2.Tag = "2";
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += CheckAnswer;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSkyBlue;
            button3.Location = new Point(136, 347);
            button3.Name = "button3";
            button3.Size = new Size(243, 78);
            button3.TabIndex = 3;
            button3.Tag = "3";
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += CheckAnswer;
            // 
            // button4
            // 
            button4.BackColor = Color.LightSkyBlue;
            button4.Location = new Point(411, 347);
            button4.Name = "button4";
            button4.Size = new Size(228, 78);
            button4.TabIndex = 4;
            button4.Tag = "4";
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += CheckAnswer;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.White;
            lblResult.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lblResult.ForeColor = SystemColors.ActiveCaptionText;
            lblResult.Location = new Point(341, 9);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(116, 73);
            lblResult.TabIndex = 5;
            lblResult.Text = "0/10";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblQuestion);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            Text = "QuizExpert";
            ResumeLayout(false);
        }

        #endregion

        private Label lblQuestion;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label lblResult;
    }
}