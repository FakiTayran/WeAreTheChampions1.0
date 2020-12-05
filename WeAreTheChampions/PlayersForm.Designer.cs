namespace WeAreTheChampions
{
    partial class PlayersForm
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
            this.lstPlayers = new System.Windows.Forms.ListBox();
            this.cboTeams = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbFilter = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstPlayers
            // 
            this.lstPlayers.DisplayMember = "PlayerName";
            this.lstPlayers.FormattingEnabled = true;
            this.lstPlayers.ItemHeight = 20;
            this.lstPlayers.Location = new System.Drawing.Point(14, 34);
            this.lstPlayers.Margin = new System.Windows.Forms.Padding(5);
            this.lstPlayers.Name = "lstPlayers";
            this.lstPlayers.Size = new System.Drawing.Size(330, 204);
            this.lstPlayers.TabIndex = 0;
            this.lstPlayers.SelectedIndexChanged += new System.EventHandler(this.lstPlayers_SelectedIndexChanged);
            // 
            // cboTeams
            // 
            this.cboTeams.DisplayMember = "TeamName";
            this.cboTeams.FormattingEnabled = true;
            this.cboTeams.Location = new System.Drawing.Point(481, 179);
            this.cboTeams.Margin = new System.Windows.Forms.Padding(5);
            this.cboTeams.Name = "cboTeams";
            this.cboTeams.Size = new System.Drawing.Size(240, 28);
            this.cboTeams.TabIndex = 1;
            this.cboTeams.ValueMember = "Id";
            this.cboTeams.SelectedIndexChanged += new System.EventHandler(this.cboTeams_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 182);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Team Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Players Name";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(481, 42);
            this.txtPlayerName.Margin = new System.Windows.Forms.Padding(5);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(240, 26);
            this.txtPlayerName.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(481, 127);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(240, 32);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(636, 90);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 31);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(636, 89);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 32);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(544, 89);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(86, 32);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "DELETE";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(481, 90);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(57, 32);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbFilter
            // 
            this.cbFilter.AutoSize = true;
            this.cbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilter.Location = new System.Drawing.Point(160, 13);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(131, 17);
            this.cbFilter.TabIndex = 11;
            this.cbFilter.Text = "Open Team Filter Mod";
            this.cbFilter.UseVisualStyleBackColor = true;
            this.cbFilter.CheckedChanged += new System.EventHandler(this.cbFilter_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Available Players";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(380, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "(!)Players with the same name can be added and their id will be different";
            // 
            // PlayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 260);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTeams);
            this.Controls.Add(this.lstPlayers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(766, 299);
            this.MinimumSize = new System.Drawing.Size(766, 299);
            this.Name = "PlayersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PlayersForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPlayers;
        private System.Windows.Forms.ComboBox cboTeams;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox cbFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}