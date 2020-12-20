using Domen;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokerBaze
{
    public class Broker
    {
        private SqlConnection connection;
        public Broker()
        {
           connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Priprema2;Integrated Security=True;");
        }

        public void OpenConnection() {

            connection.Open();
        }

        public void Closeconnection() {
            connection.Close();
        }

        


        public void AddPredmet(Predmet p)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"insert into Predmeti values ('{p.Naziv}','{p.ESPB}', @Vrsta)";
            command.Parameters.AddWithValue("@Vrsta", p.VrstaPredmeta);
            command.ExecuteNonQuery();
        }

        public List<Predmet> GetAllPredmeti()
        {
            List<Predmet> predmeti = new List<Predmet>();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "select * from Predmeti";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) {
                Predmet p = new Predmet
                {
                    PredmetId = (int)reader[0],
                    Naziv = (string) reader[1],
                    ESPB = (int) reader[2],
                    VrstaPredmeta = (VrstaPredmeta) reader[3]
                };
                predmeti.Add(p);
            }
            return predmeti;
        }

        public void DeleteStudent(Student student)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"delete from Students where Num = {student.Num}";
            command.ExecuteNonQuery();
        }

        public List<Student> GetAllStudents()
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "select * from Students";
            SqlDataReader reader = command.ExecuteReader();
            List<Student> studenti = new List<Student>();
            while (reader.Read()) {

                Student s = new Student
                {
                    Num = (int) reader[0],
                    Ime = (string) reader[1],
                    Prezime = (string) reader[2],
                    Tip = (Tip) reader[3]
                };

                studenti.Add(s);
            }
            return studenti;
        }

        public void AddStudent(Student s)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"insert into Students values ('{s.Num}','{s.Ime}','{s.Prezime}',@Tip)";
            command.Parameters.AddWithValue("@Tip", s.Tip);
            command.ExecuteNonQuery();
        }

        public int GetNewId()
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "select max(Num) from Students";
            object result = command.ExecuteScalar();
            if (result is DBNull)
            {
                return 1;
            }
            else {
                return (int)result + 1;
            }
        }

        public List<Prijava> GetAllPrijave()
        {
            List<Prijava> prijave = new List<Prijava>();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "select * from Prijava p join Predmeti pr on (p.PredmetId = pr.PredmetId)";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) {

                Prijava p = new Prijava {
                    PrijavaId = (int)reader[0],
                    Ime = (string)reader[1],
                    Prezime = (string)reader[2],
                    Ocena = (int)reader[3],
                    Predmet = new Predmet { 
                        PredmetId = (int) reader[4],
                        Naziv = (string) reader[6],
                        ESPB = (int) reader[7]
                    },
                    Espb = (int) reader[7]
                };

                prijave.Add(p);
            }
            return prijave;
        }

        public void AddPrijava(Prijava p)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"insert into Prijava values ('{p.Ime}','{p.Prezime}','{p.Ocena}','{p.Predmet.PredmetId}')";
            command.ExecuteNonQuery();
        }
    }
}
