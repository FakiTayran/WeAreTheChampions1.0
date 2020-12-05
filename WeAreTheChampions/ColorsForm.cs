using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreTheChampions.Models;
using Color = WeAreTheChampions.Models.Color;

namespace WeAreTheChampions
{
    public partial class ColorsForm : Form
    {
        int red = 0;
        int green = 0;
        int blue = 0;
        private readonly WeAreTheChampionsContext db;

        public ColorsForm(WeAreTheChampionsContext db)
        {
            this.db = db;
            InitializeComponent();
            panelColor.BackColor = System.Drawing.Color.Black;
            lstAvailableColors.DataSource = db.Colors.ToList();
            lstAvailableColors.SelectedIndex = -1;
            tbRed.Value = 0;
            tbGreen.Value = 0;
            tbBlue.Value = 0;
        }

        private void lstAvailableColors_SelectedIndexChanged(object sender, EventArgs e)
        {
           Color selectedColor = lstAvailableColors.SelectedItem as Color;
            if (selectedColor == null)
            {
                return;
            }
            tbRed.Value = selectedColor.Red;
            tbGreen.Value = selectedColor.Green;
            tbBlue.Value = selectedColor.Blue;
            txtColorName.Text = selectedColor.ColorName;
            panelColor.BackColor = System.Drawing.Color.FromArgb(selectedColor.Red, selectedColor.Green, selectedColor.Blue);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            Color newColor = new Color();
            newColor.ColorName = txtColorName.Text.Trim();
            if (txtColorName.Text == "")
            {
                MessageBox.Show("Bu aşamada bir renk ismi belirtmek zorundasınız");
                return;
            }
            if (db.Colors.Any(x => x.ColorName == newColor.ColorName))
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Bu isimde Renk mevcut,yeni renk mi oluşturmak istiyorsunuz", "Yeni Renk Oluşturma", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    lstAvailableColors.SelectedIndex = -1;
                    txtColorName.Text = "";
                    tbBlue.Value = 0;
                    tbGreen.Value = 0;
                    tbRed.Value = 0;
                    txtColorName.Focus();
                    panelColor.BackColor = System.Drawing.Color.Black;
                    return;
                }
                else
                {
                    return;
                }
            }
            newColor.Red = tbRed.Value;
            newColor.Green = tbGreen.Value;
            newColor.Blue = tbBlue.Value;
            db.Colors.Add(newColor);
            db.SaveChanges();
            lstAvailableColors.DataSource = db.Colors.ToList();
            lstAvailableColors.SelectedIndex = lstAvailableColors.Items.Count - 1;

        }
        private void RenkAyarlar()
        {
            red = tbRed.Value;
            green = tbGreen.Value;
            blue = tbBlue.Value;

        }

        private void tbRed_Scroll(object sender, EventArgs e)
        {
            RenkAyarlar();
            panelColor.BackColor = System.Drawing.Color.FromArgb(red, green, blue);
        }

        private void tbGreen_Scroll(object sender, EventArgs e)
        {
            RenkAyarlar();
            panelColor.BackColor = System.Drawing.Color.FromArgb(red, green, blue);
        }

        private void tbBlue_Scroll(object sender, EventArgs e)
        {

            btnAdd.Enabled = true;
            RenkAyarlar();
            panelColor.BackColor = System.Drawing.Color.FromArgb(red, green, blue);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Color silinecekColor = (Color)lstAvailableColors.SelectedItem;
            int seciliIndeks = lstAvailableColors.SelectedIndex;
            db.Colors.Remove(silinecekColor);
            db.SaveChanges();
            lstAvailableColors.DataSource = db.Colors.ToList();
            if (lstAvailableColors.Items.Count > 0)
            {
                if (seciliIndeks == lstAvailableColors.Items.Count)
                {
                    lstAvailableColors.SelectedIndex = seciliIndeks - 1;
                }
                else
                {
                    lstAvailableColors.SelectedIndex = seciliIndeks;
                }
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstAvailableColors.SelectedIndex<0)
            {
                MessageBox.Show("Lütfen düzenleme yapmak istediğiniz rengi seçiniz.");
                return;
            }
            btnEdit.Visible = false;
            btnSave.Visible = true;
            btnCancel.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnEdit.Visible = true;
            btnSave.Visible = false;
            btnCancel.Visible = false;
            Color color = lstAvailableColors.SelectedItem as Color;
            int seciliIndeks = lstAvailableColors.SelectedIndex;

            color.Red = tbRed.Value;
            color.Green = tbGreen.Value;
            color.Blue = tbBlue.Value;
            color.ColorName = txtColorName.Text;

            if (txtColorName.Text == "")
            {
                MessageBox.Show("Renk adı boş geçilemez");
                return;
            }
            db.SaveChanges();
            lstAvailableColors.DataSource = db.Colors.ToList();
            lstAvailableColors.SelectedIndex = seciliIndeks;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Visible = false;
            btnSave.Visible = false;
            btnEdit.Visible = true;
        }
    }
}
