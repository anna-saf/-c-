#region Автор
//Анна Сафонова
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача6
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime TimeStart = DateTime.Now;
            int countGoodNumber=0;
            int a;
            for (int i=1; i<1000000001; i++)
            {
                int sum = 0;
                int b = i;
                do
                {
                    a = b % 10;
                    b = b / 10;
                    sum += a;
                } while (b != 0);
                if (i % sum == 0)
                {
                    countGoodNumber++;
                }
            }
            DateTime TimeEnd = DateTime.Now;
            Console.WriteLine("Кол-во хороших чисел: " + countGoodNumber + ". Время работы программы: " + (TimeEnd - TimeStart).ToString());
        }
    }
}
