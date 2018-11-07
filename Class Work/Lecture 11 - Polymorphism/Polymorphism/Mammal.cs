using System;

namespace Polymorphism
{
    public abstract class Mammal 
    {
        protected string _name;

        public string Name
        {
            get
            {
                return _name;
            }
        }
        public Mammal(string name)
        {
            _name = name;
        }

        public virtual void MakeSomeNoise()
        {
            // everybody beeps, so it's shared behavior in the base class
            Console.Beep();
        }
    }
}
