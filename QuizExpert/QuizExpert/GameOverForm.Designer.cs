namespace QuizExpert
{
    partial class GameOverForm
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
            lblFinalResult = new Label();
            label1 = new Label();
            btnYes = new Button();
            btnNo = new Button();
            SuspendLayout();
            // 
            // lblFinalResult
            // 
            lblFinalResult.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblFinalResult.Location = new Point(34, 21);
            lblFinalResult.Name = "lblFinalResult";
            lblFinalResult.Size = new Size(376, 82);
            lblFinalResult.TabIndex = 1;
            lblFinalResult.Text = "label1";
            lblFinalResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(34, 174);
            label1.Name = "label1";
            label1.Size = new Size(274, 43);
            label1.TabIndex = 2;
            label1.Text = "Play again ?";
            // 
            // btnYes
            // 
            btnYes.Location = new Point(194, 166);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(96, 51);
            btnYes.TabIndex = 3;
            btnYes.Text = "Yes";
            btnYes.UseVisualStyleBackColor = true;
            btnYes.Click += btnYes_Click;
            // 
            // btnNo
            // 
            btnNo.Location = new Point(296, 166);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(96, 51);
            btnNo.TabIndex = 4;
            btnNo.Text = "No";
            btnNo.UseVisualStyleBackColor = true;
            btnNo.Click += btnNo_Click;
            // 
            // GameOverForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 273);
            Controls.Add(btnNo);
            Controls.Add(btnYes);
            Controls.Add(label1);
            Controls.Add(lblFinalResult);
            Margin = new Padding(3, 2, 3, 2);
            Name = "GameOverForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GameOverForm";
            ResumeLayout(false);
        }

        #endregion
        private Label lblFinalResult;
        private Label label1;
        private Button btnYes;
        private Button btnNo;
    }
}