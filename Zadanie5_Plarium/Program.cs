using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie5_Plarium
{/*3. В массиве хранятся наименования некоторых объектов. 
  * Построить список C1, элементы которого содержат наименования и шифры данных объектов, причем элементы списка должны быть упорядочены по возрастанию шифров.
  * Затем «сжать» список C1, удаляя дублирующие наименования объектов.*/
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };//начальный массив данных
            ListC1 C1= new ListC1(s);
            C1.Add("Sun");//добавляем элемент
            System.Console.WriteLine("1 вывод");
            C1.GetInfo();//выводим первый раз

            C1.Distinct();//сжимаем
            System.Console.WriteLine("2 вывод");
            C1.GetInfo();//выводим второй раз после сжатия
            System.Console.ReadKey(true);

        }
    }
}
