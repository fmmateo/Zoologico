using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoologico1
{
    class Utilidades
    {
        public static void CrearCarpetas()
        {
            string path = Directory.GetCurrentDirectory() + "\\";

            string[] Animales = new string[3] { "Herbivoro", "Carniboros", "Acuaticos" };


            for (int i = 0; i < 3; i++)
            {

                if (!Directory.Exists(path + Animales[i]))
                {
                    Directory.CreateDirectory(path + Animales[i] );
                }
            } 
        }

    }
}
