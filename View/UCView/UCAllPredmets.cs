using Controller;
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
    public partial class UCAllPredmets : UserControl
    {
        public UCAllPredmets()
        {
            InitializeComponent();
        }

        private void UCAllPredmets_Load(object sender, EventArgs e)
        {
            try
            {
                dgvPredmeti.DataSource = Kontroler.Instance.GetAllPredmeti();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
