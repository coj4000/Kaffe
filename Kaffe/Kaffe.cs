using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffe
{
    public  abstract class Kaffe
    {
        public abstract int Pris();

        public virtual string Styrke()
        {
            return "stærk";
        }

       

        /// <summary>
        /// Hvor meget rabat man får fra kaffen
        /// </summary>
        public int Rabat { get; set; }

        public Kaffe()
        {
            this.Rabat = 0;
        }

        protected Kaffe(int rabat)
        {
            this.Rabat = rabat;
        }
    }
}
