using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie5_Plarium
{
    class ListC1 // класс реализующий список
    {
        private SortedList<string, string> UserInfo = new SortedList<string, string>();// список типа SortedList
        private int i = 0;
      
       public ListC1(string[] s)
        {
            foreach(string str in s)
            {
                UserInfo.Add($"{str[0]}{i}{str[str.Length-1]}", str);
                i++;
            }
        }
        public void Add(string s)//метод добавления новых элементов
        {
            UserInfo.Add($"{s[0]}{i}{s[s.Length-1]}", s);
            i++;
        }
        public void Add(string[] s)//метод добавления массива новых элементов
        {
            foreach (string str in s)
            {
                UserInfo.Add($"{str[0]}{i}{str[str.Length-1]}", str);
                i++;
            }
        }
        public void Distinct()//метод реализующий сжатие
        {
            // Коллекция ключей
            List<string> ds = new List<string>();
            ICollection<string> keys = UserInfo.Keys;
          
            // Теперь используем ключи, для получения значений
            foreach (string s in keys)
            {
                ds.Add(UserInfo[s]);

            }
            IEnumerable<string> distinct = ds.Distinct();
            UserInfo.Clear();
            i = 0;
            foreach (string str in distinct)
            {
                UserInfo.Add($"{str[0]}{i}{str[str.Length-1]}", str);
                i++;
            }
        }
        public void GetInfo()//вывод коллекции
        {
            // Коллекция ключей
            ICollection<string> keys = UserInfo.Keys;

            // Теперь используем ключи, для получения значений
            foreach (string s in keys)
                Console.WriteLine($"Шифр: {s}, Наименование: {UserInfo[s]}");
        }
    }
}
