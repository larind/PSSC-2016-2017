using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Nota
    {
        float valoare;
        public Nota(float valoare)
        {
            this.valoare = valoare;
        }

        public float Valoare
        {
            get
            {
                return valoare;
            }

            set
            {
                valoare = value;
            }
        }
    }
}
