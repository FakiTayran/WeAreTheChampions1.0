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
    public partial class NewMatchAddForm : Form
    {
        private readonly WeAreTheChampionsContext db;
        public event EventHandler NewMatchAdded;
        public NewMatchAddForm(WeAreTheChampionsContext db)
        {
            this.db = db;
            InitializeComponent();
            dtMatchTime.Format = DateTimePickerFormat.Custom;
            dtMatchTime.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            cboHomeTeam.DataSource = db.Teams.ToList();
            cboGuestTeam.DataSource = db.Teams.ToList();
            nudScoreGuestTeam.Enabled = false;
            nudScoreHomeTeam.Enabled = false;
            cbDraw.Enabled = false;
            cbTeam1Won.Enabled = false;
            cbTeam2Won.Enabled = false;
        }

        private void cboHomeTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            Team team = cboHomeTeam.SelectedItem as Team;

            if (cboHomeTeam.SelectedIndex >= 0 && cboGuestTeam.SelectedIndex >= 0)
            {
                cboGuestTeam.DataSource = db.Teams.ToList().Where(x => x.Id != team.Id).ToList();
            }
        }

        private void cboGuestTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            Team team = cboHomeTeam.SelectedItem as Team;

            if (cboGuestTeam.SelectedIndex >= 0 && cboHomeTeam.SelectedIndex >= 0)
            {
                cboHomeTeam.DataSource = db.Teams.ToList().Where(x => x.Id != team.Id).ToList();
            }
        }

        private void btnCreateMatch_Click(object sender, EventArgs e)
        {
            DateTime nowDateTime = new DateTime();
            nowDateTime = DateTime.Now;
            Team homeTeam = cboHomeTeam.SelectedItem as Team;
            Team guestTeam = cboGuestTeam.SelectedItem as Team;
            Match newMatch = new Match();
            if (homeTeam == guestTeam)
            {
                MessageBox.Show("Takımlar aynı girilemez");
                return;
            }
            DateTime matchTime = dtMatchTime.Value;
            newMatch.HomeTeam = homeTeam;
            newMatch.GuestTeam = guestTeam;
            newMatch.MatchTime = matchTime;
            if (DateTime.Compare(matchTime, nowDateTime) < 0 )
            {
                newMatch.HomePoints = (int)nudScoreHomeTeam.Value;
                newMatch.GuestPoints = (int)nudScoreGuestTeam.Value;
                if (cbDraw.Checked == true)
                {
                    newMatch.Result = MatchResult.Draw;
                }
                else if (cbTeam1Won.Checked == true)
                {
                    newMatch.Result = MatchResult.HomeTeamWon;
                }
                else if (cbTeam2Won.Checked == true)
                {
                    newMatch.Result = MatchResult.GuestTeamWon;
                }
            }
            db.Matches.Add(newMatch);
            db.SaveChanges();
            WhenTheMatchIsAdded(EventArgs.Empty);
        }

        private void WhenTheMatchIsAdded(EventArgs args)
        {
            if (NewMatchAdded != null)
            {
                NewMatchAdded(this, args);
            }
        }

        private void dtMatchTime_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateTimeNow = new DateTime();
            dateTimeNow = DateTime.Now;
            DateTime matchDateTime = dtMatchTime.Value;
            if (DateTime.Compare(dateTimeNow,matchDateTime)<0)
            {
                nudScoreGuestTeam.Enabled = false;
                nudScoreHomeTeam.Enabled = false;
                cbDraw.Enabled = false;
                cbTeam1Won.Enabled = false;
                cbTeam2Won.Enabled = false;
            }
            else if (DateTime.Compare(dateTimeNow, matchDateTime) > 0)
            {
                nudScoreGuestTeam.Enabled = true;
                nudScoreHomeTeam.Enabled = true;
                cbDraw.Enabled = true;
                cbTeam1Won.Enabled = true;
                cbTeam2Won.Enabled = true;
            }
        }

        private void cbTeam1Won_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTeam1Won.Checked == true)
            {
                cbTeam2Won.Checked = false;
                cbDraw.Checked = false;
            }
        }

        private void cbTeam2Won_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTeam2Won.Checked == true)
            {
                cbTeam1Won.Checked = false;
                cbDraw.Checked = false;
            }
        }

        private void cbDraw_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDraw.Checked == true)
            {
                cbTeam1Won.Checked = false;
                cbTeam2Won.Checked = false;
            }
        }

        private void nudScoreGuestTeam_ValueChanged(object sender, EventArgs e)
        {
            nudToCheckBox();
        }

        private void nudToCheckBox()
        {
            if (nudScoreGuestTeam.Value == nudScoreHomeTeam.Value)
            {
                cbDraw.Checked = true;
                cbTeam2Won.Checked = false;
                cbTeam1Won.Checked = false;

            }
            else if (nudScoreGuestTeam.Value < nudScoreHomeTeam.Value)
            {
                cbTeam1Won.Checked = true;
                cbDraw.Checked = false;
                cbTeam2Won.Checked = false;
            }
            else
            {
                cbDraw.Checked = false;
                cbTeam2Won.Checked = true;
                cbTeam1Won.Checked = false;
            }
        }

        private void nudScoreHomeTeam_ValueChanged(object sender, EventArgs e)
        {
            nudToCheckBox();
        }
    }
}
