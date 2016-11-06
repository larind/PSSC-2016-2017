using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Decanat
    {
        private List<Disciplina> discipline;
        private List<Profesor> profesori;
        private List<Student> studenti;

        public Decanat()
        {
            this.discipline = new List<Disciplina>();
            this.profesori = new List<Profesor>();
            this.studenti = new List<Student>();
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

        internal List<Profesor> Profesori
        {
            get
            {
                return profesori;
            }

            set
            {
                profesori = value;
            }
        }

        internal List<Student> Studenti
        {
            get
            {
                return studenti;
            }

            set
            {
                studenti = value;
            }
        }
    }
}
