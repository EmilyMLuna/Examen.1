using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Examen._1
{
    public class Articulos
    {
        public void art()
        {
            string buscar = "";
            int[] Codigo = new int[5];
            String[] Nombre = new string[5];
            Double[] Precio = new double[5];

            for (int i = 0; i < 5; i++)
            {
                Codigo[i] = 1;
                Codigo[i] = 2;
                Codigo[i] = 3;
                Codigo[i] = 4;
                Codigo[i] = 5;
            }
            for (int i = 0; i < 5; i++)
            {
                Nombre[i] = "Cuaderno";
                Nombre[i] = "Lapiz";
                Nombre[i] = "Botella";
                Nombre[i] = "Lapicero";
                Nombre[i] = "Bolso";
            }
            for (int i = 0; i < 5; i++)
            {
                Precio[i] = 1200;
                Precio[i] = 2000;
                Precio[i] = 3000;
                Precio[i] = 4000;
                Precio[i] = 5000;
            }
        }
        public int Codigo
        { get; set; }
        public string Nombre
        { get; set; }
        public double Precio
        { get; set; }
        public Articulos()
        { }
        public Articulos(int cod, string nom, double pre)
        {
            this.Codigo = cod;
            this.Nombre = nom;
            this.Precio = pre;
        }
        public void agregar()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite el articulo que quiera agregar");
               

            }
        }
        public void consultar()
        {
            string buscar = "";
            Console.WriteLine("Digite el codigo del articulo");
            buscar = Console.ReadLine();
         
        }
        public void eliminar()
        {
        }
      
        }


}
