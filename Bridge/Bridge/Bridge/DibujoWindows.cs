using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class DibujoWindows : DibujoImplementacion
    {
        public void DibujarCirculo(int radio)
        {
            Console.WriteLine("Dibujando círculo en Windows con radio: " + radio);
        }
    }
}
