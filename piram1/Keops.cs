using System;

namespace piram1
{
    internal class Keops
    {
        public void Secuencia()
        {
            long decas = 1;
            int esps = 18;
            Console.SetCursorPosition(esps, 0);
            Console.WriteLine("NEO -mach");
            Console.SetCursorPosition(esps, 1);
            Console.WriteLine("---------");
            for (int i = 2; i <= 10; i++)
            {
                Console.SetCursorPosition(esps, i);
                long operacion = decas * decas;
                Console.WriteLine("{0} x {0} = {1}", decas, operacion);
                decas = decas * 10 + 1;
                esps -= 2;
            }
            Console.ReadKey();xzzggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggg        }

    }
}
