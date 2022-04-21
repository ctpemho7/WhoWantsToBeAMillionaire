using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhoWantsToBeAMillionaire
{
    public class Question
    {
        public string Text { get; private set; }
        public string[] Answers { get; private set; }
        public int RightAnswer { get; private set; }
        public int Level { get; private set; }
        public Question(string[] s)
        {
            Text = s[0];
            Answers = new string[4];
            for (int i = 0; i < 4; i++)
                Answers[i] = s[i + 1];
            RightAnswer = int.Parse(s[5]);
            Level = int.Parse(s[6]);
        }
        public Question(DataRow row)
        {
            Text = row[1].ToString();
            Answers = new string[4];
            for (int i = 2; i < 6; i++)
                Answers[i-2] = row[i].ToString();

            RightAnswer = int.Parse(row[6].ToString());
            Level = int.Parse(row[7].ToString());
        }

        public Question(Model.DBQuestion dBQuestion)
        {
            Text = dBQuestion.QText;
            Answers = new string[4] { dBQuestion.QAnswerA, dBQuestion.QAnswerB, dBQuestion.QAnswerC, dBQuestion.QAnswerD };
            
            RightAnswer = dBQuestion.QRightAnswer;
            Level = dBQuestion.QLevel;
        }
    }
}
