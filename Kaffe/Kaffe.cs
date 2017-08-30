using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffe
{
    public  abstract class Kaffe
    {
        public abstract int pris();

        public virtual string styrke()
        {
            return "stærk";
        }
    }
}
