using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.IO;
using System.Diagnostics;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WhoWantsToBeAMillionaire
{
    static class SQLiteUser
    {
        private static string dbFileName;

        static SQLiteConnection connection;
        static SQLiteCommand command;
        static public bool IsAvaibleToConnect(string fileName)
        {
            try
            {
                connection = new SQLiteConnection("Data Source=" + fileName + ";Version=3; FailIfMissing=False");
                connection.Open();
                dbFileName = fileName;
                return true;
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine($"Ошибка доступа к базе данных. Исключение: {ex.Message}");
                return false;
            }
        }

        public static void CreateTable()
        {
            if (!File.Exists(dbFileName))
                SQLiteConnection.CreateFile(dbFileName);

            try
            {
                connection = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
                connection.Open();

                command = new SQLiteCommand(connection);
                command.CommandText = @"CREATE TABLE IF NOT EXISTS Question 
                                        (id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE, 
                                        QText TEXT NOT NULL, 
                                        AnswerA char(100) NOT NULL,
                                        AnswerB char(100) NOT NULL,
                                        AnswerC char(100) NOT NULL,
                                        AnswerD char(100) NOT NULL,
                                        RightAnswer int NOT NULL,
                                        Level int NOT NULL);
                                       CREATE TABLE IF NOT EXISTS Achievement
                                        (id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, 
                                        Name char(100) NOT NULL,
                                        Achieve char(100) NOT NULL)";
                command.ExecuteNonQuery();

            }
            catch (SQLiteException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public static void DBConnection(string fileName, List<Question> questions)
        {
            if (!IsAvaibleToConnect(fileName))
            {
                CreateTable();
                QuestionInsertion(questions);
            }

        }

        public static void QuestionInsertion(List<Question> questions)
        {
            Stopwatch sw = new Stopwatch();
            sw.Restart();

            command = new SQLiteCommand(connection);
            command.CommandText = @"INSERT INTO Question (QText, AnswerA, AnswerB, AnswerC, AnswerD, RightAnswer, Level) 
                                    VALUES (:qText, :answerA, :answerB, :answerC, :answerD, :rightAnswer, :level)";
            try
            {
                foreach (Question q in questions)
                {
                    command.Parameters.AddWithValue("qText", q.Text);
                    command.Parameters.AddWithValue("AnswerA", q.Answers[0]);
                    command.Parameters.AddWithValue("AnswerB", q.Answers[1]);
                    command.Parameters.AddWithValue("AnswerC", q.Answers[2]);
                    command.Parameters.AddWithValue("AnswerD", q.Answers[3]);
                    command.Parameters.AddWithValue("rightAnswer", q.RightAnswer);
                    command.Parameters.AddWithValue("level", q.Level);

                    command.ExecuteNonQuery();
                }
                sw.Stop();
                Console.WriteLine(sw.Elapsed);
            }
            catch
            {
                throw;
            }
        }

        public static void InsertAchievement(string name, int ach)
        {
            Stopwatch sw = new Stopwatch();
            sw.Restart();

            command = new SQLiteCommand(connection);
            command.CommandText = @"INSERT INTO Achievement (Name, Achieve) 
                                    VALUES (:name, :achieve)";
            try
            {
                command.Parameters.AddWithValue("name", name);
                command.Parameters.AddWithValue("achieve", ach);

                command.ExecuteNonQuery();

                sw.Stop();
                Console.WriteLine(sw.Elapsed);
            }
            catch
            {
                throw;
            }
        }

        public static void ReadQuestions(List<Question> questions)
        {
            command = new SQLiteCommand(connection);
            command.CommandText = "SELECT * FROM Question";
            DataTable data = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            adapter.Fill(data);
            Console.WriteLine($"Прочитано {data.Rows.Count} записей из таблицы БД");

            foreach (DataRow row in data.Rows)
            {
                questions.Add(new Question(row));
            }
        }

        public static void ReadLeaders(object dataGridView1)
        {
            command = new SQLiteCommand(connection);
            command.CommandText = "SELECT * FROM Achievement ORDER BY Achieve DESC LIMIT 10";
            DataTable data = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            adapter.Fill(data);
            Console.WriteLine($"Прочитано {data.Rows.Count} записей из таблицы БД");

            foreach (DataRow row in data.Rows)
            {
                ((DataGridView)dataGridView1).Rows.Add(
                    new object[] {row[1], row[2]}
                    );
            }
        }

    }
}
