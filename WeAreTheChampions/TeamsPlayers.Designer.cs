namespace WeAreTheChampions
{
    partial class frmTeamsPlayers
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
            this.lstTeamsPlayers = new System.Windows.Forms.ListBox();
            this.lstIdlePlayers = new System.Windows.Forms.ListBox();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstTeamsPlayers
            // 
            this.lstTeamsPlayers.DisplayMember = "PlayerName";
            this.lstTeamsPlayers.FormattingEnabled = true;
            this.lstTeamsPlayers.Location = new System.Drawing.Point(12, 55);
            this.lstTeamsPlayers.Name = "lstTeamsPlayers";
            this.lstTeamsPlayers.Size = new System.Drawing.Size(421, 147);
            this.lstTeamsPlayers.TabIndex = 0;
            this.lstTeamsPlayers.SelectedIndexChanged += new System.EventHandler(this.lstTeamsPlayers_SelectedIndexChanged);
            // 
            // lstIdlePlayers
            // 
            this.lstIdlePlayers.DisplayMember = "PlayerName";
            this.lstIdlePlayers.FormattingEnabled = true;
            this.lstIdlePlayers.Location = new System.Drawing.Point(15, 289);
            this.lstIdlePlayers.Name = "lstIdlePlayers";
            this.lstIdlePlayers.Size = new System.Drawing.Size(421, 186);
            this.lstIdlePlayers.TabIndex = 1;
            this.lstIdlePlayers.SelectedIndexChanged += new System.EventHandler(this.lstIdlePlayers_SelectedIndexChanged);
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.Location = new System.Drawing.Point(12, 208);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(421, 57);
            this.btnTransfer.TabIndex = 2;
            this.btnTransfer.Text = "↓↑";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Team\'s Players";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Idle Players";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 478);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(423, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "(!) To see and transfer players from other teams, edit from the players screen.\r\n" +
    "";
            // 
            // frmTeamsPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 500);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.lstIdlePlayers);
            this.Controls.Add(this.lstTeamsPlayers);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(461, 539);
            this.MinimumSize = new System.Drawing.Size(461, 539);
            this.Name = "frmTeamsPlayers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeamsPlayers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTeamsPlayers;
        private System.Windows.Forms.ListBox lstIdlePlayers;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}