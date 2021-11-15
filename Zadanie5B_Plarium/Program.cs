using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie5B_Plarium
{
    /*В сущностях (типах) хранится информация о погоде в различных регионах.
 Для погоды необходимо хранить:
 — регион;
 — дату;
 — температуру;
 — осадки.
 Для регионов необходимо хранить:
 — название;
 — площадь;
 — тип жителей.
 Для типов жителей необходимо хранить:
 — название;
 — язык общения.
 Вывести сведения о погоде в заданном регионе.
 Вывести даты, когда в заданном регионе шел снег и температура была ниже заданной отрицательной.
 Вывести информацию о погоде за прошедшую неделю в регионах, жители которых общаются на заданном языке.
 Вывести среднюю температуру за прошедшую неделю в регионах с площадью больше заданной.
 */

    class Program
    {

        


        static void Main(string[] args)
        {
            //листы в которых храниться информацыя о необходимых классах
            List<People> peoples = new List<People>();
            Dictionary<int, Region> regions = new Dictionary<int, Region>();//используем коллекцию типа Dictionary
            Pogoda wether = new Pogoda(); 
            //чтоб не задавать каждый раз в ручную
            #region Начальные значения
            peoples.Add(new People("Евреи", "иврит"));
            peoples.Add(new People("Англичане", "английский"));

            regions.Add(0,new Country("Британия", 7000, peoples[1]));
            regions.Add(1,new City("Израиль", 10000, peoples[0]));
            regions.Add(2,new Oblast("Шотландия", 4000, peoples[1]));


            wether.Add( new Pogoda(regions[0], new DateTime(2021, 10, 21, 00, 00, 00), 3, "Дождь"));
            wether.Add( new Pogoda(regions[0], new DateTime(2021, 10, 26, 00, 00, 00), -3, "Снег"));
            wether.Add(new Pogoda(regions[0], new DateTime(2021, 10, 23, 00, 00, 00), 13, "Солнце"));

            wether.Add(new Pogoda(regions[1], new DateTime(2021, 10, 2, 00, 00, 00), -6, "Снег"));
            wether.Add(new Pogoda(regions[1], new DateTime(2021, 10, 25, 00, 00, 00), -3, "Снег"));
            wether.Add(new Pogoda(regions[1], new DateTime(2021, 10, 30, 00, 00, 00), 13, "Дождь"));

            wether.Add(new Pogoda(regions[2], new DateTime(2021, 10, 19, 00, 00, 00), 3, "Дождь"));
            wether.Add( new Pogoda(regions[2], new DateTime(2021, 10, 25, 00, 00, 00), 13, "Снег"));
            wether.Add( new Pogoda(regions[2], new DateTime(2021, 10, 30, 00, 00, 00), 13, "Солнце"));
            #endregion
            wether.GetPogoda(wether, regions[0]);//Вывести сведения о погоде в заданном регионе.
            System.Console.ReadKey(true);
            wether.GetData(wether, regions[1], "Снег", 0);// Вывести даты, когда в заданном регионе шел снег и температура была ниже заданной отрицательной.
            System.Console.ReadKey(true);
            wether.GetPogoda(wether, "английский");//Вывести информацию о погоде за прошедшую неделю в регионах, жители которых общаются на заданном языке.
            System.Console.ReadKey(true);
            wether.GetTemp(wether, 6000, regions);//Вывести среднюю температуру за прошедшую неделю в регионах с площадью больше заданной.
            System.Console.ReadKey(true);
        }
    }
}
