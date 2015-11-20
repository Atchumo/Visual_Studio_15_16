using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Figure : Dessin, IDessinable
    {
        protected double x,y,z;
        protected int r,v,b;

        public double getX()
        {
            return x;
        }
        public void setX(double x)
        {
            this.x = x;
        }
        public double getY()
        {
            return y;
        }
        public void setY(double y)
        {
            this.y = y;
        }
        public double getZ()
        {
            return z;
        }
        public void setZ(double z)
        {
            this.z = z;
        }
        public int getR()
        {
            return r;
        }
        public void setR(int r)
        {
            this.r = r;
        }
        public int getV()
        {
            return v;
        }
        public void setV(int v)
        {
            this.v = v;
        }
        public int getB()
        {
            return b;
        }
        public void setB(int b)
        {
            this.b = b;
        }

        public abstract double calculerSurface();
        public void deplacer(double new_x, double new_y, double new_z)
        {
            this.x = this.x + new_x;
            this.y = this.y + new_z;
            this.z = this.z + new_z;
        }
        public int compareTo(Figure o)
        {
            // TODO Auto-generated method stub
            if (this.calculerSurface() > o.calculerSurface())
            { //This > o
                return 1;
            }
            else if (this.calculerSurface() < o.calculerSurface())
            { //This < o
                return -1;
            }
            else
            { // This = o
                return 0;
            }

        }
    }
}
