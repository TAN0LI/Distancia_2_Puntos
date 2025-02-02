using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distancia_2_Puntos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pedir Variables
            System.Console.WriteLine("Ingresa X de la primera coordenada");
            double x1 = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingresa Y de la primera coordenada");
            double y1 = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingresa X de la segunda coordenada");
            double x2 = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingresa Y de la segunda coordenada");
            double y2 =double.Parse(Console.ReadLine());
            //Operaciones
            double d = Math.Sqrt((Math.Pow((x2 - x1), 2)) + (Math.Pow((y2 - y1), 2)));
            //Mostrar resultado
            System.Console.WriteLine("La distancia entre los puntos es: "+d);
        }
    }
}
