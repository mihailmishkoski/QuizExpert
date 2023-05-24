using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuizExpert
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.ToolTip toolTip;
        public Form1()
        {
            InitializeComponent();
            InitializeHelpProvider();
            InitializeToolTip();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            playClickSound();
            Form easyModeForm = new EasyModeForm();
            easyModeForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            playClickSound();
            Form mediumModeForm = new MediumModeForm();
            mediumModeForm.Show();
            this.Hide();
        }
        public async void playClickSound()
        {
            string path = Path.Combine(Environment.CurrentDirectory, "Sounds", "clickSound.wav");
            SoundPlayer player = new SoundPlayer(path);
            player.Play();
            await Task.Delay(500);
            player.Stop();
        }

        private void playHoverSound(object sender, EventArgs e)
        {

            string path = Path.Combine(Environment.CurrentDirectory, "Sounds", "Menu Tick⧸Hover (Terraria Sound) - Sound Effect for editing.wav");
            SoundPlayer player = new SoundPlayer(path);
            player.Play();
        }
        private void InitializeHelpProvider()
        {
            helpProvider1.SetHelpString(button1, "10 questions without timer");
            helpProvider1.SetHelpString(button2, "10 questions with timer");
        }

        private void InitializeToolTip()
        {
            toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(button1, helpProvider1.GetHelpString(button1));
            toolTip.SetToolTip(button2, helpProvider1.GetHelpString(button2));
        }
    }
}
