#region Автор
//Анна Сафонова
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача1
{
    
    class Program
    {
        static void MinNumMethod(double a, double b, double c)
        {
            if (a < b)
                if (a < c)
                    Console.WriteLine("Min = " + a.ToString());
                else Console.WriteLine("Min = " + c.ToString());
            else if (b < c)            
                Console.WriteLine("Min = " + b.ToString());
            else Console.WriteLine("Min = " + c.ToString());
        }
        static void Main(string[] args)
        {
            MinNumMethod(1,3,5);
        }
    }
}
