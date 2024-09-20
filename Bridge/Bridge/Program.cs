using System;

namespace Bridge
{

    class Program
    {
        static void Main(string[] args)
        {
            int rad;

            Console.Write("Introduce el radio del circulo: ");
            rad = int.Parse(Console.ReadLine());
            // Crear implementaciones concretas
            DibujoImplementacion windows = new DibujoWindows();
            DibujoImplementacion linux = new DibujoLinux();

            // Crear círculos con diferentes implementaciones
            Forma circuloWindows = new Circulo(rad, windows);
            circuloWindows.Dibujar();

            Forma circuloLinux = new Circulo(rad, linux);
            circuloLinux.Dibujar();

            Console.ReadKey();
        }
    }
}
