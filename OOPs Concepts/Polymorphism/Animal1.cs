using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Concepts.Polymorphism
{
    internal class Animal1
    {
        public virtual void Run()
        {
            Console.WriteLine("Running");
        }
    }
    class Dog : Animal1
    {
        public override void Run()
        {
            Console.WriteLine("Running And Barking");
        }
    }
}
