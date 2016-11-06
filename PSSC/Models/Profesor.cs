using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   
    class Profesor:Persoana
    {
        private List<Disciplina> discipline;

        public Profesor(string nume, string prenume, Sex sex, string CNP, string adresa):base(nume, prenume, sex, CNP, adresa)
        {
            this.discipline = new List<Disciplina>();
        }
    }
}
