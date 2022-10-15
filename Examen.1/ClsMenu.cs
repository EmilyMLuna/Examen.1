using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen._1
{
   public static class ClsMenu
    {  public static void menu()
        {
            Console.WriteLine("1- Articulos");
            Console.WriteLine("2- Reporte");
            Console.WriteLine("3- Salir");

           int input= Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.WriteLine("1- Agregar");
                    Console.WriteLine("2- Borrar");
                    Console.WriteLine("3- Consultar");
                    int inpu = Convert.ToInt32(Console.ReadLine());
                    switch (inpu)
                    {
                        case 1:
                            Articulos ar = new Articulos();
                            ar.agregar();
                            break;
                        case 2:
                            Articulos art = new Articulos();
                            art.eliminar();
                            break;
                        case 3:
                            Articulos arti = new Articulos();
                            arti.consultar();
                            break;
                        default:
                            break;
                    
                    }
                    break;
                case 2:
                    Console.WriteLine("Ingrese el codigo del articulo");

                    break;
                case 3:
                    Vendedor vend = new Vendedor();
                    vend.ListadoVendedores();

                    break;
                default:
                    break;
            
            
            
            }



            }
        }
    }
