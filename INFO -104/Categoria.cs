using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFO__104
{
    internal class Categoria
    {
        public static void promocion() 
        {
            Console.WriteLine("Promociones y Descuentos");
        }

        public bool listas()
        {
            Console.WriteLine("Ingrese una catagoria");
            int Categoria = int.Parse(Console.ReadLine());

            switch (Categoria) 
            {
                case 1:
                case 2:
                case 3: return true;
                    default: return false;
            }
        }
    }
}
