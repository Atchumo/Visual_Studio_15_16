using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Lumiere : IAllumable
    {
        private Boolean allume;

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
    }
}
