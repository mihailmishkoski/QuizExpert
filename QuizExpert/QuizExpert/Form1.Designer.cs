﻿namespace QuizExpert
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
            SuspendLayout();
            // 
            // lblQuestion
            // 
            lblQuestion.Location = new Point(44, 28);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(682, 164);
            lblQuestion.TabIndex = 0;
            lblQuestion.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(136, 259);
            button1.Name = "button1";
            button1.Size = new Size(243, 82);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += CheckAnswer;
            // 
            // button2
            // 
            button2.Location = new Point(411, 259);
            button2.Name = "button2";
            button2.Size = new Size(228, 82);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += CheckAnswer;
            // 
            // button3
            // 
            button3.Location = new Point(136, 347);
            button3.Name = "button3";
            button3.Size = new Size(243, 78);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += CheckAnswer;
            // 
            // button4
            // 
            button4.Location = new Point(411, 347);
            button4.Name = "button4";
            button4.Size = new Size(228, 78);
            button4.TabIndex = 4;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += CheckAnswer;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblQuestion);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label lblQuestion;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}