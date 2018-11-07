using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Mammal dog = new Dog("Jamie");
            Mammal cat = new Cat("Misha");
            Mammal human = new Human("Stanislava");

            Mammal[] mammals = new Mammal[3];

            mammals[0] = dog;           
            mammals[1] = cat;        
            mammals[2] = human;

            for (int i = 0; i < mammals.Length; i++)
            {
                Console.WriteLine($"{mammals[i].Name}");
                mammals[i].MakeSomeNoise();
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
