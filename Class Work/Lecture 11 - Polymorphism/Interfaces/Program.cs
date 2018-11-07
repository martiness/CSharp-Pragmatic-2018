using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IInsurable dog = new Dog("Jamie");
            IInsurable cat = new Cat("Misha");
            IInsurable human = new Human("Stanislava");

            dog.Insure(100);
            cat.Insure(100);
            human.Insure(10000000);

            Mammal[] mammals = new Mammal[3];

            mammals[0] = (Mammal)dog;           
            mammals[1] = (Mammal)cat;        
            mammals[2] = (Mammal)human;

            for (int i = 0; i < mammals.Length; i++)
            {
                Console.WriteLine($"{mammals[i].Name} = {mammals[i].InsuredPrice}");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
