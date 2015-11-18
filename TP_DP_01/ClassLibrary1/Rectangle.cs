using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Rectangle : Figure
    {
        private double largeur;
        private double longueur;

        public double Largeur
        {
            get
            {
                return largeur;
            }

            set
            {
                largeur = value;
            }
        }

        public double Longueur
        {
            get
            {
                return longueur;
            }

            set
            {
                longueur = value;
            }
        }

        public Rectangle(double p_longueur, double p_largeur)
        {
            this.largeur = p_largeur;
            this.longueur = p_longueur;
        }

        public override double calculerSurface()
        {
            double surface = this.largeur * this.longueur;
            return surface;
        }
    }
}
