using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizExpert
{
    public class GameOver
    {
        GameOverForm formGameOver = new GameOverForm();
        public float correctAnswers { get; set; }
        public float numberQuestions { get; set; }

        public string gameMode { get; set; }
        public GameOver(int correctAnswers, int numberQuestions, string gameMode) 
        {
            this.correctAnswers = correctAnswers;
            this.numberQuestions = numberQuestions;
            this.gameMode = gameMode;
        }
        public GameOver() { }
        public void SendResult()
        {
            string res = "";
            if(correctAnswers/numberQuestions > 0.9)
            {
                res += "Congratulations! You scored over 90%!";
            }
            else if(correctAnswers/numberQuestions > 0.8)
            {
                res += "Great job! You scored over 80%!";
            }
            else if (correctAnswers/numberQuestions > 0.7)
            {
                res += "Well done! You scored over 70%!";
            }
            else if (correctAnswers/numberQuestions > 0.6)
            {
                res += "Good effort! You scored over 60%!";
            }
            else if (correctAnswers/numberQuestions > 0.5)
            {
                res += "You scored over 50%. Keep it up!";
            }
            else
            {
                res += "Try again. Your score is below 50%.";
            }
            formGameOver.generateWindow(res,gameMode);
        }
        
    }
}
