using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    enum Sex { masculin, feminin }
    class Persoana
    {
        private string nume;
        private string prenume;
        private Sex sex;
        private string CNP;
        private string adresa;

        public Persoana(string nume, string prenume, Sex sex, string CNP, string adresa)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.sex = sex;
            this.CNP = CNP;
            this.adresa = adresa;
        }
        public string Nume
        {
            get
            {
                return nume;
            }

            set
            {
                nume = value;
            }
        }

        public string Prenume
        {
            get
            {
                return prenume;
            }

            set
            {
                prenume = value;
            }
        }

        internal Sex Sex
        {
            get
            {
                return sex;
            }

            set
            {
                sex = value;
            }
        }

        public string CNP1
        {
            get
            {
                return CNP;
            }

            set
            {
                CNP = value;
            }
        }

        public string Adresa
        {
            get
            {
                return adresa;
            }

            set
            {
                adresa = value;
            }
        }
    }
}
