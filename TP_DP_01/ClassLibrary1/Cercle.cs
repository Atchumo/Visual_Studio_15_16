using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Cercle : Figure
    {
        private double rayon;

        public double Rayon
        {
            get
            {
                return rayon;
            }

            set
            {
                rayon = value;
            }
        }

        public Cercle(double p_rayon)
        {
            this.rayon = p_rayon;
        }

        public override double calculerSurface()
        {
            double surface = Math.PI * this.rayon * this.rayon;
            return surface;
        }
    }
}
