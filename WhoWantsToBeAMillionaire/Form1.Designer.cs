
namespace WhoWantsToBeAMillionaire
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnAnswerA = new System.Windows.Forms.Button();
            this.btnAnswerB = new System.Windows.Forms.Button();
            this.btnAnswerC = new System.Windows.Forms.Button();
            this.btnAnswerD = new System.Windows.Forms.Button();
            this.lstLevel = new System.Windows.Forms.ListBox();
            this.bntFiftyFifty = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonFriendCall = new System.Windows.Forms.Button();
            this.buttonМistake = new System.Windows.Forms.Button();
            this.buttonQuestChang = new System.Windows.Forms.Button();
            this.labelX2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelGamer = new System.Windows.Forms.Label();
            this.labelSum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonMoney = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WhoWantsToBeAMillionaire.Properties.Resources.maxresdefault;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(631, 392);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuestion.Location = new System.Drawing.Point(12, 420);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(630, 116);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "label1";
            // 
            // btnAnswerA
            // 
            this.btnAnswerA.Location = new System.Drawing.Point(12, 539);
            this.btnAnswerA.Name = "btnAnswerA";
            this.btnAnswerA.Size = new System.Drawing.Size(310, 65);
            this.btnAnswerA.TabIndex = 2;
            this.btnAnswerA.Tag = "1";
            this.btnAnswerA.Text = "button1";
            this.btnAnswerA.UseVisualStyleBackColor = true;
            this.btnAnswerA.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btnAnswerB
            // 
            this.btnAnswerB.Location = new System.Drawing.Point(12, 629);
            this.btnAnswerB.Name = "btnAnswerB";
            this.btnAnswerB.Size = new System.Drawing.Size(310, 65);
            this.btnAnswerB.TabIndex = 3;
            this.btnAnswerB.Tag = "2";
            this.btnAnswerB.Text = "button2";
            this.btnAnswerB.UseVisualStyleBackColor = true;
            this.btnAnswerB.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btnAnswerC
            // 
            this.btnAnswerC.Location = new System.Drawing.Point(333, 539);
            this.btnAnswerC.Name = "btnAnswerC";
            this.btnAnswerC.Size = new System.Drawing.Size(310, 65);
            this.btnAnswerC.TabIndex = 4;
            this.btnAnswerC.Tag = "3";
            this.btnAnswerC.Text = "button3";
            this.btnAnswerC.UseVisualStyleBackColor = true;
            this.btnAnswerC.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btnAnswerD
            // 
            this.btnAnswerD.Location = new System.Drawing.Point(333, 629);
            this.btnAnswerD.Name = "btnAnswerD";
            this.btnAnswerD.Size = new System.Drawing.Size(310, 65);
            this.btnAnswerD.TabIndex = 5;
            this.btnAnswerD.Tag = "4";
            this.btnAnswerD.Text = "button4";
            this.btnAnswerD.UseVisualStyleBackColor = true;
            this.btnAnswerD.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // lstLevel
            // 
            this.lstLevel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstLevel.FormattingEnabled = true;
            this.lstLevel.ItemHeight = 22;
            this.lstLevel.Items.AddRange(new object[] {
            "3 000 000",
            "1 500 000",
            "800 000",
            "400 000",
            "200 000",
            "100 000",
            "50 000",
            "25 000",
            "15 000",
            "10 000",
            "5 000",
            "3 000",
            "2 000",
            "1 000",
            "500"});
            this.lstLevel.Location = new System.Drawing.Point(662, 12);
            this.lstLevel.Name = "lstLevel";
            this.lstLevel.Size = new System.Drawing.Size(150, 400);
            this.lstLevel.TabIndex = 6;
            // 
            // bntFiftyFifty
            // 
            this.bntFiftyFifty.Location = new System.Drawing.Point(662, 476);
            this.bntFiftyFifty.Name = "bntFiftyFifty";
            this.bntFiftyFifty.Size = new System.Drawing.Size(150, 50);
            this.bntFiftyFifty.TabIndex = 7;
            this.bntFiftyFifty.Text = "50/50";
            this.bntFiftyFifty.UseVisualStyleBackColor = true;
            this.bntFiftyFifty.Click += new System.EventHandler(this.bntFiftyFifty_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(662, 420);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(150, 50);
            this.buttonHelp.TabIndex = 8;
            this.buttonHelp.Text = "Помощь зала";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonFriendCall
            // 
            this.buttonFriendCall.Location = new System.Drawing.Point(662, 532);
            this.buttonFriendCall.Name = "buttonFriendCall";
            this.buttonFriendCall.Size = new System.Drawing.Size(150, 50);
            this.buttonFriendCall.TabIndex = 9;
            this.buttonFriendCall.Text = "Звонок другу";
            this.buttonFriendCall.UseVisualStyleBackColor = true;
            this.buttonFriendCall.Click += new System.EventHandler(this.buttonFriendCall_Click);
            // 
            // buttonМistake
            // 
            this.buttonМistake.Location = new System.Drawing.Point(662, 588);
            this.buttonМistake.Name = "buttonМistake";
            this.buttonМistake.Size = new System.Drawing.Size(150, 50);
            this.buttonМistake.TabIndex = 10;
            this.buttonМistake.Text = "Право на ошибку";
            this.buttonМistake.UseVisualStyleBackColor = true;
            this.buttonМistake.Click += new System.EventHandler(this.buttonМistake_Click);
            // 
            // buttonQuestChang
            // 
            this.buttonQuestChang.Location = new System.Drawing.Point(662, 644);
            this.buttonQuestChang.Name = "buttonQuestChang";
            this.buttonQuestChang.Size = new System.Drawing.Size(150, 50);
            this.buttonQuestChang.TabIndex = 11;
            this.buttonQuestChang.Text = "Замена вопроса";
            this.buttonQuestChang.UseVisualStyleBackColor = true;
            this.buttonQuestChang.Click += new System.EventHandler(this.buttonQuestChang_Click);
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.labelX2.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelX2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX2.Location = new System.Drawing.Point(305, 602);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(46, 36);
            this.labelX2.TabIndex = 12;
            this.labelX2.Tag = "first try";
            this.labelX2.Text = "x2";
            this.labelX2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(839, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Игрок:";
            // 
            // labelGamer
            // 
            this.labelGamer.AutoSize = true;
            this.labelGamer.Location = new System.Drawing.Point(839, 33);
            this.labelGamer.Name = "labelGamer";
            this.labelGamer.Size = new System.Drawing.Size(50, 20);
            this.labelGamer.TabIndex = 15;
            this.labelGamer.Text = "label2";
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Location = new System.Drawing.Point(839, 85);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(50, 20);
            this.labelSum.TabIndex = 17;
            this.labelSum.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(839, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Несгораемая сумма:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(818, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(263, 422);
            this.dataGridView1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(818, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Топ 10 игроков:";
            // 
            // buttonMoney
            // 
            this.buttonMoney.Location = new System.Drawing.Point(818, 588);
            this.buttonMoney.Name = "buttonMoney";
            this.buttonMoney.Size = new System.Drawing.Size(263, 50);
            this.buttonMoney.TabIndex = 20;
            this.buttonMoney.Text = "Забрать деньги";
            this.buttonMoney.UseVisualStyleBackColor = true;
            this.buttonMoney.Click += new System.EventHandler(this.buttonMoney_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(818, 647);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(263, 47);
            this.button2.TabIndex = 21;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 711);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonMoney);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelGamer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.buttonQuestChang);
            this.Controls.Add(this.buttonМistake);
            this.Controls.Add(this.buttonFriendCall);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.bntFiftyFifty);
            this.Controls.Add(this.lstLevel);
            this.Controls.Add(this.btnAnswerD);
            this.Controls.Add(this.btnAnswerC);
            this.Controls.Add(this.btnAnswerB);
            this.Controls.Add(this.btnAnswerA);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Игра \"Кто хочет стать миллионером?\"";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnAnswerA;
        private System.Windows.Forms.Button btnAnswerB;
        private System.Windows.Forms.Button btnAnswerC;
        private System.Windows.Forms.Button btnAnswerD;
        private System.Windows.Forms.ListBox lstLevel;
        private System.Windows.Forms.Button bntFiftyFifty;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonFriendCall;
        private System.Windows.Forms.Button buttonМistake;
        private System.Windows.Forms.Button buttonQuestChang;
        private System.Windows.Forms.Label labelX2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelGamer;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonMoney;
        private System.Windows.Forms.Button button2;
    }
}

