using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class Forma
    {
        protected DibujoImplementacion implementacion;

        public Forma(DibujoImplementacion implementacion)
        {
            this.implementacion = implementacion;
        }

        public abstract void Dibujar();
    }
}
