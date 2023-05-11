namespace QuizExpert
{
    public partial class Form1 : Form
    {
        public int NumberOfQuestions { get; set; } = 0;
        public int NumberOfCorrectAnswers { get; set; } = 0;
        public string correctAnswer { get; set; }

        Questions newquestion = new Questions();

        public Form1()
        {
            InitializeComponent();
            GenerateNewQuestion();
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
                }
            }
            if (NumberOfQuestions == 10)
            {
                GameOver();
            }
            GenerateNewQuestion();
        }
        private void GameOver()
        {
            DialogResult result = MessageBox.Show("Igrata zavrshi, imate " + NumberOfCorrectAnswers + " tocni odgovori", "Dali sakate nova igra?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                PlayAgain();
            }
            else
            {
                this.Close();
            }
        }
        private void PlayAgain()
        {
            newquestion = new Questions();
            NumberOfQuestions = 0;
            NumberOfCorrectAnswers = 0;
            GenerateNewQuestion();
        }

    }
}