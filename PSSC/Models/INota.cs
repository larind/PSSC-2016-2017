using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    interface INota
    {
        void adaugareNota(Disciplina disciplina, Student student, Nota nota); //adaugare nota la o anumita disciplina
    }
}
