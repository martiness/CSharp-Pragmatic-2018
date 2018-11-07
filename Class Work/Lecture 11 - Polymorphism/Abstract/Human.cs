using System;

namespace Abstract
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
