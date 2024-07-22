namespace StudyEnglish
{
    partial class AddWord
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvWord = new System.Windows.Forms.DataGridView();
            this.btnAddWord = new System.Windows.Forms.Button();
            this.WordEn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WordType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WordPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WordVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWord)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Word";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvWord
            // 
            this.dgvWord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvWord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WordEn,
            this.WordType,
            this.WordPro,
            this.WordVi,
            this.Status});
            this.dgvWord.Location = new System.Drawing.Point(132, 133);
            this.dgvWord.MultiSelect = false;
            this.dgvWord.Name = "dgvWord";
            this.dgvWord.RowHeadersWidth = 51;
            this.dgvWord.RowTemplate.Height = 24;
            this.dgvWord.Size = new System.Drawing.Size(717, 286);
            this.dgvWord.TabIndex = 2;
            this.dgvWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // btnAddWord
            // 
            this.btnAddWord.Location = new System.Drawing.Point(12, 197);
            this.btnAddWord.Name = "btnAddWord";
            this.btnAddWord.Size = new System.Drawing.Size(104, 49);
            this.btnAddWord.TabIndex = 3;
            this.btnAddWord.Text = "Add Word";
            this.btnAddWord.UseVisualStyleBackColor = true;
            this.btnAddWord.Click += new System.EventHandler(this.btnAddWord_Click);
            // 
            // WordEn
            // 
            this.WordEn.Frozen = true;
            this.WordEn.HeaderText = "English";
            this.WordEn.MinimumWidth = 6;
            this.WordEn.Name = "WordEn";
            this.WordEn.Width = 80;
            // 
            // WordType
            // 
            this.WordType.Frozen = true;
            this.WordType.HeaderText = "Type";
            this.WordType.MinimumWidth = 6;
            this.WordType.Name = "WordType";
            this.WordType.Width = 68;
            // 
            // WordPro
            // 
            this.WordPro.Frozen = true;
            this.WordPro.HeaderText = "Pronunciation";
            this.WordPro.MinimumWidth = 6;
            this.WordPro.Name = "WordPro";
            this.WordPro.Width = 117;
            // 
            // WordVi
            // 
            this.WordVi.Frozen = true;
            this.WordVi.HeaderText = "Vietnamese";
            this.WordVi.MinimumWidth = 6;
            this.WordVi.Name = "WordVi";
            this.WordVi.Width = 108;
            // 
            // Status
            // 
            this.Status.Frozen = true;
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 73;
            // 
            // AddWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(861, 432);
            this.Controls.Add(this.btnAddWord);
            this.Controls.Add(this.dgvWord);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddWord";
            ((System.ComponentModel.ISupportInitialize)(this.dgvWord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvWord;
        private System.Windows.Forms.Button btnAddWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn WordEn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WordType;
        private System.Windows.Forms.DataGridViewTextBoxColumn WordPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn WordVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}