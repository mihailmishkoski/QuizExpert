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
            lblFinalResult.Location = new Point(39, 28);
            lblFinalResult.Name = "lblFinalResult";
            lblFinalResult.Size = new Size(430, 109);
            lblFinalResult.TabIndex = 1;
            lblFinalResult.Text = "label1";
            lblFinalResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(39, 232);
            label1.Name = "label1";
            label1.Size = new Size(313, 57);
            label1.TabIndex = 2;
            label1.Text = "Нова игра ?";
            // 
            // btnYes
            // 
            btnYes.Location = new Point(222, 221);
            btnYes.Margin = new Padding(3, 4, 3, 4);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(110, 68);
            btnYes.TabIndex = 3;
            btnYes.Text = "Да";
            btnYes.UseVisualStyleBackColor = true;
            btnYes.Click += btnYes_Click;
            // 
            // btnNo
            // 
            btnNo.Location = new Point(338, 221);
            btnNo.Margin = new Padding(3, 4, 3, 4);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(110, 68);
            btnNo.TabIndex = 4;
            btnNo.Text = "Не";
            btnNo.UseVisualStyleBackColor = true;
            btnNo.Click += btnNo_Click;
            // 
            // GameOverForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 364);
            Controls.Add(btnNo);
            Controls.Add(btnYes);
            Controls.Add(label1);
            Controls.Add(lblFinalResult);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "GameOverForm";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
        }

        #endregion
        private Label lblFinalResult;
        private Label label1;
        private Button btnYes;
        private Button btnNo;
    }
}