#region Автор
//Анна Сафонова
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача3
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum =0;
            double a;
            do {
                a = Convert.ToDouble(Console.ReadLine());
                if ((a % 2 != 0)&&(a>0))
                {
                    sum += a;
                }
            } while (a != 0);
            Console.WriteLine("Sum = "+sum.ToString());
        }
    }
}
