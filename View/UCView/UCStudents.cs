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
    public partial class UCStudents : UserControl
    {
        private BindingList<Student> students = new BindingList<Student>(); 
        public UCStudents()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddStudent frmAddStudent = new FrmAddStudent();
            frmAddStudent.ShowDialog();
            students = new BindingList<Student>(Kontroler.Instance.GetAllStudents());
            dgvStudents.DataSource = students;
        }

        private void UCStudents_Load(object sender, EventArgs e)
        {
            students = new BindingList<Student>(Kontroler.Instance.GetAllStudents());
            dgvStudents.DataSource = students;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvStudents.SelectedRows[0];
            Student student = (Student)row.DataBoundItem;

            try
            {
                Kontroler.Instance.DeleteStudent(student);
                MessageBox.Show($"Izbrisan {student.Ime} {student.Prezime}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            students = new BindingList<Student>(Kontroler.Instance.GetAllStudents());
            dgvStudents.DataSource = students;
        }
    }
}
