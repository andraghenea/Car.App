using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Car.App
{
    internal class car
    {
        public string color;
        public string name;
        public int maxSpeed;
        public int year;

        public car(string nameName, string colorName, int yearValue, int maxSpeedValue)
        {
            name = nameName;
            maxSpeed = maxSpeedValue;
            year = yearValue;
            color = colorName;
        }
        public car(string nameName)
        {
            name = nameName;
        }
        public void fullThrottle()
        {
            Console.WriteLine(name + "is going at the speed of" + maxSpeed);
        }
    }
}