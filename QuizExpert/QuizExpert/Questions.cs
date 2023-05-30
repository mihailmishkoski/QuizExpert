using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace QuizExpert
{
    public class Questions
    {
        public List<string> questionsList = new List<string>() { "Колку бити има еден бајт?8;1;4;16", "Кој го направил Facebook?Mark Zuckenberg;Elon Musk;Nikola Tesla;Bill Gates", "Што е Java?Програмски јазик;Видео игра;Тип на кафе;Првиот компјутер за канцелариска употреба", "Што е алгоритам?Конечна низа чекори што водат кон решение;Библиотека во C++;Тип на процесор во компјутерите;Начин на компајлирање", "Коjа година се појавил Google Chrome?2008;2009;2007;2006", "Што создал Денис Ричи?Јазикот C;Првиот компјутер;Првиот вирус;Интернетот", "Која е првата компјутерска игра со голема популарност?Space War;Game of Thrones;Nintendo;Football Manager", "Кој е првиот програмер?Ада Огуста Кинг;Денис Ричи;Стив Џобс;Мајкл Џордан", "Што е ARPANet?Мрежа за брза размена на информации;Мрежа за шпиунирање;Првиот сервер напревен од владата на САД;Програмски јазик", "Кој е првиот комерцијален сметач?UNIVAC;ENIAC;POP3;SMTP", "Што претставува Паскалин?Mеханички калкулатор со автоматски пренос на позициите;Фабрика за производство на кафе;Математички модел што помогнал во развојот на компјутерите;Алгоритам со кој работи РАМ меморијата", "RAM-от е?Непостојан(чува податоци само додека е под напон);Непостојан(ги чува податоците и кога е исклучен);Постојан(ги чува податоците и кога е исклучен);Постојан(ги чува само најбитните податоци)", "Од кои бои се формира една боја на екранот?црвена, зелена и сина;црвена, зелена и жолта;црвена, црна и сина;од сите бои кои постојат" };                                                                                                                                                                                                                                                                                     
        Random random = new Random();
        public Questions() {}
        public string GenerateQuestion()
        {
            try
            {
                if(questionsList.Count > 0)
                {
                    string q = questionsList[random.Next(0, questionsList.Count)];
                    questionsList.Remove(q);
                    return q;
                }
                else
                {
                    string q = questionsList[random.Next(0, questionsList.Count)];
                    questionsList.Remove(q);
                    return q;
                }
            }
            catch(IndexOutOfRangeException) { return "No more questions"; }
        }
    }
}
