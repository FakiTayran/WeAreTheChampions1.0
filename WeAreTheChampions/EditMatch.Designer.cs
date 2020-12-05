namespace WeAreTheChampions
{
    partial class EditMatch
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
            this.cbDraw = new System.Windows.Forms.CheckBox();
            this.cbTeam2Won = new System.Windows.Forms.CheckBox();
            this.cbTeam1Won = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.nudScoreGuestTeam = new System.Windows.Forms.NumericUpDown();
            this.nudScoreHomeTeam = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtMatchTime = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cboGuestTeam = new System.Windows.Forms.ComboBox();
            this.cboHomeTeam = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudScoreGuestTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScoreHomeTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDraw
            // 
            this.cbDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDraw.Location = new System.Drawing.Point(346, 251);
            this.cbDraw.Name = "cbDraw";
            this.cbDraw.Size = new System.Drawing.Size(170, 24);
            this.cbDraw.TabIndex = 18;
            this.cbDraw.Text = "Draw";
            this.cbDraw.UseVisualStyleBackColor = true;
            this.cbDraw.CheckedChanged += new System.EventHandler(this.cbDraw_CheckedChanged);
            // 
            // cbTeam2Won
            // 
            this.cbTeam2Won.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTeam2Won.Location = new System.Drawing.Point(568, 204);
            this.cbTeam2Won.Name = "cbTeam2Won";
            this.cbTeam2Won.Size = new System.Drawing.Size(170, 24);
            this.cbTeam2Won.TabIndex = 19;
            this.cbTeam2Won.Text = "Guest Team Won";
            this.cbTeam2Won.UseVisualStyleBackColor = true;
            this.cbTeam2Won.CheckedChanged += new System.EventHandler(this.cbTeam2Won_CheckedChanged);
            // 
            // cbTeam1Won
            // 
            this.cbTeam1Won.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTeam1Won.Location = new System.Drawing.Point(35, 204);
            this.cbTeam1Won.Name = "cbTeam1Won";
            this.cbTeam1Won.Size = new System.Drawing.Size(175, 24);
            this.cbTeam1Won.TabIndex = 20;
            this.cbTeam1Won.Text = "Home Team Won";
            this.cbTeam1Won.UseVisualStyleBackColor = true;
            this.cbTeam1Won.CheckedChanged += new System.EventHandler(this.cbTeam1Won_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(275, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(222, 54);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // nudScoreGuestTeam
            // 
            this.nudScoreGuestTeam.Location = new System.Drawing.Point(594, 169);
            this.nudScoreGuestTeam.Name = "nudScoreGuestTeam";
            this.nudScoreGuestTeam.Size = new System.Drawing.Size(112, 20);
            this.nudScoreGuestTeam.TabIndex = 15;
            this.nudScoreGuestTeam.ValueChanged += new System.EventHandler(this.nudScoreGuestTeam_ValueChanged);
            // 
            // nudScoreHomeTeam
            // 
            this.nudScoreHomeTeam.Location = new System.Drawing.Point(70, 169);
            this.nudScoreHomeTeam.Name = "nudScoreHomeTeam";
            this.nudScoreHomeTeam.Size = new System.Drawing.Size(112, 20);
            this.nudScoreHomeTeam.TabIndex = 16;
            this.nudScoreHomeTeam.ValueChanged += new System.EventHandler(this.nudScoreHomeTeam_ValueChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(503, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Guest Team";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Home Team";
            // 
            // dtMatchTime
            // 
            this.dtMatchTime.Location = new System.Drawing.Point(275, 204);
            this.dtMatchTime.Name = "dtMatchTime";
            this.dtMatchTime.Size = new System.Drawing.Size(222, 20);
            this.dtMatchTime.TabIndex = 12;
            this.dtMatchTime.ValueChanged += new System.EventHandler(this.dtMatchTime_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WeAreTheChampions.Properties.Resources._48364817_symbol_competition_vs_vector_illustration_;
            this.pictureBox1.Location = new System.Drawing.Point(275, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // cboGuestTeam
            // 
            this.cboGuestTeam.DisplayMember = "TeamName";
            this.cboGuestTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGuestTeam.FormattingEnabled = true;
            this.cboGuestTeam.Location = new System.Drawing.Point(503, 128);
            this.cboGuestTeam.Name = "cboGuestTeam";
            this.cboGuestTeam.Size = new System.Drawing.Size(281, 21);
            this.cboGuestTeam.TabIndex = 10;
            this.cboGuestTeam.ValueMember = "Id";
            this.cboGuestTeam.SelectedIndexChanged += new System.EventHandler(this.cboGuestTeam_SelectedIndexChanged);
            // 
            // cboHomeTeam
            // 
            this.cboHomeTeam.DisplayMember = "TeamName";
            this.cboHomeTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHomeTeam.FormattingEnabled = true;
            this.cboHomeTeam.Location = new System.Drawing.Point(8, 128);
            this.cboHomeTeam.Name = "cboHomeTeam";
            this.cboHomeTeam.Size = new System.Drawing.Size(261, 21);
            this.cboHomeTeam.TabIndex = 9;
            this.cboHomeTeam.ValueMember = "Id";
            this.cboHomeTeam.SelectedIndexChanged += new System.EventHandler(this.cboHomeTeam_SelectedIndexChanged);
            // 
            // EditMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 297);
            this.Controls.Add(this.cbDraw);
            this.Controls.Add(this.cbTeam2Won);
            this.Controls.Add(this.cbTeam1Won);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.nudScoreGuestTeam);
            this.Controls.Add(this.nudScoreHomeTeam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtMatchTime);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cboGuestTeam);
            this.Controls.Add(this.cboHomeTeam);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 336);
            this.MinimumSize = new System.Drawing.Size(816, 336);
            this.Name = "EditMatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditMatch";
            ((System.ComponentModel.ISupportInitialize)(this.nudScoreGuestTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScoreHomeTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbDraw;
        private System.Windows.Forms.CheckBox cbTeam2Won;
        private System.Windows.Forms.CheckBox cbTeam1Won;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown nudScoreGuestTeam;
        private System.Windows.Forms.NumericUpDown nudScoreHomeTeam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtMatchTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboGuestTeam;
        private System.Windows.Forms.ComboBox cboHomeTeam;
    }
}