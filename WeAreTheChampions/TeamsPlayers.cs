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
    public partial class frmTeamsPlayers : Form
    {
        private readonly WeAreTheChampionsContext db;
        private readonly Team team;
        public frmTeamsPlayers(WeAreTheChampionsContext db,Team team)
        {
            this.db = db;
            this.team = team;
            InitializeComponent();
            lstTeamsPlayers.DataSource = team.Players.ToList() ;
            lstTeamsPlayers.SelectedIndex = -1;
            lstIdlePlayers.DataSource = db.Players.Where(x => x.Team == null).ToList();
            lstTeamsPlayers.SelectedIndex = -1;
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (lstTeamsPlayers.SelectedIndex >= 0 )
            {
                Player player = lstTeamsPlayers.SelectedItem as Player;
                player.Team = null;
                db.SaveChanges();
                lstTeamsPlayers.DataSource = team.Players.ToList();
                lstIdlePlayers.DataSource = db.Players.Where(x => x.Team == null).ToList();
            }
            else if(lstIdlePlayers.SelectedIndex >= 0)
            {
                Player player = lstIdlePlayers.SelectedItem as Player;
                player.Team = team;
                db.SaveChanges();
                lstTeamsPlayers.DataSource = team.Players.ToList();
                lstIdlePlayers.DataSource = db.Players.Where(x => x.Team == null).ToList();
            }
        }

        private void lstTeamsPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstIdlePlayers.SelectedIndex = -1;
        
        }

        private void lstIdlePlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstTeamsPlayers.SelectedIndex = -1;
          
        }
    }
}
