using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class DibujoLinux : DibujoImplementacion
    {
        public void DibujarCirculo(int radio)
        {
            Console.WriteLine("Dibujando círculo en Linux con radio: " + radio);
        }
    }
}
