using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Circulo : Forma
    {
        private int radio;

        public Circulo(int radio, DibujoImplementacion implementacion) : base(implementacion)
        {
            this.radio = radio;
        }

        public override void Dibujar()
        {
            implementacion.DibujarCirculo(radio);
        }
    }
}
