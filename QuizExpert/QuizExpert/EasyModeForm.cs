using System.Media;

namespace QuizExpert
{
    public partial class EasyModeForm : Form
    {
        public int NumberOfQuestions { get; set; } = 0;
        public int NumberOfCorrectAnswers { get; set; } = 0;
        public string correctAnswer { get; set; }
        public int seconds = 30;
        Questions newquestion = new Questions();

        public EasyModeForm()
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
                }
                else
                {
                    playIncorrectSound();
                    BlinkLabelRed();
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
            DialogResult result = MessageBox.Show("Imate " + NumberOfCorrectAnswers + " tocni odgovori. Dali sakate nova igra?", "Igrata zavrshi", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                PlayAgain();
            }
            else
            {
                this.Close();
                Form1 form1 = new Form1();
                form1.ShowDialog();
            }

        }
        private void PlayAgain()
        {

            newquestion = new Questions();
            NumberOfQuestions = 0;
            NumberOfCorrectAnswers = 0;
            lblResult.Text = "0/10";
            GenerateNewQuestion();
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
    }
}