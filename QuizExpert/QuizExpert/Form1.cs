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

namespace QuizExpert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form easyModeForm = new EasyModeForm();
            easyModeForm.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form mediumModeForm = new MediumModeForm();
            mediumModeForm.Show();
            this.Hide();
        }
    }
}
