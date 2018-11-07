using System;

namespace Interfaces
{
    public class Cat : Mammal
    {
        public Cat(string name) : base(name) { }

        public void Meaw()
        {
            Console.WriteLine($"{_name} says: Meaw");
        }
    }
}
