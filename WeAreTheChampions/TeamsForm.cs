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
namespace WeAreTheChampions
{
    public partial class TeamsForm : Form
    {
        private readonly WeAreTheChampionsContext db;
        public List<Team> DeletedTeams = new List<Team>();
        public TeamsForm(WeAreTheChampionsContext db)
        {
            this.db = db;
            InitializeComponent();

            cboColors.DataSource = db.Colors.ToList();
            cboColors.SelectedIndex = -1;
            btnAddColorToTeam.Visible = false;
            lstTeams.DataSource = db.Teams.ToList();
            lstTeams.SelectedIndex = -1;
            label4.Visible = false;
            cboTeamColors.Visible = false;
            btnRemoveFromTeam.Visible = false;
            panel1.Visible = false;
            txtTeamName.Text = string.Empty;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnCancel.Visible = false;
            btnAddNewTeams.Enabled = false;
            if (lstTeams.SelectedIndex < 0)
            {
                MessageBox.Show("Lütfen değişiklikleri kaydetmek istediğiniz takımı seçiniz.");
                return;
            }
            else
            {
                int seciliIndeks = lstTeams.SelectedIndex;
                Team team = lstTeams.SelectedItem as Team;
                team.TeamName = txtTeamName.Text;
                if (txtTeamName.Text.Contains("closed"))
                {
                    MessageBox.Show("closed kelimesi bir takım ismi belirlerken kullanılamaz");
                    return;
                }
                if (txtTeamName.Text == "")
                {
                    MessageBox.Show("Takım ismi boş girilemez");
                    return;
                }
                lstTeams.DataSource = db.Teams.ToList();
                lstTeams.SelectedIndex = seciliIndeks;
                db.SaveChanges();
            }
        }

        private void lstTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Visible = true;
            cboTeamColors.Visible = true;
            btnRemoveFromTeam.Visible = true;
            panel1.Visible = true;
            if (cboColors.SelectedIndex >= 0)
            {
                btnAddColorToTeam.Visible = true;
            }
            if (lstTeams.SelectedIndex < 0)
            {
                return;
            }
            Team team = (Team)lstTeams.SelectedItem;
            txtTeamName.Text = team.TeamName;
            panel1.Controls.Clear();
            cboTeamColors.Items.Clear();
            for (int i = 0; i < team.Colors.Count; i++)
            {
                Label label = new Label();
                panel1.Controls.Add(label);
                label.AutoSize = false;
                label.Width = 50;
                label.Height = 50;
                var s = team.Colors.ToArray();
                cboTeamColors.Items.Add(s[i]);
                int red = s[i].Red;
                int green = s[i].Green;
                int blue = s[i].Blue;
                label.BackColor = System.Drawing.Color.FromArgb(red, green, blue);
                Point point = new Point();
                label.Left += i * 50;
            }
            Models.Color color = cboTeamColors.SelectedItem as Models.Color;
        }

