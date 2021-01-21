#region Автор
//Анна Сафонова
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите вес");            
            var m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите рост");
            var h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(m / (h * h));
        }
    }
}
