using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Desk myDesk = new Desk();

            Console.WriteLine(myDesk.Size);

            Console.WriteLine(myDesk._myPrivateSerialNumber);

            Console.ReadKey();
        }
    }
}
