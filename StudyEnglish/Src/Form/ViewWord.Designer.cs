namespace StudyEnglish
{
    partial class ViewWord
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstLesson = new System.Windows.Forms.ListBox();
            this.sqlCMD = new System.Data.SqlClient.SqlCommand();
            this.sqlCnn = new System.Data.SqlClient.SqlConnection();
            this.dgvWord = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWord)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstLesson);
            this.groupBox1.Location = new System.Drawing.Point(12, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 368);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lesson";
            // 
            // lstLesson
            // 
            this.lstLesson.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLesson.FormattingEnabled = true;
            this.lstLesson.ItemHeight = 20;
            this.lstLesson.Location = new System.Drawing.Point(6, 23);
            this.lstLesson.Name = "lstLesson";
            this.lstLesson.Size = new System.Drawing.Size(143, 344);
            this.lstLesson.TabIndex = 0;
            this.lstLesson.SelectedIndexChanged += new System.EventHandler(this.LstLesson_SelectedIndexChanged);
            // 
            // sqlCnn
            // 
            this.sqlCnn.ConnectionString = "Data Source=HieuNguyen\\SQLEXPRESS;Initial Catalog=Word;Integrated Security=True;E" +
    "ncrypt=False";
            this.sqlCnn.FireInfoMessageEventOnUserErrors = false;
            // 
            // dgvWord
            // 
            this.dgvWord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWord.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvWord.Location = new System.Drawing.Point(221, 72);
            this.dgvWord.MultiSelect = false;
            this.dgvWord.Name = "dgvWord";
            this.dgvWord.ReadOnly = true;
            this.dgvWord.RowHeadersWidth = 51;
            this.dgvWord.RowTemplate.Height = 24;
            this.dgvWord.ShowEditingIcon = false;
            this.dgvWord.Size = new System.Drawing.Size(773, 481);
            this.dgvWord.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(214, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(180, 22);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // ViewWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 590);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvWord);
            this.Controls.Add(this.groupBox1);
            this.Name = "ViewWord";
            this.Text = "ViewWord";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewWord_FormClosed);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstLesson;
        private System.Data.SqlClient.SqlCommand sqlCMD;
        private System.Data.SqlClient.SqlConnection sqlCnn;
        private System.Windows.Forms.DataGridView dgvWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
    }
}