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
    public partial class PlayersForm : Form
    {
        private readonly WeAreTheChampionsContext db;
        public PlayersForm(WeAreTheChampionsContext db)
        {
            this.db = db;
            InitializeComponent();
            lstPlayers.DataSource = db.Players.ToList();
            lstPlayers.SelectedIndex = -1;
            cboTeams.DataSource = db.Teams.ToList();
            cboTeams.SelectedIndex = -1;
            txtPlayerName.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Player player = new Player();
            player.PlayerName = txtPlayerName.Text.Trim();
            
            if (txtPlayerName.Text == "")
            {
                MessageBox.Show("Oyuncu eklemek için bir oyuncu ismi girilmelidir");
                return;
            }

            if (cboTeams.SelectedIndex >= 0 )
            {
                Team team = cboTeams.SelectedItem as Team;
                if (team.TeamName.Contains("closed"))
                {
                    MessageBox.Show("Bu takım kapanmış oyuncu eklenemez");
                    return;
                }
                team.Players.Add(player);
            }
            db.Players.Add(player);
           
            db.SaveChanges();
            lstPlayers.DataSource = db.Players.ToList();
            lstPlayers.SelectedIndex = lstPlayers.Items.Count - 1;

        }
        private void cboTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            Team team = cboTeams.SelectedItem as Team;
            if (cbFilter.Checked == true)
            {
                lstPlayers.DataSource = team.Players.ToList();
            }
        }
        private void cbFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFilter.Checked == false)
            {
                lstPlayers.DataSource = db.Players.ToList();
            }
            else
            {
                MessageBox.Show("Artık takıma göre filtreleme yapabilirsiniz.Filtreleme Modunda Oyuncu Ekleme Yapılamaz.");
                btnAdd.Enabled = false;
            }
        }
        private void lstPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player player = lstPlayers.SelectedItem as Player;

            if (lstPlayers.SelectedIndex >= 0)
            {
                txtPlayerName.Text = player.PlayerName;
            }
            if (player==null || player.Team == null)
            {
                cboTeams.SelectedIndex = -1;
            }
            else
            {
                cboTeams.SelectedValue = player.TeamId;
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            Player player = lstPlayers.SelectedItem as Player;
            Team team = cboTeams.SelectedItem as Team;
            int seciliPlayer = lstPlayers.SelectedIndex;
            if (lstPlayers.Items.Count == 0)
            {
                MessageBox.Show("Silinecek oyuncu bulunmuyor");
                return;
            }
            db.Players.Remove(player);
            db.SaveChanges();
            if (cbFilter.Checked == true)
            {
                lstPlayers.DataSource = team.Players.ToList();
            }
            else
            {
                lstPlayers.DataSource = db.Players.ToList();
            }

            if (lstPlayers.Items.Count > 0)
            {
                if (seciliPlayer == lstPlayers.Items.Count)
                {
                    lstPlayers.SelectedIndex = seciliPlayer - 1;
                }
                else
                {
                    lstPlayers.SelectedIndex = seciliPlayer;
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            if (lstPlayers.SelectedIndex < 0)
            {
                MessageBox.Show("Düzenlemek için önce bir oyuncu seçiniz.");
                return;
            }
            btnEdit.Visible = false;
            btnSave.Visible = true;
            btnCancel.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnEdit.Visible = true;
            btnSave.Visible = false;
            btnCancel.Visible = false;
            Player player = lstPlayers.SelectedItem as Player;
            player.PlayerName = txtPlayerName.Text;
            int seciliIndeks = lstPlayers.SelectedIndex;
            if (cboTeams.SelectedIndex >= 0)
            {
                Team team = cboTeams.SelectedItem as Team;
                if (team.TeamName.Contains("closed"))
                {
                    MessageBox.Show("Bu takım kapanmış oyuncu eklenemez");
                    return;
                }
                player.Team = team;
            }
            if (txtPlayerName.Text == "")
            {
                MessageBox.Show("Oyuncu adı boş geçilemez");
                return;
            }
            db.SaveChanges();
            if (cbFilter.Checked == false)
            {
                lstPlayers.DataSource = db.Players.ToList();
            }
            else
            {
                Team team = cboTeams.SelectedItem as Team;
                lstPlayers.DataSource = team.Players.ToList();
            }
            lstPlayers.SelectedIndex = seciliIndeks;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnEdit.Visible = true;
            btnSave.Visible = false;
            btnCancel.Visible = false;
        }
    }
}
