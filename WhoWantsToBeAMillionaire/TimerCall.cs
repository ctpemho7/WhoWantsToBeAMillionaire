using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhoWantsToBeAMillionaire
{
    public partial class TimerCall : Form
    {
        Random rnd = new Random();
        Question Question;
        int HintTime;
        public TimerCall(Question q)
        {
            Question = q;
            HintTime = rnd.Next(1, 31) * 10;
            InitializeComponent();
            timer1.Interval = 1000; // 1000 миллисекунд = 1 сек
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
        }

        // обработчик события Tick таймера
        void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == progressBar1.Maximum)
                Close();
            if (progressBar1.Value == HintTime)
                labelFriendHint.Text = SetFriendHint();

            progressBar1.PerformStep();

        }

        private string SetFriendHint()
        {
            int letter = rnd.Next(0, 4); // в случайный момент времени подсказка

            string[] letters = new string[] { "A", "B", "C", "D" };
            string[] answers = new string[] { "Друг не знает ответ!",  $"Друг сомневается, но его ответ {letter}",
            "Друг точно уверен: ответ под буквой С!", $"Друг ответил бы так: {letters[Question.RightAnswer]}",
            "О нет! Похоже собака друга перегрызла провод, вы не сможете переговорить с другом!"};

            return answers[rnd.Next(0, answers.Length)];
        }
    }
}
