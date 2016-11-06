using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    interface IDecanat
    {
       void atribuireMaterie(Profesor profesor, Disciplina disciplina); //metoda care asigneaza fiecarui profesor mmateria aferenta
        void calculMedie(ModExaminare modExaminare, Disciplina discipline, Student student, Nota note); //calcul medie student (in functie de tipul de evaluare a disciplinei)
        string situatieStudent(Student student, Disciplina discipline, Nota note); //metoda care genereaza situatie studentului si returneaza starea de promovat/nepromovat 
        void distribuireDiscipline(Student student, Disciplina disciplina, int numarCredite); //metoda care distribuie materiile fiecarui student, astfel incat numarul de credite sa fie 60

    }
}
