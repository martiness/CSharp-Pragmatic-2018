using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // can be done because is not abstract!!!
            Mammal m = new Mammal("Rex");
            
            Dog dog = new Dog("Jamie");
            dog.Bark();

            // we cannot access protected members
            // dog._name = "Joro";

            Cat cat = new Cat("Misha");
            cat.Meaw();

            Human human = new Human("Stanislava");
            human.Speak("Hello");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
