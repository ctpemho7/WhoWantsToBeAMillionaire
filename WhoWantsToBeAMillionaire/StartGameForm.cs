using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WhoWantsToBeAMillionaire
{
    public partial class StartGameForm : Form
    {
        public string UserName;
        public string Amount;

        public StartGameForm()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 &&
                    comboBox1.SelectedItem.ToString().Length > 0)
            {
                UserName = textBox1.Text;
                Amount = comboBox1.SelectedItem.ToString();
                this.Hide();
                //textBox1.Clear();
                //comboBox1.SelectedItem = null;

                Form1 f = new Form1(this, UserName, Amount);
                f.Show();
                //Close();
            }
            else
                MessageBox.Show("Неверный ввод!");

        }
    }
}
