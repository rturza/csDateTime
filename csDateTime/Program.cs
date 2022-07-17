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

        }
    }
}
