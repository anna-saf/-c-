#region Автор
//Анна Сафонова
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача4
{
    class Program
    {
        static bool Authentication(string login, string pass)
        {
            if (login.Equals("root") && pass.Equals("GeekBrains"))
                return true;
            else return false;
        }
        static void Main(string[] args)
        {
            int AuthTry = 0;
            do
            {
                Console.WriteLine("Введите логин");
                string login = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                string pass = Console.ReadLine();
                bool LoginSuccess = Authentication(login, pass);
                if (LoginSuccess)
                {
                    Console.WriteLine("Вы вошли в систему");
                    break;
                }
                else
                {
                    if (AuthTry == 2)
                        Console.WriteLine("Количество попыток для входа исчерпано");
                    else Console.WriteLine("Логин и пароль неверные, попробуйте снова");
                    AuthTry++;
                }
            } while (AuthTry < 3);
            

            
        }
    }
}
