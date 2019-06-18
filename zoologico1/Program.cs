using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoologico1
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilidades.CrearCarpetas();

            while (true)
            {
                Console.Clear();
                menu.MenuPrincipal();
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        menu.MenuClasesAnimales();
                        break;
                    case "2":
                        Console.Clear();
                        menu.MenuClasesAnimales();
                        break;

                    default:
                        break;
                }

                Console.ReadKey();
            }
        }

       


            }
        }
    
