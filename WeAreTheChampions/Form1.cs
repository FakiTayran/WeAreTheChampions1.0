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
    public partial class Form1 : Form
    {
        WeAreTheChampionsContext db = new WeAreTheChampionsContext();
        public Form1()
        {
            InitializeComponent();
            
            PrintData();
        }

        private void teamMenuStrip_Click(object sender, EventArgs e)
        {
            TeamsForm frm = new TeamsForm(db);
            frm.ShowDialog();
        }

        private void colorsMenuStrip_Click(object sender, EventArgs e)
        {
            ColorsForm frm = new ColorsForm(db);
            frm.ShowDialog();
        }

        private void playersMenuStrip_Click(object sender, EventArgs e)
        {
            PlayersForm frm = new PlayersForm(db);
            frm.ShowDialog();
        }

        private void btnNewMatch_Click(object sender, EventArgs e)
        {
            NewMatchAddForm frm = new NewMatchAddForm(db);
            frm.NewMatchAdded += Frm_NewMatchAdded;
            frm.ShowDialog();
        }

        private void Frm_NewMatchAdded(object sender, EventArgs e)
        {
            PrintData();
        }

        private void PrintData()
        {
            dgvMatches.DataSource = db.Matches.OrderBy(x => x.MatchTime).ToList()
                            .Select(x => new
                            {
                                x.Id,
                                x.HomeTeam,
                                x.GuestTeam,
                                Date = $"{x.MatchTime:yyyy/MM/dd}",
                                Hour = $"{x.MatchTime:H:mm:ss}",
                                Score = $"{x.HomePoints}-{x.GuestPoints}",
                                x.Result
                            }).ToList();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id =(int)dgvMatches.SelectedRows[0].Cells[0].Value;
            EditMatch frm = new EditMatch(db,id);
            frm.CurrentMatchChanged += Frm_CurrentMatchChanged;
            frm.ShowDialog();
        }

        private void Frm_CurrentMatchChanged(object sender, EventArgs e)
        {
            PrintData();
        }

        private void dgvMatches_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dgvMatches.SelectedRows[0].Cells[0].Value;
            EditMatch frm = new EditMatch(db, id);
            frm.CurrentMatchChanged += Frm_CurrentMatchChanged;
            frm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = (int)dgvMatches.SelectedRows[0].Cells[0].Value;
            Match match = db.Matches.FirstOrDefault(x => x.Id == id);

            db.Matches.Remove(match);
            db.SaveChanges();
            PrintData();

        }
    }
}
