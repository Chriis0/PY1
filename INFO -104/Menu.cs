using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFO__104
{
    internal class Menu
    {

        public static void menu()
        {
            byte opcion = 0;

            do
            {
                Console.WriteLine("1- Articulos");
                Console.WriteLine("2- Facturacion");
                Console.WriteLine("3- Reporte");
                Console.WriteLine("4- Salir");
                Console.WriteLine("Digite una opcion");
                opcion = byte.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("1- Articulos");
                        break;
                    case 2:
                        Console.WriteLine("2- Facturación");
                        break;
                    case 3:
                        Console.WriteLine("3- Reporte");
                        break;
                    case 4:
                        Console.WriteLine("4- Salir");
                        break;
                    default:
                        break;
                }

            } while (opcion != 4);
        }

       public static void ArticuloSubMenu()

        {
            int opcionArticulos = 0;

            do
            {
                Console.WriteLine("1 - Agregar");
                Console.WriteLine("2 - Borrar");
                Console.WriteLine("3 - Consultar");

                switch (opcionArticulos)
                {

                    case 1:
                        Console.WriteLine("1- Agregar");
                        break;
                    case 2:
                        Console.WriteLine("2- Borrar");
                        break;
                    case 3:
                        Console.WriteLine("3- Consultar");
                        break;
                    case 4:
                        Console.WriteLine("4- Salir");
                        break;
                    default:
                        break;
                }
            } while (opcionArticulos != 4);
        }

        public static void Facturacion() 
        {
            
        }
    }
}

        
