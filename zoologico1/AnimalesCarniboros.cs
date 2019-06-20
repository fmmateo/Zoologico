using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoologico1
{
    public class AnimalesCarniboros
    {

        public void Carniboros( string ruta)
        {
            using (StreamReader jsonStream = File.OpenText(ruta))
            {
                var json = jsonStream.ReadToEnd();
                Animales animales = JsonConvert.DeserializeObject<Animales>(json);

                Console.Clear();
                Console.WriteLine("CARNIBOROS");

                Console.WriteLine(" ");
                Console.WriteLine("El Nombre Es: " + animales.Nombre);
                Console.WriteLine("La Edad Es:" + animales.Edad);
                Console.WriteLine("El Sexo Es:" + animales.Sexo);
                Console.WriteLine("La Raza Es:" + animales.Raza);

            }
        }
    }
}
