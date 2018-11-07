using System;

namespace Interfaces
{
    public interface IInsurable
    {
        decimal InsuredPrice { get; set; }

        void Insure(decimal insuredPrice);
    }
}
