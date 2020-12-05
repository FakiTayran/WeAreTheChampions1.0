namespace WeAreTheChampions
{
    partial class ColorsForm
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
            this.lstAvailableColors = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbRed = new System.Windows.Forms.TrackBar();
            this.tbGreen = new System.Windows.Forms.TrackBar();
            this.tbBlue = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelColor = new System.Windows.Forms.Panel();
            this.txtColorName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).BeginInit();
            this.panelColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstAvailableColors
            // 
            this.lstAvailableColors.DisplayMember = "ColorName";
            this.lstAvailableColors.FormattingEnabled = true;
            this.lstAvailableColors.ItemHeight = 20;
            this.lstAvailableColors.Location = new System.Drawing.Point(14, 34);
            this.lstAvailableColors.Margin = new System.Windows.Forms.Padding(5);
            this.lstAvailableColors.Name = "lstAvailableColors";
            this.lstAvailableColors.Size = new System.Drawing.Size(197, 364);
            this.lstAvailableColors.TabIndex = 0;
            this.lstAvailableColors.SelectedIndexChanged += new System.EventHandler(this.lstAvailableColors_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available Colors";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(219, 34);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 32);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(219, 72);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(95, 32);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "DELETE";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(219, 110);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(95, 29);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(219, 110);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 31);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(320, 110);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 32);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbRed
            // 
            this.tbRed.Location = new System.Drawing.Point(278, 170);
            this.tbRed.Maximum = 255;
            this.tbRed.Name = "tbRed";
            this.tbRed.Size = new System.Drawing.Size(151, 45);
            this.tbRed.TabIndex = 6;
            this.tbRed.Scroll += new System.EventHandler(this.tbRed_Scroll);
            // 
            // tbGreen
            // 
            this.tbGreen.Location = new System.Drawing.Point(278, 221);
            this.tbGreen.Maximum = 255;
            this.tbGreen.Name = "tbGreen";
            this.tbGreen.Size = new System.Drawing.Size(151, 45);
            this.tbGreen.TabIndex = 6;
            this.tbGreen.Scroll += new System.EventHandler(this.tbGreen_Scroll);
            // 
            // tbBlue
            // 
            this.tbBlue.Location = new System.Drawing.Point(278, 272);
            this.tbBlue.Maximum = 255;
            this.tbBlue.Name = "tbBlue";
            this.tbBlue.Size = new System.Drawing.Size(151, 45);
            this.tbBlue.TabIndex = 6;
            this.tbBlue.Scroll += new System.EventHandler(this.tbBlue_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "RED";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "GREEN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "BLUE";
            // 
            // panelColor
            // 
            this.panelColor.Controls.Add(this.txtColorName);
            this.panelColor.Location = new System.Drawing.Point(219, 313);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(210, 80);
            this.panelColor.TabIndex = 8;
            // 
            // txtColorName
            // 
            this.txtColorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColorName.Location = new System.Drawing.Point(29, 25);
            this.txtColorName.Name = "txtColorName";
            this.txtColorName.Size = new System.Drawing.Size(162, 22);
            this.txtColorName.TabIndex = 0;
            this.txtColorName.Text = "Buraya Bir Renk Girin";
            this.txtColorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ColorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(441, 405);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbBlue);
            this.Controls.Add(this.tbGreen);
            this.Controls.Add(this.tbRed);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstAvailableColors);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(457, 444);
            this.MinimumSize = new System.Drawing.Size(457, 444);
            this.Name = "ColorsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ColorsForm";
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).EndInit();
            this.panelColor.ResumeLayout(false);
            this.panelColor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstAvailableColors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TrackBar tbRed;
        private System.Windows.Forms.TrackBar tbGreen;
        private System.Windows.Forms.TrackBar tbBlue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.TextBox txtColorName;
    }
}