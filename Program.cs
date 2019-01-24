using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2FelipeLM
{
    class Program
    {
        static void Main(string[] args)
        {
            double recto = 90;
            
            
            

            Console.WriteLine("Digite el lado Y");
           double y = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el lado Z");
            double z = double.Parse(Console.ReadLine());

            double t = Math.Sqrt((y * y) + (z * z));

            double c = (Math.Acos(y / t)*180)/Math.PI;
            double a = (Math.Acos(z / t)*180)/Math.PI;

            Console.WriteLine("El angulo C es" + c);
            Console.WriteLine("El angulo A es" + a);
            Console.WriteLine("La hipotenusa tiene una longitud de" + t);

        }
    }
}
