using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Figure : IDessinable
    {
        protected double x, y, z;
        protected int r, v, b;

        public abstract double calculerSurface();
    }
}
