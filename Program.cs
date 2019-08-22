using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> colores =
                new List<string>();
            colores.Add("rojo");
            colores.Add("verde");
            colores.Add("naranja");
            colores.Add("amarillo");

            colores.RemoveAt(1);

            Console.WriteLine("Numero de elementos" + colores.Count);

            int indiceColor = 1;
            foreach(string color in colores)
            {
                Console.WriteLine(
                    "Elemento" + indiceColor.ToString() +
                    ": " + color);
                indiceColor++;
            }

            

            Console.Read();
        }
    }

}
