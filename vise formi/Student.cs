using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vise_formi
{
    internal class Student
    {
        string ime;
        string prezime;
        string brojIndexa;
        DateTime datumRodjenja;
        string smjer;

        public Student(string ime, string prezime, string brojIndexa, DateTime datumRodjenja, string smjer)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.BrojIndexa = brojIndexa;
            this.DatumRodjenja = datumRodjenja;
            this.Smjer = smjer;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string BrojIndexa { get => brojIndexa; set => brojIndexa = value; }
        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
        public string Smjer { get => smjer; set => smjer = value; }

        public override string ToString()
        {
            return  Ime + "\t " + Prezime + "\t" + BrojIndexa + "\t" + Smjer + "\t\t" + DatumRodjenja;
        }

        public Student()
        {

        }
        public Student(string i, string p, string bI, string s, DateTime dR)
        {
            Ime = i;
            Prezime = p;
            BrojIndexa = bI;
            Smjer = s;
            DatumRodjenja = dR;
        }
    }
}
