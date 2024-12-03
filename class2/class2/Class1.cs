using System;
using System.Collections.Generic;
using System.Text;

namespace class2
{
    public class Car
    {
        public string Model;
        public string color;
        public int year;

        //methods(behaviour)
        public void Start()
        {
            Console.WriteLine("car is starting....");

        }

        public void Accelerate()
        {
            Console.WriteLine("car is accelerating........");
        }
        public void Brake()
        {
            Console.WriteLine("car is braking........");
        }
    }
}
