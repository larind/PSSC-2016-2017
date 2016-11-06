using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Student:Persoana
    {
        private string numarMatricol;
        private string facultate;
        private int an;
        private List<Disciplina> discipline;
        private List<Nota> note;
        private float medie;


        public Student(string numarMatricol, string facultate, int an, float medie, string nume, string prenume, Sex sex, string CNP, string adresa) : base(nume, prenume, sex, CNP, adresa)
        {
            this.discipline = new List<Disciplina>();
            this.note = new List<Nota>();
            this.numarMatricol = numarMatricol;
            this.facultate = facultate;
            this.an = an;
            this.medie = medie;
        }
        public string NumarMatricol
        {
            get
            {
                return numarMatricol;
            }

            set
            {
                numarMatricol = value;
            }
        }

        public string Facultate
        {
            get
            {
                return facultate;
            }

            set
            {
                facultate = value;
            }
        }

        public int An
        {
            get
            {
                return an;
            }

            set
            {
                an = value;
            }
        }

        internal List<Disciplina> Discipline
        {
            get
            {
                return discipline;
            }

            set
            {
                discipline = value;
            }
        }

        public float Medie
        {
            get
            {
                return medie;
            }

            set
            {
                medie = value;
            }
        }

        internal List<Nota> Note
        {
            get
            {
                return note;
            }

            set
            {
                note = value;
            }
        }
    }
}
