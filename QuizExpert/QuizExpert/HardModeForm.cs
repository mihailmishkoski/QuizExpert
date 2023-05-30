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
    public partial class HardModeForm : Form
    {
        public int NumberOfQuestions { get; set; } = 0;
        public int NumberOfCorrectAnswers { get; set; } = 0;
        public string correctAnswer { get; set; }
        private int sec = 15;
        Questions newquestion = new Questions();
        public HardModeForm()
        {
            InitializeComponent();
            GenerateNewQuestion();
            timer1.Start();
        }
        private string GenerateNewQuestion()
        {
            string q = newquestion.GenerateQuestion();
            int endOfQuestion = q.IndexOf('?');
            lblQuestion.Text = q.Substring(0, endOfQuestion + 1);
            return GenerateNewAnswers(endOfQuestion, q);
        }
        private string GenerateNewAnswers(int startOfAnswers, string q)
        {

            string allAnswers = q.Substring(startOfAnswers + 1);
            List<string> allAnswersList = new List<string>();
            allAnswersList = allAnswers.Split(';').ToList();//removes ; 
            Random random = new Random();
            correctAnswer = allAnswersList[0];//go zemame tocniot odgovor koj sekogas e na pozicija 0
            List<string> shuffledAnswers = allAnswersList.Select(c => c.ToString()).OrderBy(x => random.Next()).ToList();//gi meshame odgovorite vo lista
            button1.Text = shuffledAnswers[0];
            button2.Text = shuffledAnswers[1];
            button3.Text = shuffledAnswers[2];
            button4.Text = shuffledAnswers[3];
            return correctAnswer;

        }
        private void CheckAnswer(object sender, EventArgs e)
        {
            // posle sekoe klikanje na bilo koe kopce, nezavisno od true/false da se generaria novo prasanje
            NumberOfQuestions++;
            if (NumberOfQuestions <= 10)
            {
                Button button = sender as Button;
                if (button.Text == correctAnswer)
                {
                    NumberOfCorrectAnswers++;
                    lblResult.Text = NumberOfCorrectAnswers + "/10";
                    playCorrectSound();
                    BlinkLabelGreen();
                    sec += 3;
                }
                else
                {
                    if (NumberOfCorrectAnswers > 0)
                    {
                        NumberOfCorrectAnswers--;
                    }
                    lblResult.Text = NumberOfCorrectAnswers + "/10";
                    playIncorrectSound();
                    BlinkLabelRed();
                    TimerBlinkRed();
                    sec -= 3;

                }
            }
            if (NumberOfQuestions == 10)
            {
                timer1.Stop();
                GameOver();
            }
            GenerateNewQuestion();
        }
        private void GameOver()
        {
            GameOver gameover = new GameOver(NumberOfCorrectAnswers, NumberOfQuestions, "Hard");
            gameover.SendResult();
            this.Close();
        }
        private void PlayAgain()
        {

            newquestion = new Questions();
            NumberOfQuestions = 0;
            NumberOfCorrectAnswers = 0;
            lblResult.Text = "0/10";
            sec = 15;
            lbTimer.Text = sec.ToString() + "s";
            GenerateNewQuestion();
            timer1.Start();
        }
        public void playCorrectSound()
        {
            string path = Path.Combine(Environment.CurrentDirectory, "Sounds", "SoundForCorrectAnswer.wav");
            SoundPlayer player = new SoundPlayer(path);
            player.Play();
        }
        public void playIncorrectSound()
        {
            string path = Path.Combine(Environment.CurrentDirectory, "Sounds", "SoundForIncorrectAnswer.wav");
            SoundPlayer player = new SoundPlayer(path);
            player.Play();

        }
        private async void BlinkLabelGreen()
        {
            lblResult.BackColor = Color.LightGreen;
            await Task.Delay(500);
            lblResult.BackColor = SystemColors.Control;
        }
        private async void BlinkLabelRed()
        {
            lblResult.BackColor = Color.Red;
            await Task.Delay(500);
            lblResult.BackColor = SystemColors.Control;
        }
        private async void TimerBlinkRed()
        {
            lbTimer.BackColor = Color.Red;
            await Task.Delay(100);
            lbTimer.BackColor = SystemColors.Control;
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lbTimer.Text = (sec--).ToString() + "s";
            if (sec < 10)
            {
                BlinkLabelRed();
            }
            if (sec <= -1)
            {
                timer1.Stop();
                GameOver();
            }
        }
    }
}
