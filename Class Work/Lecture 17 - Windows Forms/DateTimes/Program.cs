using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            DateTime dtUtc = DateTime.UtcNow;
            DateTime dtCustom = new DateTime(2018, 12, 5, 22, 00, 00, DateTimeKind.Local);


            DateTimeOffset dto = DateTimeOffset.Now;
            DateTimeOffset dtoUtc = DateTimeOffset.UtcNow;
            DateTimeOffset dtoCustom = new DateTimeOffset(2018, 12, 5, 22, 00, 00, TimeSpan.FromHours(2));

            Console.WriteLine(dt.ToString(new CultureInfo("bg-BG")));

            TimeSpan timespan = dtCustom - dt;

            Console.WriteLine($"Total time until the end of the lecture:  { timespan.TotalSeconds} sec");


            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
