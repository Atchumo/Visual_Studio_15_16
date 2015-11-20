using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    interface IAllumable
    {
        Boolean getAllume();
        void setAllume(Boolean allume);
        void allumer();
        void eteindre();
    }
}
