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
    public partial class UCPrijava : UserControl
    {
        public UCPrijava()
        {
            InitializeComponent();
        }

        private void UCPrijava_Load(object sender, EventArgs e)
        {
            cmbPredmeti.DataSource = Kontroler.Instance.GetAllPredmeti();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtOcena.Text)
                || string.IsNullOrEmpty(txtPrezime.Text) || cmbPredmeti.SelectedItem == null) {
                MessageBox.Show("Niste uneli sva polja");
                return;
            }

            if (!int.TryParse(txtOcena.Text, out _) || int.Parse(txtOcena.Text)>10 || int.Parse(txtOcena.Text)<6) {
                MessageBox.Show("Lose unesena ocena");
                return;
            }

            Prijava p = new Prijava { 
                Ime = txtName.Text,
                Prezime = txtPrezime.Text,
                Ocena = int.Parse(txtOcena.Text),
                Predmet = (Predmet)cmbPredmeti.SelectedItem,
               
            };

            try
            {
                Kontroler.Instance.AddPrijava(p);
                MessageBox.Show("Uspesno ubacena");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
