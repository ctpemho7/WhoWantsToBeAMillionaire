using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WhoWantsToBeAMillionaire.Model;

namespace WhoWantsToBeAMillionaire
{
    class EFSQLiteLib
    {
        public static void QuestionInsertion(List<Question> questions)
        {
            using (var db = new MillionaireContext())
            {
                foreach (Question q in questions)
                {
                    db.Add(new DBQuestion
                    {
                        QText = q.Text,
                        QAnswerA = q.Answers[0],
                        QAnswerB = q.Answers[1],
                        QAnswerC = q.Answers[2],
                        QAnswerD = q.Answers[3],
                        QRightAnswer = q.RightAnswer,
                        QLevel = q.Level
                    });
                }
                db.SaveChanges();
            }
        }
        public static void InsertAchievement(string name, int ach)
        {
            using (var db = new MillionaireContext())
            {
                db.Add(new DBAchievement()
                {
                    Name = name,
                    Achieve = ach
                }
                    );
                db.SaveChanges();

            }
        }

        public static void ReadQuestions(List<Question> questions)
        {
            using (var db = new MillionaireContext())
            {
                var data = db.Questions;
                foreach (var row in data)
                {
                    questions.Add(new Question(row));
                }
            } 
        }
        public static void ReadLeaders(object dataGridView1)
        {
            using (var db = new MillionaireContext())
            {
                var data = db.Achievements.OrderByDescending(b => b.Achieve).Take(10);
                
                foreach (var row in data)
                {
                    ((DataGridView)dataGridView1).Rows.Add(
                        new object[] { row.Name, row.Achieve }
                        );
                }
            }
        }
    }
}
