using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csDateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime();
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("Hour: "+ now.Hour);
            Console.WriteLine("Minutes: " + now.Minute);

            Console.WriteLine();

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine("ToLongDateString: " + now.ToLongDateString());
            Console.WriteLine("ToShortDateString: " + now.ToShortDateString());
            Console.WriteLine("ToLongTimeString: " + now.ToLongTimeString());
            Console.WriteLine("ToShortTimeString: " + now.ToShortTimeString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));

        }
    }
}
