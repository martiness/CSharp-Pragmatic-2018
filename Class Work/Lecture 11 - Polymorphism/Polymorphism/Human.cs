using System;

namespace Polymorphism
{
    public class Human : Mammal
    {
        public Human(string name) : base(name) { }

        public void Speak(string msg)
        {
            Console.WriteLine($"{_name} says: { msg }");
        }

        public override void MakeSomeNoise()
        {
            // call the method from the base class
            base.MakeSomeNoise();

            Speak("Hello");
            
        }
    }
}
