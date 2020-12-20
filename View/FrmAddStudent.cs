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
    public partial class FrmAddStudent : Form
    {
        public FrmAddStudent()
        {
            InitializeComponent();
            cmbTip.DataSource = Enum.GetValues(typeof(Tip));
            txtNum.Text = IdNumber().ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIme.Text) || string.IsNullOrEmpty(txtPrezime.Text)) {
                MessageBox.Show("Imate prazna polja");
                return;
            }

            Student s = new Student { 
                Num = IdNumber(),
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                Tip = (Tip) cmbTip.SelectedItem
            };

            try
            {
                Kontroler.Instance.SaveStudent(s);
                MessageBox.Show("Uspesno sacuvan");
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public int IdNumber() {

            return Kontroler.Instance.GetNewId();

        }

    }
}
