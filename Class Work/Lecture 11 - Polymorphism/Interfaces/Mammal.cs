using System;

namespace Interfaces
{
    public abstract class Mammal : IInsurable
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

        public decimal InsuredPrice { get; set; }

        public void Insure(decimal insuredPrice)
        {
            InsuredPrice = insuredPrice;
        }
    }
}
