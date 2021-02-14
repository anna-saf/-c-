#region Автор
//Анна Сафонова
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Задача1
{
    class Program
    {
        static bool NotRegularMethod(string login)
        {
            bool correct = true;

            if (login.Length >= 2 && login.Length <= 10 && !char.IsDigit(login[0]))
            {
                foreach (char symbol in login)
                {
                    if (!((symbol >= 'a' && symbol <= 'z') || (symbol >= 'A' && symbol <= 'Z') || char.IsDigit(symbol)))
                    {
                        correct = false;
                        break;
                    }
                }
            }
            else
            {
                correct = false;
            }
            return correct;
        }

        static bool RegularMethod(string login)
        {
            bool correct = true;            

            if (login.Length >= 2 && login.Length <= 10 && !char.IsDigit(login[0]))
            {
                var findsymbols = Regex.Matches(login, @"\d|[a-z,A-Z]");
                if (!(findsymbols.Count == login.Length))
                    correct = false;
            } else correct = false;

            return correct;
        }


        static void Main(string[] args)
        {

            Console.WriteLine("Введите логин");
            string login = Console.ReadLine();                        

            if (NotRegularMethod(login))
                Console.WriteLine("Корректный логин");
            else Console.WriteLine("Некорректный логин");

            if (RegularMethod(login))
                Console.WriteLine("Корректный логин");
            else Console.WriteLine("Некорректный логин");
        }
    }
}
