namespace WeAreTheChampions
{
    partial class NewMatchAddForm
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
            this.cboHomeTeam = new System.Windows.Forms.ComboBox();
            this.cboGuestTeam = new System.Windows.Forms.ComboBox();
            this.dtMatchTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudScoreHomeTeam = new System.Windows.Forms.NumericUpDown();
            this.nudScoreGuestTeam = new System.Windows.Forms.NumericUpDown();
            this.btnCreateMatch = new System.Windows.Forms.Button();
            this.cbTeam1Won = new System.Windows.Forms.CheckBox();
            this.cbTeam2Won = new System.Windows.Forms.CheckBox();
            this.cbDraw = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudScoreHomeTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScoreGuestTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboHomeTeam
            // 
            this.cboHomeTeam.DisplayMember = "TeamName";
            this.cboHomeTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHomeTeam.FormattingEnabled = true;
            this.cboHomeTeam.Location = new System.Drawing.Point(10, 128);
            this.cboHomeTeam.Name = "cboHomeTeam";
            this.cboHomeTeam.Size = new System.Drawing.Size(261, 21);
            this.cboHomeTeam.TabIndex = 0;
            this.cboHomeTeam.SelectedIndexChanged += new System.EventHandler(this.cboHomeTeam_SelectedIndexChanged);
            // 
            // cboGuestTeam
            // 
            this.cboGuestTeam.DisplayMember = "TeamName";
            this.cboGuestTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGuestTeam.FormattingEnabled = true;
            this.cboGuestTeam.Location = new System.Drawing.Point(505, 128);
            this.cboGuestTeam.Name = "cboGuestTeam";
            this.cboGuestTeam.Size = new System.Drawing.Size(281, 21);
            this.cboGuestTeam.TabIndex = 1;
            // 
            // dtMatchTime
            // 
            this.dtMatchTime.Location = new System.Drawing.Point(277, 204);
            this.dtMatchTime.Name = "dtMatchTime";
            this.dtMatchTime.Size = new System.Drawing.Size(222, 20);
            this.dtMatchTime.TabIndex = 3;
            this.dtMatchTime.ValueChanged += new System.EventHandler(this.dtMatchTime_ValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Home Team";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(505, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Guest Team";
            // 
            // nudScoreHomeTeam
            // 
            this.nudScoreHomeTeam.Location = new System.Drawing.Point(72, 169);
            this.nudScoreHomeTeam.Name = "nudScoreHomeTeam";
            this.nudScoreHomeTeam.Size = new System.Drawing.Size(112, 20);
            this.nudScoreHomeTeam.TabIndex = 5;
            this.nudScoreHomeTeam.ValueChanged += new System.EventHandler(this.nudScoreHomeTeam_ValueChanged);
            // 
            // nudScoreGuestTeam
            // 
            this.nudScoreGuestTeam.Location = new System.Drawing.Point(596, 169);
            this.nudScoreGuestTeam.Name = "nudScoreGuestTeam";
            this.nudScoreGuestTeam.Size = new System.Drawing.Size(112, 20);
            this.nudScoreGuestTeam.TabIndex = 5;
            this.nudScoreGuestTeam.ValueChanged += new System.EventHandler(this.nudScoreGuestTeam_ValueChanged);
            // 
            // btnCreateMatch
            // 
            this.btnCreateMatch.AutoSize = true;
            this.btnCreateMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateMatch.Location = new System.Drawing.Point(277, 12);
            this.btnCreateMatch.Name = "btnCreateMatch";
            this.btnCreateMatch.Size = new System.Drawing.Size(222, 54);
            this.btnCreateMatch.TabIndex = 7;
            this.btnCreateMatch.Text = "Create New Match";
            this.btnCreateMatch.UseVisualStyleBackColor = true;
            this.btnCreateMatch.Click += new System.EventHandler(this.btnCreateMatch_Click);
            // 
            // cbTeam1Won
            // 
            this.cbTeam1Won.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTeam1Won.Location = new System.Drawing.Point(37, 204);
            this.cbTeam1Won.Name = "cbTeam1Won";
            this.cbTeam1Won.Size = new System.Drawing.Size(175, 24);
            this.cbTeam1Won.TabIndex = 8;
            this.cbTeam1Won.Text = "Home Team Won";
            this.cbTeam1Won.UseVisualStyleBackColor = true;
            this.cbTeam1Won.CheckedChanged += new System.EventHandler(this.cbTeam1Won_CheckedChanged);
            // 
            // cbTeam2Won
            // 
            this.cbTeam2Won.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTeam2Won.Location = new System.Drawing.Point(570, 204);
            this.cbTeam2Won.Name = "cbTeam2Won";
            this.cbTeam2Won.Size = new System.Drawing.Size(170, 24);
            this.cbTeam2Won.TabIndex = 8;
            this.cbTeam2Won.Text = "Guest Team Won";
            this.cbTeam2Won.UseVisualStyleBackColor = true;
            this.cbTeam2Won.CheckedChanged += new System.EventHandler(this.cbTeam2Won_CheckedChanged);
            // 
            // cbDraw
            // 
            this.cbDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDraw.Location = new System.Drawing.Point(348, 251);
            this.cbDraw.Name = "cbDraw";
            this.cbDraw.Size = new System.Drawing.Size(170, 24);
            this.cbDraw.TabIndex = 8;
            this.cbDraw.Text = "Draw";
            this.cbDraw.UseVisualStyleBackColor = true;
            this.cbDraw.CheckedChanged += new System.EventHandler(this.cbDraw_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WeAreTheChampions.Properties.Resources._48364817_symbol_competition_vs_vector_illustration_;
            this.pictureBox1.Location = new System.Drawing.Point(277, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // NewMatchAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 287);
            this.Controls.Add(this.cbDraw);
            this.Controls.Add(this.cbTeam2Won);
            this.Controls.Add(this.cbTeam1Won);
            this.Controls.Add(this.btnCreateMatch);
            this.Controls.Add(this.nudScoreGuestTeam);
            this.Controls.Add(this.nudScoreHomeTeam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtMatchTime);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cboGuestTeam);
            this.Controls.Add(this.cboHomeTeam);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 326);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 326);
            this.Name = "NewMatchAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NewMatchAddForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudScoreHomeTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScoreGuestTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboHomeTeam;
        private System.Windows.Forms.ComboBox cboGuestTeam;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtMatchTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudScoreHomeTeam;
        private System.Windows.Forms.NumericUpDown nudScoreGuestTeam;
        private System.Windows.Forms.Button btnCreateMatch;
        private System.Windows.Forms.CheckBox cbTeam1Won;
        private System.Windows.Forms.CheckBox cbTeam2Won;
        private System.Windows.Forms.CheckBox cbDraw;
    }
}