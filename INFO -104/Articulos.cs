using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFO__104
{
    internal class Articulos
    {
        protected int[] codigo = new int[5];
        protected string[] nombre = new string[5];
        protected float[] precio = new float[5];

        public Articulos(int[] Codigo, string[] Nombre, float[] Precio)
        {
            this.codigo = Codigo;
            this.nombre = Nombre;
            this.precio = Precio;
        }

        public static void mercancia()
        {
            Articulos[] articulos = new Articulos[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese el codigo del producto");
                string codigo = Console.ReadLine();

                Console.Write("Ingrese el nombre del producto");
                string nombre = Console.ReadLine();

                Console.Write("Ingrese el precio del producto");
                float precio = float.Parse(Console.ReadLine());
            }
        }

        public Articulos() { }

        public int GetCodigo()
        {
            return codigo[0];
        }
        public void Setcodigo(int[] Codigo)
        {
            codigo = Codigo;
        }
        public string GetNombre()
        {
            return nombre[0];
        }
        public void SetNombre(string[] Nombre)
        {
            nombre = Nombre;
        }
        public float[] GetPrecio()
        {
            return precio;
        }
        public void SetPrecio(float[] Precio)
        {
            precio = Precio;
        }





    }
}
