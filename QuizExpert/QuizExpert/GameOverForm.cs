using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizExpert
{
    public partial class GameOverForm : Form
    {
        string gameMode = "";
        public GameOverForm()
        {
            InitializeComponent();
        }
        public void generateWindow(string result, string gameMode)
        {
            lblFinalResult.Text = result;
            this.Show();
            this.gameMode = gameMode;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            if(gameMode=="Easy")
            {
                EasyModeForm form = new EasyModeForm();
                form.Show();
                this.Close();
            }
            else
            {
                MediumModeForm form = new MediumModeForm();
                form.Show();
                this.Close();
            }
            
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }
    }
}
