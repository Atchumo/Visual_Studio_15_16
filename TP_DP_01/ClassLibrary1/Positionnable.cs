using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    interface IPositionnable
    {
        double getX();
        void setX(double x);
        double getY();
        void setY(double y);
        double getZ();
        void setZ(double z);

        void deplacer(double new_x, double new_y, double new_z);
    }
}
