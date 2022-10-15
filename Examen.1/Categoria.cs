using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Examen._1
{
  public class Categoria
    {
        public void promocion()
        {
            Console.WriteLine("Descuentos y promociones");
        }
        public void listadocategorias()
        {
            List<string> lista = new List<string>();
            lista.Add("Categoria 1");
            lista.Add("Categoria 2");
            lista.Add("Categoria 3");
        }
        }
    }
