using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFO__104
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            Menu.menu();
            Menu.ArticuloSubMenu();

            Articulos articulos = new Articulos ();
            Articulos.mercancia();

            Categoria categoria= new Categoria ();
            Categoria1 categoria1 = new Categoria1();
            Categoria2 categoria2 = new Categoria2();
            Categoria3 categoria3 = new Categoria3();

            Categoria.promocion();
            

            if(categoria.listas())
            {
                Console.WriteLine("La categoria existe");
            }
            else
            {
                Console.WriteLine("La No categoria existe");
            }
            while (true) ;


            Console.Clear();
            Console.Read();
        }
    }
}
