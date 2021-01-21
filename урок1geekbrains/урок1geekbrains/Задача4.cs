#region Автор
//Анна Сафонова
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace урок1geekbrains
{
    class Задача4
    {
        static void Main(string[] args)
        {
            #region Обмен значениями с использованием третьей переменной
            int n1 = 20;
            int n2 = 45;
            int n3 = n1;
            n1 = n2;
            n2 = n3;
            Console.WriteLine("Первая задача:");
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            #endregion

            #region Обмен значениями без использования третьей переменной
            n1 = 20;
            n2 = 45;
            n2 = n2 + n1;
            n1 = n2 - n1;
            n2 = n2 - n1;
            Console.WriteLine("Вторая задача:");
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            #endregion

        }
    }
}
