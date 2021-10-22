using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie5_Plarium
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            ListC1 C1= new ListC1(s);
            C1.Add("Sun");
            System.Console.WriteLine("1 вывод");
            C1.GetInfo();

            C1.Distinct();
            System.Console.WriteLine("2 вывод");
            C1.GetInfo();
            System.Console.ReadKey(true);

        }
    }
}
