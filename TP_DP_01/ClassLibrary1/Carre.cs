using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Carre : Rectangle
    {
        private double cote;

        public double Cote
        {
            get
            {
                return cote;
            }

            set
            {
                cote = value;
            }
        }

        public Carre(double cote) : base(cote, cote) { }
    }
}
