using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhoWantsToBeAMillionaire
{
    public partial class Form1 : Form
    {
        List<Question> questions = new List<Question>();
        private Random rnd = new Random();
        int level = 0;
        Question currentQuestion;
        string UserName;
        string SelectedSum;
        string fileName = "sample1.sqlite";
        StartGameForm FormParent;
        int usedHints { get; set; }

        public Form1(StartGameForm f, string name, string amount)
        {
            InitializeComponent();
            UserName = name;
            SelectedSum = amount;
            FormParent = f;
            labelGamer.Text = UserName;
            labelSum.Text = SelectedSum;
            SetDataGrid(); //изменение датагрид нужным образом

            //ReadFile(); //загружать из бд а не из тхт
            //ReadSQLite(); //загружать из бд без EF
            EFRead();
            startGame();
        }

        private void EFRead()
        {
            EFSQLiteLib.ReadQuestions(questions);
            //EFSQLiteLib.ReadLeaders((object)dataGridView1);
        }
        private void ReadSQLite()
        {
            SQLiteUser.DBConnection(fileName, questions);
            SQLiteUser.ReadQuestions(questions);
            SQLiteUser.ReadLeaders((object)dataGridView1);
        }

        private void SetDataGrid()
        {
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "Игрок";
            dataGridView1.Columns[1].Name = "Сумма";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void ReadFile()
        {
            string path = @"D:\HSE YEARS\second year\kpo\seminars\WhoWantsToBeAMillionaire1\WhoWantsToBeAMillionaire\Вопросы.txt";

            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    questions.Add(new Question(line.Split('\t')));
                }
            }
        }
        private void ShowQuestion(Question q)
        {
            lblQuestion.Text = q.Text;
            btnAnswerA.Text = q.Answers[0];
            btnAnswerB.Text = q.Answers[1];
            btnAnswerC.Text = q.Answers[2];
            btnAnswerD.Text = q.Answers[3];
        }
        private Question GetQuestion(int level)
        {
            var questionsWithLevel = questions.Where(q => q.Level == level).ToList();
            return questionsWithLevel[rnd.Next(questionsWithLevel.Count)];
        }
        private void NextStep()
        {
            Button[] btns = new Button[] { btnAnswerA, btnAnswerB, btnAnswerC, btnAnswerD };

            foreach (Button btn in btns)
                btn.Enabled = true;

            level++;

            currentQuestion = GetQuestion(level);
            ShowQuestion(currentQuestion);
            lstLevel.SelectedIndex = lstLevel.Items.Count - level;
            labelX2.Visible = false;
            labelX2.Tag = "first try";
        }
        private void startGame()
        {
            usedHints = 0;
            level = 0;
            EFSQLiteLib.ReadLeaders((object)dataGridView1);
            SetHintsButtons(true);
            NextStep();
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (currentQuestion.RightAnswer == int.Parse(button.Tag.ToString()))
                if (lstLevel.SelectedIndex != 0)
                    NextStep();
                else //а если мы дошли до трёх миллионов
                {
                    MessageBox.Show("Вы победили!", "Поздравляем!");
                    EFSQLiteLib.InsertAchievement(UserName, 3000000);
                    FormParent.Show();
                    Close();
                }
            else
            {
                if (labelX2.Visible && labelX2.Tag.ToString() == "first try")
                {
                    MessageBox.Show("У вас есть право на ошибку!", "Неверный ответ!");
                    ((Button)sender).Enabled = false;
                    labelX2.Tag = "second try";
                }
                else
                {
                    int reachedsum = Int32.Parse(lstLevel.SelectedItem.ToString().Replace(" ", ""));
                    int selectedsum = Int32.Parse(SelectedSum.ToString().Replace(" ", ""));

                    int prize = 0;
                    if (reachedsum > selectedsum)  //на подумать тут
                    {
                        EFSQLiteLib.InsertAchievement(UserName, selectedsum);
                        prize = selectedsum;
                    }
                    MessageBox.Show($"Игра начинается сначала!\nВаш выигрыш: {prize}", "Неверный ответ!");

                    FormParent.Show();
                    Close();
                    //startGame();                    
                }
            }
        }

        void CheckHintsAviable()
        {
            usedHints++;
            if (usedHints > 3)
                SetHintsButtons(false);

        }

        void SetHintsButtons(bool status)
        {
            bntFiftyFifty.Enabled = status;
            buttonFriendCall.Enabled = status;
            buttonHelp.Enabled = status;
            buttonQuestChang.Enabled = status;
            buttonМistake.Enabled = status;
        }

        private void bntFiftyFifty_Click(object sender, EventArgs e)
        {
            Button[] btns = new Button[] { btnAnswerA, btnAnswerB,
                btnAnswerC, btnAnswerC };

            int count = 0;
            while (count < 2)
            {
                int n = rnd.Next(4);
                int answer = int.Parse(btns[n].Tag.ToString());

                if (answer != currentQuestion.RightAnswer && btns[n].Enabled)
                {
                    btns[n].Enabled = false;
                    count++;
                }
            }
            bntFiftyFifty.Enabled = false;
            CheckHintsAviable();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            int first = rnd.Next(60);
            int second = rnd.Next(100 - first);
            int third = rnd.Next(100 - first - second);
            int fourth = 100 - first - second - third;

            var percentages = new int[] { first, second, third, fourth };
            var answers = new string[] { btnAnswerA.Text, btnAnswerB.Text, btnAnswerC.Text, btnAnswerD.Text };

            int maxValue = percentages.Max();
            int maxIndex = percentages.ToList().IndexOf(maxValue);

            int tmp = percentages[currentQuestion.RightAnswer - 1];
            percentages[currentQuestion.RightAnswer - 1] = percentages[maxIndex];
            percentages[maxIndex] = tmp;

            // string answer = $"{answers[currentQuestion.RightAnswer]} : {percentages.Max()}%\n";
            string results = string.Empty;
            for (int i = 0; i < 4; i++)
            {
                results += $"{answers[i]} : {percentages[i]}%\n";
            }

            MessageBox.Show(results, "Результаты зрительского голосования:");

            buttonHelp.Enabled = false;
            CheckHintsAviable();
        }

        private void buttonFriendCall_Click(object sender, EventArgs e)
        {
            TimerCall timerCall = new TimerCall(currentQuestion);
            timerCall.Show();
            buttonFriendCall.Enabled = false;
            CheckHintsAviable();
        }

        private void buttonМistake_Click(object sender, EventArgs e)
        {
            labelX2.Visible = true;
            buttonМistake.Enabled = false;
            CheckHintsAviable();
        }

        private void buttonQuestChang_Click(object sender, EventArgs e)
        {
            Button[] btns = new Button[] { btnAnswerA, btnAnswerB, btnAnswerC, btnAnswerC };

            foreach (Button btn in btns)
                btn.Enabled = true;

            currentQuestion = GetQuestion(level);
            ShowQuestion(currentQuestion);
            lstLevel.SelectedIndex = lstLevel.Items.Count - level;

            buttonQuestChang.Enabled = false;
            CheckHintsAviable();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormParent.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Ваш прогресс не будет сохранён", "Вы хотите закончить игру?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                FormParent.Show();
                Close();
            }
        }

        private void buttonMoney_Click(object sender, EventArgs e)
        {
            int currentsum = 0;

            if (lstLevel.SelectedIndex != 14)
                currentsum = Int32.Parse(lstLevel.Items[lstLevel.SelectedIndex + 1].ToString().Replace(" ", ""));

            DialogResult result = MessageBox.Show($"Ваш выигрыш: {currentsum}", "Вы хотите закончить игру?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                EFSQLiteLib.InsertAchievement(UserName, currentsum);
                FormParent.Show();
                Close();
            }
        }
    }
}