        private void btnAddNewTeams_Click(object sender, EventArgs e)
        {
            Team team = new Team();
            team.TeamName = txtTeamName.Text.Trim();
            if (txtTeamName.Text == "")
            {
                MessageBox.Show("Lütfen bir takım adı giriniz");
                return;
            }
            else if (txtTeamName.Text.Contains("closed"))
            {
                MessageBox.Show("closed kelimesi bir takım ismi belirlerken kullanılamaz");
                return;
            }
            if (db.Teams.Any(x => x.TeamName == team.TeamName))
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Bu isimde takım mevcut,yeni takım mı oluşturmak istiyorsunuz", "Yeni Takım Oluşturma", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    lstTeams.SelectedIndex = -1;
                    txtTeamName.Text = "";
                    txtTeamName.Focus();
                    btnAddColorToTeam.Visible = false;
                    panel1.Visible = false;
                    cboColors.SelectedIndex = -1;
                }
                else
                {
                    return;
                }
                return;
            }
            if (cboColors.SelectedIndex >= 0)
            {
                Models.Color color = cboColors.SelectedItem as Models.Color;
                team.Colors.Add(color);
            }
            db.Teams.Add(team);
            db.SaveChanges();
            lstTeams.DataSource = db.Teams.ToList();
            lstTeams.SelectedIndex = lstTeams.Items.Count - 1;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnCancel.Visible = true;
            btnAddNewTeams.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Visible = false;
            btnSave.Enabled = false;
            btnAddNewTeams.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstTeams.SelectedIndex < 0)
            {
                MessageBox.Show("Silmek için önce bir takım seçin");
                return;
            }
            Team team = lstTeams.SelectedItem as Team;
            int seciliIndeks = lstTeams.SelectedIndex;
            if (team.TeamName.Contains("(closed)") && (team.AwayMatches.Count != 0 || team.HomeMatches.Count != 0 ))
            {
                MessageBox.Show("Bu takımın maçı var ve zaten kapanmış tamamen silmek için mevcut maçını silin");
                return;
            }

            if (team.HomeMatches.Count != 0 || team.AwayMatches.Count != 0)
            {
                team.TeamName = $"{team.TeamName}(closed)";
                if (team.Players.Count > 0)
                {
                    for (int i = 0; i <= team.Players.Count; i++)
                    {
                        var s = team.Players.ToArray();
                        Player player = s[0];
                        team.Players.Remove(player);
                    }
                }
            }
            else
            {
                db.Teams.Remove(team);
            }
            db.SaveChanges();
            lstTeams.DataSource = db.Teams.ToList();

            if (lstTeams.Items.Count > 0)
            {
                if (seciliIndeks == lstTeams.Items.Count)
                {
                    lstTeams.SelectedIndex = seciliIndeks - 1;
                }
                else
                {
                    lstTeams.SelectedIndex = seciliIndeks;
                }
            }
        }
        private void btnPlayers_Click(object sender, EventArgs e)
        {
            if (lstTeams.SelectedIndex < 0)
            {
                MessageBox.Show("Oyuncularını görmek istediğiniz bir Takım Seçiniz");
                return;
            }
            Team team = (Team)lstTeams.SelectedItem;
            if (team.TeamName.Contains("closed"))
            {
                MessageBox.Show("Bu takım kapanmış olduğu için oyuncusu yok ve transfer yapılamaz.");
                return;
            }
            frmTeamsPlayers frm = new frmTeamsPlayers(db, team);
            frm.ShowDialog();
        }

        private void cboColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            Models.Color color = cboColors.SelectedItem as Models.Color;
            if (cboColors.SelectedIndex < 0)
            {
                return;
            }
            if (color == null)
            {
                return;
            }
            if (lstTeams.SelectedIndex >= 0)
            {
                btnAddColorToTeam.Visible = true;
            }
        }
        private void btnAddColorToTeam_Click(object sender, EventArgs e)
        {
            if (lstTeams.SelectedIndex < 0)
            {
                MessageBox.Show("Takıma renk eklemek için listeden önce takım seçmelisiniz.");
                return;
            }
            if (panel1.Controls.Count == 8)
            {
                MessageBox.Show("Takım rengi 8'e ulaştığından daha fazla renk Ekleyemezsiniz.");
                return;
            }

            Models.Color color = cboColors.SelectedItem as Models.Color;
            Team team = lstTeams.SelectedItem as Team;
            if (team.Colors.Contains(color))
            {
                MessageBox.Show("Bu renk zaten mevcut");
                return;
            }
            int selectedIndeks = lstTeams.SelectedIndex;
            team.Colors.Add(color);
            db.SaveChanges();
            lstTeams.DataSource = db.Teams.ToList();
            lstTeams.SelectedIndex = selectedIndeks;
        }

        private void btnRemoveFromTeam_Click(object sender, EventArgs e)
        {
            int selectedIndeks = lstTeams.SelectedIndex;

            Models.Color color = cboTeamColors.SelectedItem as Models.Color;
            Team team = (Team)lstTeams.SelectedItem;
            team.Colors.Remove(color);
            db.SaveChanges();
            lstTeams.DataSource = db.Teams.ToList();
            var s = team.Colors.ToArray();
            for (int i = 0; i < team.Colors.Count; i++)
            {
                cboTeamColors.Items.Add(s[i]);
            }
            lstTeams.SelectedIndex = selectedIndeks;
        }
    }
}
