using System;
using System.Collections.Generic;
using System.Text;

namespace MyWalletProject02
{
    public abstract class Expense : EntityBase
    {
        public DateTime Timestamp { get; internal set; }
    }
}
