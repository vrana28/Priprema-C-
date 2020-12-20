using BrokerBaze;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Controller
{
    public class Kontroler
    {
        private static Kontroler instance;

        private Broker broker = new Broker();

        public List<Korisnik> korisnici = new List<Korisnik> {
        new Korisnik{
            KorisnikId =1,
            KorisnickoIme = "admin",
            Lozinka = "admin",
            Ime = "Marko",
            Prezime = "Maric"
        },
        new Korisnik{
            KorisnikId = 2,
            KorisnickoIme = "ana",
            Lozinka = "ana1",
            Ime = "Ana",
            Prezime = "Anic"
        },
        new Korisnik {
            KorisnikId = 3,
            KorisnickoIme = "aca",
            Lozinka = "coa",
            Ime = "Aca",
            Prezime = "Acic"
        },
        new Korisnik{
            KorisnikId =1,
            KorisnickoIme = "lale",
            Lozinka = "lale",
            Ime = "Lara",
            Prezime = "Lalic"
        }
        };

        public List<Student> GetAllStudents()
        {
            try
            {
                broker.OpenConnection();
                return broker.GetAllStudents();
            }
            finally
            {
                broker.Closeconnection();
            }
        }

        public void DeleteStudent(Student student)
        {
            try
            {
                broker.OpenConnection();
                broker.DeleteStudent(student);
            }
            finally
            {
                broker.Closeconnection();
            }
        }

        public void SaveStudent(Student s)
        {
            try
            {
                broker.OpenConnection();
                broker.AddStudent(s);
            }
            finally
            {
                broker.Closeconnection();
            }
        }

        public int GetNewId()
        {
            try
            {
                broker.OpenConnection();
                return broker.GetNewId();
            }
            finally
            {
                broker.Closeconnection();
            }
        }

        public List<Prijava> GetAllPrijave()
        {
            try
            {
                broker.OpenConnection();
                return broker.GetAllPrijave();
            }
            finally
            {
                broker.Closeconnection();
            }
        }

        public List<Predmet> GetAllPredmeti()
        {
            try
            {
                broker.OpenConnection();
                return broker.GetAllPredmeti();
            }
            finally {
                broker.Closeconnection();
            }
        }

        private Kontroler()
        {

        }

        public void AddPrijava(Prijava p)
        {
            try
            {
                broker.OpenConnection();
                broker.AddPrijava(p);
            }
            finally
            {
                broker.Closeconnection();
            }
        }

        public Korisnik TrenutniKorisnik { get; set; }

        public static Kontroler Instance {
            get {
                if (instance == null) instance = new Kontroler();
                return instance;
            }
        }

        public void AddPredmet(Predmet p)
        {
            try
            {
                broker.OpenConnection();
                broker.AddPredmet(p);

            }
            finally
            {
                broker.Closeconnection();
            }
        }

        public Korisnik Login(string korisnickoIme, string lozinka)
        {

            if (korisnici.Any(k => k.KorisnickoIme == korisnickoIme && k.Lozinka == lozinka))
            {
                return TrenutniKorisnik = korisnici.First(k => k.KorisnickoIme == korisnickoIme && k.Lozinka == lozinka);
                
            }
            else {
                throw new Exception("Ne postoji korisnik");
            }
            
        }
    }
}
