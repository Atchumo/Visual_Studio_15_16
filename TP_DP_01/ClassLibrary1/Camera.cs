using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Camera : IAllumable, IPositionnable
    {
        private double x, y, z;
        private Boolean allume;

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
        public Boolean getAllume()
        {
            return allume;
        }
        public void setAllume(Boolean allume)
        {
            this.allume = allume;
        }

        public void allumer()
        {
            this.allume = true;
        }
        public void eteindre()
        {
            this.allume = false;
        }
        public void deplacer(double new_x, double new_y, double new_z)
        {
            this.x = this.x + new_x;
            this.y = this.y + new_z;
            this.z = this.z + new_z;
        }
    }
}
