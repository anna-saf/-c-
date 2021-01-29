#region Автор
//Анна Сафонова
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача7
{
    class Program
    {
        static int Sum=0;
        static void Recursion(int a, int b)
        {
            if (a <= b)
            {
                Console.WriteLine(a);
                Sum += a;
                Recursion(a + 1, b);
            }
        }

        static void Main(string[] args)
        {
            Recursion(4, 7);
            Console.WriteLine("Сумма чисел равна "+Sum);
        }
    }
}
