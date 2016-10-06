using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    enum Verificare { examen, evaluare_pe_parcurs };

    [Flags]
    enum Componenta { curs, laborator, seminar, proiect };

    class Disciplina
    {
        private string nume_disciplina;
        private string titular_disciplina;
        private int numar_credite;
        private Verificare tip_verificare;
        private Componenta componente;

    }
}