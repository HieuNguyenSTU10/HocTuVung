namespace StudyEnglish
{
    partial class Home
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
            this.btn_Word = new System.Windows.Forms.Button();
            this.btn_Test = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAddLesson = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAddWord = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Word
            // 
            this.btn_Word.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Word.Location = new System.Drawing.Point(103, 66);
            this.btn_Word.Name = "btn_Word";
            this.btn_Word.Size = new System.Drawing.Size(169, 49);
            this.btn_Word.TabIndex = 0;
            this.btn_Word.Text = "View Word";
            this.btn_Word.UseVisualStyleBackColor = true;
            this.btn_Word.Click += new System.EventHandler(this.btn_Word_Click);
            // 
            // btn_Test
            // 
            this.btn_Test.Location = new System.Drawing.Point(103, 142);
            this.btn_Test.Name = "btn_Test";
            this.btn_Test.Size = new System.Drawing.Size(169, 49);
            this.btn_Test.TabIndex = 1;
            this.btn_Test.Text = "Test Word";
            this.btn_Test.UseVisualStyleBackColor = true;
            this.btn_Test.Click += new System.EventHandler(this.btn_Test_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "Test Sound";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnAdd});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(388, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnAdd
            // 
            this.mnAdd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnAddLesson,
            this.mnAddWord});
            this.mnAdd.Name = "mnAdd";
            this.mnAdd.Size = new System.Drawing.Size(51, 24);
            this.mnAdd.Text = "Add";
            // 
            // mnAddLesson
            // 
            this.mnAddLesson.Name = "mnAddLesson";
            this.mnAddLesson.Size = new System.Drawing.Size(224, 26);
            this.mnAddLesson.Text = "Add Lesson";
            // 
            // mnAddWord
            // 
            this.mnAddWord.Name = "mnAddWord";
            this.mnAddWord.Size = new System.Drawing.Size(224, 26);
            this.mnAddWord.Text = "Add Word";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 302);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Test);
            this.Controls.Add(this.btn_Word);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudyE";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Word;
        private System.Windows.Forms.Button btn_Test;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnAdd;
        private System.Windows.Forms.ToolStripMenuItem mnAddLesson;
        private System.Windows.Forms.ToolStripMenuItem mnAddWord;
    }
}

