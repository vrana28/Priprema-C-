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

namespace View.UCView
{
    public partial class UCPromenaKorisnika : UserControl
    {
        public UCPromenaKorisnika()
        {
            InitializeComponent();
        }

        private void UCPromenaKorisnika_Load(object sender, EventArgs e)
        {
            cmbKorisnici.DataSource = Kontroler.Instance.korisnici;
            Korisnici = Kontroler.Instance.korisnici;
        }

        public Korisnik StariKorisnik { get; set; }

        public List<Korisnik> Korisnici { get; set; }

        private void btnIzaberi_Click(object sender, EventArgs e)
        {
            Korisnik k = (Korisnik)cmbKorisnici.SelectedItem;
            txtName.Text = k.Ime;
            txtPrezime.Text = k.Prezime;
            txtUsername.Text = k.KorisnickoIme;
            txtPassword.Text = k.Lozinka;
            StariKorisnik = k;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPrezime.Text) || string.IsNullOrEmpty(txtPassword.Text)
                || string.IsNullOrEmpty(txtUsername.Text)) {
                MessageBox.Show("Niste uneli sva polja");
                return;
            }

            int indeks = StariKorisnik.KorisnikId-1;
            Korisnik novi = new Korisnik {
                Ime = txtName.Text,
                Prezime = txtPrezime.Text,
                KorisnickoIme = txtUsername.Text,
                Lozinka = txtPassword.Text
            };
            Korisnici[indeks] = novi;
            cmbKorisnici.DataSource = null;
            cmbKorisnici.DataSource = Korisnici;
            MessageBox.Show("Uspesno promenjeno");
        }
    }
}
