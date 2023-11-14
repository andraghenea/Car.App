using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Car.App
{
    internal class Program
    {
        string color = "red";
        
        static void Main(string[] args)
        {
            car Ford = new car("Mustang", "white", 2021, 100);
            car Opel = new car("Astra", "blue", 2020, 100);
            car Volvo = new car("XC-90");
            Ford.name = "Mustang";
            Ford.year = 2021;
            Ford.color = "white";
            Ford.maxSpeed = 100;
            Ford.fullThrottle();

            Console.WriteLine(Ford.name);
            Console.WriteLine(Ford.year);
            Console.WriteLine(Ford.color);

            Opel.name = "Astra";
            Opel.year = 2020;
            Opel.color = "blue";
            Opel.maxSpeed = 120;
            Opel.fullThrottle();

            Console.WriteLine(Opel.name);
            Console.WriteLine(Opel.year);
            Console.WriteLine(Opel.color);

            Console.ReadKey();
        }
       
    }
}
