using Newtonsoft.Json;
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
       static string path = Directory.GetCurrentDirectory() + "\\";

         static string[] Animales = new string[3] { "Herbivoro", "Carniboros", "Acuaticos" };

        public static void CrearCarpetas()
        {

            for (int i = 0; i < 3; i++)
            {

                if (!Directory.Exists(path + Animales[i]))
                {
                    Directory.CreateDirectory(path + Animales[i] );

                    

                }
                GuardarDatos(path + Animales [i]);

            }

        }

        public static void LeerCarpetas(string Clase)
        {
            switch (Clase)
            {
                case "1":
                    AnimalesHerbivoros animalesHerbivoros = new AnimalesHerbivoros();
                    animalesHerbivoros.Herbivoros(path + "Herbivoro" + "\\animal.json");

                    break;

                case "2":
                    AnimalesCarniboros animalesCarniboros = new AnimalesCarniboros();
                    animalesCarniboros.Carniboros(path + "Carniboros" + "\\animal.json");

                    break;

                case "3":
                    AnimalesAcuaticos animalesAcuaticos = new AnimalesAcuaticos();
                    animalesAcuaticos.Acuaticos (path + "Acuaticos" + "\\animal.json");
                    
                    break;

            }
        }

        public static void GuardarDatos(string Resivir )
        {
            Animales animal = new Animales();


            animal.Nombre = "Oveja";
            animal.Edad = 21;
            animal.Raza = "Dorset Horn";
            animal.Sexo = "macho";


            string json = JsonConvert.SerializeObject(animal);



            System.IO.File.WriteAllText(Resivir + "//animal.json", json);
        }
    }
}
