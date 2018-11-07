using System;

namespace Inheritance
{
    public class Dog : Mammal
    {
        public Dog(string name) : base(name) { }

        public void Bark()
        {
            Console.WriteLine($"{_name} says: Bau");
        }
    }
}
