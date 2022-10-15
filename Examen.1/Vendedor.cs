using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen._1
{
    internal class Vendedor
    {
        Dictionary<int, string> vend = new Dictionary<int, string>() {
          {1, "vendedor1"},
          {2, "vendedor2"},

        };
        public Vendedor() { }
        public void ListadoVendedores()
        {
            foreach (var vender in vend)
            {
                Console.WriteLine($"El codigo del vendedor{vender.Key} el vendedor es {vender.Value} ");
            }
        } 
        public string(vend int Value)
            { 
            
            }
    }

 }

