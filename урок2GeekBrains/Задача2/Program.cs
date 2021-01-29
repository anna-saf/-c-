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
        static void LengthNum(double a)
        {
            if (a.ToString().Contains(","))
                Console.WriteLine(a.ToString().Replace(",", "").Length);
            else Console.WriteLine(a.ToString().Length);
        }
        static void Main(string[] args)
        {
            LengthNum(12345.457);
            
        }
    }
}
