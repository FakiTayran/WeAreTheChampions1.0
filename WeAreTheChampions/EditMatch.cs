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
    public partial class EditMatch : Form
    {
        private readonly WeAreTheChampionsContext db;
        private readonly int id;
        public event EventHandler CurrentMatchChanged;
        public EditMatch(WeAreTheChampionsContext db, int id)
        {
            this.db = db;
            this.id = id;
            InitializeComponent();
            dtMatchTime.Format = DateTimePickerFormat.Custom;
            dtMatchTime.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            nudScoreGuestTeam.Enabled = false;
            nudScoreHomeTeam.Enabled = false;
            cbDraw.Enabled = false;
            cbTeam1Won.Enabled = false;
            cbTeam2Won.Enabled = false;

            cboHomeTeam.DataSource = db.Teams.ToList();
            cboGuestTeam.DataSource = db.Teams.ToList();
            Match match = db.Matches.FirstOrDefault(x => x.Id == id);
            cboHomeTeam.SelectedItem = match.HomeTeam;
            cboGuestTeam.SelectedItem = match.GuestTeam;
            if (match.HomePoints == null || match.GuestPoints == null)
            {
                nudScoreGuestTeam.Value = 0;
                nudScoreHomeTeam.Value = 0;
            }
            else
            {
                nudScoreGuestTeam.Value = (decimal)match.GuestPoints;
                nudScoreHomeTeam.Value = (decimal)match.HomePoints;

            }
            if (match.MatchTime != null)
            {
                dtMatchTime.Value = match.MatchTime.Value;
            }
            if (match.Result != null)
            {
                if (match.Result == MatchResult.Draw)
                {
                    cbDraw.Checked = true;
                }
                else if (match.Result == MatchResult.HomeTeamWon)
                {
                    cbTeam1Won.Checked = true;
                }
                else
                {
                    cbTeam2Won.Checked = true;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Match match = db.Matches.FirstOrDefault(x => x.Id == id);
            Team homeTeam = cboHomeTeam.SelectedItem as Team;
            Team guestTeam = cboGuestTeam.SelectedItem as Team;
            if (homeTeam.TeamName.Contains("closed") || guestTeam.TeamName.Contains("closed"))
            {
                MessageBox.Show("Kapanmış takımlara maç ayarlanamaz");
                return;
            }
            if (homeTeam == guestTeam)
            {
                MessageBox.Show("Takımlar aynı girilemez");
                return;
            }
            match.HomeTeam = homeTeam;
            match.GuestTeam = guestTeam;
            DateTime nowDateTime = DateTime.Now;
            if (match.MatchTime != null)
            {
                DateTime matchDateTime = dtMatchTime.Value;

                if (DateTime.Compare(matchDateTime, nowDateTime) < 0)
                {
                    match.HomePoints = (int)nudScoreHomeTeam.Value;
                    match.GuestPoints = (int)nudScoreGuestTeam.Value;
                    if (cbDraw.Checked == true)
                    {
                        match.Result = MatchResult.Draw;
                    }
                    else if (cbTeam1Won.Checked == true)
                    {
                        match.Result = MatchResult.HomeTeamWon;
                    }
                    else if (cbTeam2Won.Checked == true)
                    {
                        match.Result = MatchResult.GuestTeamWon;
                    }
                }
            }
            db.SaveChanges();

            WhenTheCurrentMatchChanges(EventArgs.Empty);
            Close();
        }

        private void WhenTheCurrentMatchChanges(EventArgs args)
        {
            if (CurrentMatchChanged != null)
            {
                CurrentMatchChanged(this, args);
            }
        }

        private void nudScoreHomeTeam_ValueChanged(object sender, EventArgs e)
        {
            nudToCheckBox();
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

        private void dtMatchTime_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateTimeNow = DateTime.Now;
            DateTime matchDateTime = dtMatchTime.Value;
            if (DateTime.Compare(dateTimeNow, matchDateTime) < 0)
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

            if (cboHomeTeam.SelectedIndex >= 0 && cboGuestTeam.SelectedIndex >= 0)
            {
                cboGuestTeam.DataSource = db.Teams.ToList().Where(x => x.Id != team.Id).ToList();
            }
        }
    }
}
