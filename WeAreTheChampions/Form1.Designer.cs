namespace WeAreTheChampions
{
    partial class Form1
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
            if (disposing)
            {
                db.Dispose();
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.teamMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.colorsMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.playersMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvMatches = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewMatch = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teamMenuStrip,
            this.colorsMenuStrip,
            this.playersMenuStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(860, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // teamMenuStrip
            // 
            this.teamMenuStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamMenuStrip.Name = "teamMenuStrip";
            this.teamMenuStrip.Size = new System.Drawing.Size(74, 24);
            this.teamMenuStrip.Text = "Teams";
            this.teamMenuStrip.Click += new System.EventHandler(this.teamMenuStrip_Click);
            // 
            // colorsMenuStrip
            // 
            this.colorsMenuStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorsMenuStrip.Name = "colorsMenuStrip";
            this.colorsMenuStrip.Size = new System.Drawing.Size(72, 24);
            this.colorsMenuStrip.Text = "Colors";
            this.colorsMenuStrip.Click += new System.EventHandler(this.colorsMenuStrip_Click);
            // 
            // playersMenuStrip
            // 
            this.playersMenuStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playersMenuStrip.Name = "playersMenuStrip";
            this.playersMenuStrip.Size = new System.Drawing.Size(79, 24);
            this.playersMenuStrip.Text = "Players";
            this.playersMenuStrip.Click += new System.EventHandler(this.playersMenuStrip_Click);
            // 
            // dgvMatches
            // 
            this.dgvMatches.AllowUserToAddRows = false;
            this.dgvMatches.AllowUserToDeleteRows = false;
            this.dgvMatches.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMatches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMatches.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvMatches.Location = new System.Drawing.Point(12, 84);
            this.dgvMatches.Name = "dgvMatches";
            this.dgvMatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatches.Size = new System.Drawing.Size(836, 397);
            this.dgvMatches.TabIndex = 1;
            this.dgvMatches.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatches_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Matches";
            // 
            // btnNewMatch
            // 
            this.btnNewMatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewMatch.Location = new System.Drawing.Point(621, 37);
            this.btnNewMatch.Name = "btnNewMatch";
            this.btnNewMatch.Size = new System.Drawing.Size(227, 41);
            this.btnNewMatch.TabIndex = 3;
            this.btnNewMatch.Text = "+ New Match";
            this.btnNewMatch.UseVisualStyleBackColor = true;
            this.btnNewMatch.Click += new System.EventHandler(this.btnNewMatch_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(534, 487);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(154, 31);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(694, 487);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(154, 31);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Id";
            this.Column7.HeaderText = "MatchId";
            this.Column7.Name = "Column7";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "HomeTeam";
            this.Column1.HeaderText = "Home Team";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "GuestTeam";
            this.Column2.HeaderText = "Guest Team";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Date";
            this.Column3.HeaderText = "Date";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Hour";
            this.Column4.HeaderText = "Hour";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Score";
            this.Column5.HeaderText = "Score";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Result";
            this.Column6.HeaderText = "Result";
            this.Column6.Name = "Column6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 522);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNewMatch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMatches);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Whe Are The Champions 1.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem teamMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem colorsMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem playersMenuStrip;
        private System.Windows.Forms.DataGridView dgvMatches;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewMatch;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}

