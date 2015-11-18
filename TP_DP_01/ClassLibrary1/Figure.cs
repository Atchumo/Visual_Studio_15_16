using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Figure : IDessinable
    {
        private double z;
        private int b;
        private double x;
        private double y;
        private int r;
        private int v;

        protected double X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        protected double Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        protected double Z
        {
            get
            {
                return z;
            }

            set
            {
                z = value;
            }
        }

        protected int R
        {
            get
            {
                return r;
            }

            set
            {
                r = value;
            }
        }

        protected int V
        {
            get
            {
                return v;
            }

            set
            {
                v = value;
            }
        }

        protected int B
        {
            get
            {
                return b;
            }

            set
            {
                b = value;
            }
        }


        public abstract double calculerSurface();
    }
}
