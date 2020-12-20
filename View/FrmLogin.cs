using Controller;
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

namespace View
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            lblPokusaji.Text = brojPokusaja.ToString();
        }

        public static int brojPokusaja = 3;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtKorisnickoIme.Text) || string.IsNullOrEmpty(txtKorisnickoIme.Text)) {
                MessageBox.Show("Niste uneli sve podatke");
                brojPokusaja -= 1;
                lblPokusaji.Text = brojPokusaja.ToString();
                return;
            }
           
            Korisnik k = new Korisnik
            {
                KorisnickoIme = txtKorisnickoIme.Text,
                Lozinka = txtLozinka.Text
            };

            try
            {
                Korisnik kk = Kontroler.Instance.Login(k.KorisnickoIme, k.Lozinka);
                FrmMain frmMain = new FrmMain(kk);
                frmMain.ShowDialog();
            }
            catch (Exception ex)
            {
                brojPokusaja -= 1;
                MessageBox.Show(ex.Message);
                lblPokusaji.Text = brojPokusaja.ToString();

            }
            lblPokusaji.Text = brojPokusaja.ToString();
            if (brojPokusaja == 0) {
                Environment.Exit(0);
            }
        }
    }
}
