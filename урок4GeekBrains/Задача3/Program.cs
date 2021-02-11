using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача3
{
    struct Account
    {
        public string login;
        public string password;

        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Account account;
            account.login = "root";
            account.password = "GeekBrains";

            StreamReader str = new StreamReader("data.txt");

            int authTry = 0;
            int counterRow = 0;

            while (!str.EndOfStream && authTry < 3)
            {
                string s = str.ReadLine();
                counterRow++;
                string[] logPass = new string[] { s.Split('-')[0].Trim(), s.Split('-')[1].Trim() };
                if (logPass[0].Equals(account.login) && logPass[1].Equals(account.password))
                {
                    Console.WriteLine("Вы вошли в систему");
                    break;
                }
                else
                {
                    if (authTry == 2)
                        Console.WriteLine("Количество попыток для входа исчерпано");
                    else Console.WriteLine("Логин и пароль из файла на строке "+counterRow.ToString()+" неверные");
                    authTry++;
                }
            }   

        }
    }
}
