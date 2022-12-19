using OOPs_Concepts.Abstraction;
using OOPs_Concepts.Encapsulation;
using OOPs_Concepts.Inheritance;
using OOPs_Concepts.Polymorphism;

namespace OOPs_Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to OOPs Concepts!");
            Console.WriteLine("Choose Option : \n1. Inheritance \n2. Abstraction \n3.Polymorphism - Method Ovreriding \n4. Polymorphism - Method Overloading \n5. Encapsulation\n");
            int option =Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
               case 1: //Inheritance
                      // Create a myCar object
                      Car myCar = new Car();

                      // Call the honk() method (From the Vehicle class) on the myCar object
                      myCar.honk();

                      // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
                      Console.WriteLine(myCar.brand);
                      Console.WriteLine(myCar.modelName);
                break;
                
                case 2: //Abstract
                      Pig myPig = new Pig(); // Create a Pig object
                      myPig.animalSound();  // Call the abstract method
                      myPig.sleep();  // Call the regular method
                break;
         
                case 3: //Polymorphism - Method Ovreriding
                    Animal1 animal1 = new Animal1();
                    animal1.Run();
                    Dog dog = new Dog();
                    dog.Run();
                    break;
                    
                case 4: //4.Polymorphism - Method Overloading
                    Addition addition = new Addition();
                    Console.WriteLine("Sum: " + addition.Add(2, 3));
                    Console.WriteLine("Sum: " + addition.Add(3, 5, 6));
                    Console.WriteLine("Sum: " + addition.Add(9, 3.12f, 32));
                    break;

                case 5: //Encapsulation
                    Account account = new Account();
                    Console.WriteLine("before usename:" + account.Name);
                    account.Name = "abcd";
                    Console.WriteLine("after username:" + account.Name);
                    Console.WriteLine("before password:" + account.Pwd);
                    account.Pwd = "Abc@123";
                    Console.WriteLine("after password:" + account.Pwd);
                    
                    break;

                default:
                     Console.WriteLine("Choose from given Option only");
                break;
            }

            
        }
    }
}