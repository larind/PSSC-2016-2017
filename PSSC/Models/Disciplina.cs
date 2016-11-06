using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    enum ModExaminare { examen, evaluare_pe_parcurs };

    class Disciplina
    {
        private string  nume;
        private Profesor titularDisciplina;
        private int numarCredite;
        private ModExaminare modExaminare ;


        public Disciplina(string nume, Profesor titularDisciplina, int numarCredite, ModExaminare modExaminare)
        {
            this.nume = nume;
            this.titularDisciplina = titularDisciplina;
            this.numarCredite = numarCredite;
            this.modExaminare = modExaminare;
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

        internal Profesor TitularDisciplina
        {
            get
            {
                return titularDisciplina;
            }

            set
            {
                titularDisciplina = value;
            }
        }

        public int NumarCredite
        {
            get
            {
                return numarCredite;
            }

            set
            {
                numarCredite = value;
            }
        }

        internal ModExaminare ModExaminare
        {
            get
            {
                return modExaminare;
            }

            set
            {
                modExaminare = value;
            }
        }

    }
}