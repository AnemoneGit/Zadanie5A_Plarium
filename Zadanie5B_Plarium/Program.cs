using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie5B_Plarium
{
    class Wether 
    { 


    }


    class Program
    {

        


        static void Main(string[] args)
        {

            List<People> peoples = new List<People>();
            Dictionary<int, Region> regions = new Dictionary<int, Region>();
            Pogoda wether = new Pogoda();

            
            peoples.Add(new People("Евреи", "иврит"));
            peoples.Add(new People("Англичане", "английский"));

            regions.Add(0,new Country("Британия", 7000, peoples[1]));
            regions.Add(1,new City("Израиль", 10000, peoples[0]));
            regions.Add(2,new Oblast("Шотландия", 4000, peoples[1]));

           

            wether.Add( new Pogoda(regions[0], new DateTime(2021, 10, 15, 00, 00, 00), 3, "Дождь"));
            wether.Add( new Pogoda(regions[0], new DateTime(2021, 10, 13, 00, 00, 00), -3, "Снег"));
            wether.Add(new Pogoda(regions[0], new DateTime(2021, 10, 3, 00, 00, 00), 13, "Солнце"));

            wether.Add(new Pogoda(regions[1], new DateTime(2021, 10, 12, 00, 00, 00), -6, "Снег"));
            wether.Add(new Pogoda(regions[1], new DateTime(2021, 10, 13, 00, 00, 00), -3, "Снег"));
            wether.Add(new Pogoda(regions[1], new DateTime(2021, 10, 7, 00, 00, 00), 13, "Дождь"));

            wether.Add(new Pogoda(regions[2], new DateTime(2021, 10, 14, 00, 00, 00), 3, "Дождь"));
            wether.Add( new Pogoda(regions[2], new DateTime(2021, 10, 13, 00, 00, 00), 13, "Снег"));
            wether.Add( new Pogoda(regions[2], new DateTime(2021, 10, 15, 00, 00, 00), 13, "Солнце"));

            wether.GetPogoda(wether, regions[0]);
            System.Console.ReadKey(true);
            wether.GetData(wether, regions[1], "Снег", 0);
            System.Console.ReadKey(true);
            wether.GetPogoda(wether, "английский");
            System.Console.ReadKey(true);
            wether.GetTemp(wether, 6000, regions);
            System.Console.ReadKey(true);
        }
    }
}
