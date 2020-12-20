using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.UCView;

namespace View
{
    public partial class FrmMain : Form
    {
        public FrmMain(Korisnik k)
        {
            InitializeComponent();
            lblKorisnik1.Text = $"Welcome {k.Ime} {k.Prezime}";
        }

        private void unesiPredmetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            UCPredmet ucPredmet = new UCPredmet();
            ucPredmet.Parent = pnlMain;
            ucPredmet.Dock = DockStyle.Fill;



        }

        private void unesiPrijavuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            UCPrijava ucPrijava = new UCPrijava();
            ucPrijava.Parent = pnlMain;
            ucPrijava.Dock = DockStyle.Fill;
        }

        private void promeniKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            UCPromenaKorisnika ucKorisnik = new UCPromenaKorisnika();
            ucKorisnik.Parent = pnlMain;
            ucKorisnik.Dock = DockStyle.Fill;
        }

        private void priakaziSvePrijaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrikaziSvePrijave frmPrikazi = new FrmPrikaziSvePrijave();
            frmPrikazi.ShowDialog();
        }

        private void prikaziSvePredmeteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            UCAllPredmets ucAllPredmets = new UCAllPredmets();
            ucAllPredmets.Parent = pnlMain;
            ucAllPredmets.Dock = DockStyle.Fill;
        }

        private void studentiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            UCStudents ucStudents = new UCStudents();
            ucStudents.Parent = pnlMain;
            ucStudents.Dock = DockStyle.Fill;
        }
    }
}
