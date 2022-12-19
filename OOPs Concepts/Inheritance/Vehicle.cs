using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Concepts.Inheritance
{
    internal class Vehicle            // Parent Class
    {
        public string brand = "Kia";  // Vehicle Brand
        public void honk()             // Vehicle method 
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }

    class Car : Vehicle  // Derived Class (Child Class)
    {
        public string modelName = "Seltos";  // Car field
    }
}
