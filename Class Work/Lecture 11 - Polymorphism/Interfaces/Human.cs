using System;

namespace Interfaces
{
    public class Human : Mammal
    {
        public Human(string name) : base(name) { }

        public void Speak(string msg)
        {
            Console.WriteLine($"{_name} says: { msg }");
        }
    }
}
