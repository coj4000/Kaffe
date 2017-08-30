using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffe
{
    public class CortadoKaffe : Kaffe, IMælk
    {
        public int MlMælk()
        {
            return 25;
        }

        /// <summary>
        /// Prisen på CortadoKaffe
        /// </summary>
        /// <returns></returns>
        public override int Pris()
        {
            return 25;
        }
    }
}
