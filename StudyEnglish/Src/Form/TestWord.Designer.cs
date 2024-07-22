namespace StudyEnglish
{
    partial class TestWord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbAll = new System.Windows.Forms.CheckBox();
            this.cblLesson = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbNotify = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lbProQues = new System.Windows.Forms.Label();
            this.btnSound = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbVi = new System.Windows.Forms.RadioButton();
            this.rbEn = new System.Windows.Forms.RadioButton();
            this.lbWord = new System.Windows.Forms.Label();
            this.lbProView = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbRemain = new System.Windows.Forms.Label();
            this.LbIncorrect = new System.Windows.Forms.Label();
            this.lbCorrect = new System.Windows.Forms.Label();
            this.lbSum = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbVi = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSound)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbQuestion
            // 
            this.tbQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQuestion.Location = new System.Drawing.Point(27, 69);
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.Size = new System.Drawing.Size(190, 28);
            this.tbQuestion.TabIndex = 1;
            // 
            // tbAnswer
            // 
            this.tbAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAnswer.Location = new System.Drawing.Point(27, 162);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(190, 28);
            this.tbAnswer.TabIndex = 2;
            this.tbAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAnswer_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbAll);
            this.groupBox1.Controls.Add(this.cblLesson);
            this.groupBox1.Location = new System.Drawing.Point(34, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 463);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lesson";
            // 
            // cbAll
            // 
            this.cbAll.AutoSize = true;
            this.cbAll.Location = new System.Drawing.Point(172, 21);
            this.cbAll.Name = "cbAll";
            this.cbAll.Size = new System.Drawing.Size(85, 20);
            this.cbAll.TabIndex = 1;
            this.cbAll.Text = "Select All";
            this.cbAll.UseVisualStyleBackColor = true;
            this.cbAll.Click += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cblLesson
            // 
            this.cblLesson.CheckOnClick = true;
            this.cblLesson.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cblLesson.FormattingEnabled = true;
            this.cblLesson.Location = new System.Drawing.Point(6, 59);
            this.cblLesson.Name = "cblLesson";
            this.cblLesson.Size = new System.Drawing.Size(242, 372);
            this.cblLesson.TabIndex = 0;
            this.cblLesson.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cblLesson_ItemCheck);
            this.cblLesson.SelectedIndexChanged += new System.EventHandler(this.cblLesson_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbNotify);
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.lbProQues);
            this.groupBox2.Controls.Add(this.btnSound);
            this.groupBox2.Controls.Add(this.tbQuestion);
            this.groupBox2.Controls.Add(this.tbAnswer);
            this.groupBox2.Location = new System.Drawing.Point(359, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 276);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Test";
            // 
            // lbNotify
            // 
            this.lbNotify.AutoSize = true;
            this.lbNotify.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotify.Location = new System.Drawing.Point(138, 224);
            this.lbNotify.Name = "lbNotify";
            this.lbNotify.Size = new System.Drawing.Size(79, 29);
            this.lbNotify.TabIndex = 6;
            this.lbNotify.Text = "label1";
            this.lbNotify.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(238, 155);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(82, 35);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lbProQues
            // 
            this.lbProQues.AutoSize = true;
            this.lbProQues.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbProQues.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProQues.Location = new System.Drawing.Point(23, 111);
            this.lbProQues.Name = "lbProQues";
            this.lbProQues.Size = new System.Drawing.Size(55, 22);
            this.lbProQues.TabIndex = 4;
            this.lbProQues.Text = "label1";
            this.lbProQues.Visible = false;
            // 
            // btnSound
            // 
            this.btnSound.Image = global::StudyEnglish.Properties.Resources.wave_sound;
            this.btnSound.Location = new System.Drawing.Point(254, 69);
            this.btnSound.Name = "btnSound";
            this.btnSound.Size = new System.Drawing.Size(40, 28);
            this.btnSound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSound.TabIndex = 3;
            this.btnSound.TabStop = false;
            this.btnSound.Click += new System.EventHandler(this.btnSound_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbVi);
            this.groupBox3.Controls.Add(this.rbEn);
            this.groupBox3.Location = new System.Drawing.Point(359, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(364, 102);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Choose Test";
            // 
            // rbVi
            // 
            this.rbVi.AutoSize = true;
            this.rbVi.Checked = true;
            this.rbVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVi.Location = new System.Drawing.Point(23, 46);
            this.rbVi.Name = "rbVi";
            this.rbVi.Size = new System.Drawing.Size(118, 24);
            this.rbVi.TabIndex = 1;
            this.rbVi.TabStop = true;
            this.rbVi.Text = "Vietnamese";
            this.rbVi.UseVisualStyleBackColor = true;
            this.rbVi.CheckedChanged += new System.EventHandler(this.rbVi_CheckedChanged);
            // 
            // rbEn
            // 
            this.rbEn.AutoSize = true;
            this.rbEn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEn.Location = new System.Drawing.Point(235, 46);
            this.rbEn.Name = "rbEn";
            this.rbEn.Size = new System.Drawing.Size(85, 24);
            this.rbEn.TabIndex = 0;
            this.rbEn.TabStop = true;
            this.rbEn.Text = "English";
            this.rbEn.UseVisualStyleBackColor = true;
            this.rbEn.CheckedChanged += new System.EventHandler(this.rbEn_CheckedChanged);
            // 
            // lbWord
            // 
            this.lbWord.AutoSize = true;
            this.lbWord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWord.Location = new System.Drawing.Point(3, 0);
            this.lbWord.Margin = new System.Windows.Forms.Padding(3, 0, 20, 10);
            this.lbWord.Name = "lbWord";
            this.lbWord.Size = new System.Drawing.Size(2, 22);
            this.lbWord.TabIndex = 5;
            // 
            // lbProView
            // 
            this.lbProView.AutoSize = true;
            this.lbProView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbProView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProView.Location = new System.Drawing.Point(6, 104);
            this.lbProView.Name = "lbProView";
            this.lbProView.Size = new System.Drawing.Size(2, 22);
            this.lbProView.TabIndex = 6;
            this.lbProView.Tag = "";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbType.Location = new System.Drawing.Point(28, 0);
            this.lbType.Name = "lbType";
            this.lbType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbType.Size = new System.Drawing.Size(2, 22);
            this.lbType.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lbWord);
            this.flowLayoutPanel1.Controls.Add(this.lbType);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 42);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(333, 40);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "         ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbRemain);
            this.groupBox4.Controls.Add(this.LbIncorrect);
            this.groupBox4.Controls.Add(this.lbCorrect);
            this.groupBox4.Controls.Add(this.lbSum);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.lbVi);
            this.groupBox4.Controls.Add(this.flowLayoutPanel1);
            this.groupBox4.Controls.Add(this.lbProView);
            this.groupBox4.Location = new System.Drawing.Point(753, 87);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(345, 380);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "View Word";
            // 
            // lbRemain
            // 
            this.lbRemain.AutoSize = true;
            this.lbRemain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbRemain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRemain.Location = new System.Drawing.Point(134, 326);
            this.lbRemain.Name = "lbRemain";
            this.lbRemain.Size = new System.Drawing.Size(21, 22);
            this.lbRemain.TabIndex = 17;
            this.lbRemain.Tag = "";
            this.lbRemain.Text = "0";
            // 
            // LbIncorrect
            // 
            this.LbIncorrect.AutoSize = true;
            this.LbIncorrect.BackColor = System.Drawing.Color.Red;
            this.LbIncorrect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LbIncorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbIncorrect.Location = new System.Drawing.Point(134, 290);
            this.LbIncorrect.Name = "LbIncorrect";
            this.LbIncorrect.Size = new System.Drawing.Size(21, 22);
            this.LbIncorrect.TabIndex = 16;
            this.LbIncorrect.Tag = "";
            this.LbIncorrect.Text = "0";
            // 
            // lbCorrect
            // 
            this.lbCorrect.AutoSize = true;
            this.lbCorrect.BackColor = System.Drawing.Color.Chartreuse;
            this.lbCorrect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCorrect.Location = new System.Drawing.Point(134, 249);
            this.lbCorrect.Name = "lbCorrect";
            this.lbCorrect.Size = new System.Drawing.Size(21, 22);
            this.lbCorrect.TabIndex = 15;
            this.lbCorrect.Tag = "";
            this.lbCorrect.Text = "0";
            // 
            // lbSum
            // 
            this.lbSum.AutoSize = true;
            this.lbSum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSum.Location = new System.Drawing.Point(134, 215);
            this.lbSum.Name = "lbSum";
            this.lbSum.Size = new System.Drawing.Size(21, 22);
            this.lbSum.TabIndex = 13;
            this.lbSum.Tag = "";
            this.lbSum.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Số từ còn lại:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Số từ sai:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Số từ đúng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tổng số từ:";
            // 
            // lbVi
            // 
            this.lbVi.AutoSize = true;
            this.lbVi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVi.Location = new System.Drawing.Point(9, 153);
            this.lbVi.Name = "lbVi";
            this.lbVi.Size = new System.Drawing.Size(2, 22);
            this.lbVi.TabIndex = 8;
            this.lbVi.Tag = "";
            // 
            // TestWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 526);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TestWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestWord";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewWord_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSound)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbQuestion;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox cblLesson;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbVi;
        private System.Windows.Forms.RadioButton rbEn;
        private System.Windows.Forms.PictureBox btnSound;
        private System.Windows.Forms.Label lbProQues;
        private System.Windows.Forms.Label lbProView;
        private System.Windows.Forms.Label lbWord;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbVi;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LbIncorrect;
        private System.Windows.Forms.Label lbCorrect;
        private System.Windows.Forms.Label lbSum;
        private System.Windows.Forms.Label lbRemain;
        private System.Windows.Forms.Label lbNotify;
        private System.Windows.Forms.CheckBox cbAll;
    }
}