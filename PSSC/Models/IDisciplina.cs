using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    interface IDisciplina
    {
        
        void modificareNota(Disciplina discipline, Student student, Profesor profesor); //meoda care ii permite profesorului sa modifice notele dupa marire
        void calculMedie(ModExaminare modExaminare, Disciplina discipline, Student student, Nota note); //calcul medie student (in functie de tipul de evaluare a disciplinei)

    }
}
