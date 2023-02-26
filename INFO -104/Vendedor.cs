using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFO__104
{
    internal class Vendedor
    {
        Dictionary<int, string> vendedor = new Dictionary<int, string>
        {
            {1,"aaa"},
            {2,"bbb"}
        };
        public Vendedor() { }

        public void ListadoVendedores()
        {
            foreach (KeyValuePair<int, string> item in vendedor)
            {
                Console.WriteLine("Vendedor " + item.Key + " es: " + item.Value);
            }
        }
        string codigovendedor(int ID)
        {
            if (vendedor.ContainsKey(ID))
            {
                return vendedor[ID];
            }
            else
            {
                return "Vendedor no encontrado";
            }
        }
    }
}

