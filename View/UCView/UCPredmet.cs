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
    public partial class UCPredmet : UserControl
    {
        public UCPredmet()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtEspb.Text)) {
                MessageBox.Show("Imate prazna polja");
                return;
            }

            if (!int.TryParse(txtEspb.Text, out _)) {
                MessageBox.Show("Niste lepo uneli polje ESPB!");
                return;
            }

            Predmet p = new Predmet { 
                Naziv = txtName.Text,
                ESPB = int.Parse(txtEspb.Text),
                VrstaPredmeta = (VrstaPredmeta)cmbEspb.SelectedItem
            };

            try
            {
                Kontroler.Instance.AddPredmet(p);
                MessageBox.Show("Uspesno uneto");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void UCPredmet_Load(object sender, EventArgs e)
        {
            cmbEspb.DataSource = Enum.GetValues(typeof(VrstaPredmeta));
        }
    }
}
