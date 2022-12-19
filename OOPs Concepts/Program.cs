using OOPs_Concepts.Inheritance;

namespace OOPs_Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to OOPs Concepts!");
            Console.WriteLine("Choose Option : \n1. Inheritance");
            int option =Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1: // Create a myCar object
                    Car myCar = new Car();

                    // Call the honk() method (From the Vehicle class) on the myCar object
                    myCar.honk();

                    // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
                    Console.WriteLine(myCar.brand);
                    Console.WriteLine(myCar.modelName);
                break;

                default:
                    Console.WriteLine("Choose from given Option only");
                break;
            }

            
        }
    }
}