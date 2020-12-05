namespace WeAreTheChampions
{
    partial class TeamsForm
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
            this.lstTeams = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddNewTeams = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cboColors = new System.Windows.Forms.ComboBox();
            this.btnPlayers = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddColorToTeam = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTeamColors = new System.Windows.Forms.ComboBox();
            this.btnRemoveFromTeam = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lstTeams
            // 
            this.lstTeams.FormattingEnabled = true;
            this.lstTeams.Location = new System.Drawing.Point(9, 54);
            this.lstTeams.Name = "lstTeams";
            this.lstTeams.Size = new System.Drawing.Size(204, 186);
            this.lstTeams.TabIndex = 0;
            this.lstTeams.SelectedIndexChanged += new System.EventHandler(this.lstTeams_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "TEAMS";
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(318, 54);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(136, 20);
            this.txtTeamName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "TeamName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(223, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "COLOR";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(223, 204);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 25);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddNewTeams
            // 
            this.btnAddNewTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewTeams.Location = new System.Drawing.Point(157, 6);
            this.btnAddNewTeams.Name = "btnAddNewTeams";
            this.btnAddNewTeams.Size = new System.Drawing.Size(25, 42);
            this.btnAddNewTeams.TabIndex = 11;
            this.btnAddNewTeams.Text = "+";
            this.btnAddNewTeams.UseVisualStyleBackColor = true;
            this.btnAddNewTeams.Click += new System.EventHandler(this.btnAddNewTeams_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(331, 204);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(123, 25);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(331, 204);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 25);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(188, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(25, 42);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "X";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cboColors
            // 
            this.cboColors.DisplayMember = "ColorName";
            this.cboColors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColors.FormattingEnabled = true;
            this.cboColors.Location = new System.Drawing.Point(318, 97);
            this.cboColors.Name = "cboColors";
            this.cboColors.Size = new System.Drawing.Size(136, 21);
            this.cboColors.TabIndex = 15;
            this.cboColors.ValueMember = "Red,Green,Blue";
            this.cboColors.SelectedIndexChanged += new System.EventHandler(this.cboColors_SelectedIndexChanged);
            // 
            // btnPlayers
            // 
            this.btnPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayers.Location = new System.Drawing.Point(223, 156);
            this.btnPlayers.Name = "btnPlayers";
            this.btnPlayers.Size = new System.Drawing.Size(231, 42);
            this.btnPlayers.TabIndex = 16;
            this.btnPlayers.Text = "Players";
            this.btnPlayers.UseVisualStyleBackColor = true;
            this.btnPlayers.Click += new System.EventHandler(this.btnPlayers_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(9, 282);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 68);
            this.panel1.TabIndex = 17;
            // 
            // btnAddColorToTeam
            // 
            this.btnAddColorToTeam.Location = new System.Drawing.Point(318, 124);
            this.btnAddColorToTeam.Name = "btnAddColorToTeam";
            this.btnAddColorToTeam.Size = new System.Drawing.Size(136, 23);
            this.btnAddColorToTeam.TabIndex = 18;
            this.btnAddColorToTeam.Text = "Add this color to team";
            this.btnAddColorToTeam.UseVisualStyleBackColor = true;
            this.btnAddColorToTeam.Visible = false;
            this.btnAddColorToTeam.Click += new System.EventHandler(this.btnAddColorToTeam_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Color from this team";
            // 
            // cboTeamColors
            // 
            this.cboTeamColors.DisplayMember = "ColorName";
            this.cboTeamColors.FormattingEnabled = true;
            this.cboTeamColors.Location = new System.Drawing.Point(153, 247);
            this.cboTeamColors.Name = "cboTeamColors";
            this.cboTeamColors.Size = new System.Drawing.Size(121, 21);
            this.cboTeamColors.TabIndex = 20;
            this.cboTeamColors.Visible = false;
            // 
            // btnRemoveFromTeam
            // 
            this.btnRemoveFromTeam.Location = new System.Drawing.Point(280, 245);
            this.btnRemoveFromTeam.Name = "btnRemoveFromTeam";
            this.btnRemoveFromTeam.Size = new System.Drawing.Size(174, 23);
            this.btnRemoveFromTeam.TabIndex = 21;
            this.btnRemoveFromTeam.Text = "REMOVE FROM TEAM";
            this.btnRemoveFromTeam.UseVisualStyleBackColor = true;
            this.btnRemoveFromTeam.Visible = false;
            this.btnRemoveFromTeam.Click += new System.EventHandler(this.btnRemoveFromTeam_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(342, 6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(112, 17);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "HideClosedTeams";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // TeamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(466, 357);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnRemoveFromTeam);
            this.Controls.Add(this.cboTeamColors);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddColorToTeam);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPlayers);
            this.Controls.Add(this.cboColors);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddNewTeams);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTeamName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstTeams);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(482, 396);
            this.MinimumSize = new System.Drawing.Size(481, 347);
            this.Name = "TeamsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Teams";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTeams;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddNewTeams;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cboColors;
        private System.Windows.Forms.Button btnPlayers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddColorToTeam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTeamColors;
        private System.Windows.Forms.Button btnRemoveFromTeam;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}