using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffe
{
   public class Latte : Kaffe, IMælk
    {
        public int MlMælk()
        {
            return 120;
        }

        public override int Pris()
        {
            return 40;
        }
    }
}
