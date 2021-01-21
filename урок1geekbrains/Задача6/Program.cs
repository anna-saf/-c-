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
    class Person
    {
        string Name;
        int num;
        public Person(int num, string name)
        {
            Name = name;
            this.num = num;
        }
        public void Result()
        {
            switch (num)
            {
                case 1:
                    Console.ForegroundColor = ColorMessage("red");
                    Console.WriteLine("Вы решили слишком мало");
                    break;
                case 2:
                    Console.ForegroundColor = ColorMessage("red");
                    Console.WriteLine("Вы решили слишком мало");
                    break;
                case 3:
                    Console.ForegroundColor = ColorMessage("orange");
                    Console.WriteLine("Вы решили достаточно");
                    break;
                case 4:
                    Console.ForegroundColor = ColorMessage("yellow");
                    Console.WriteLine("Вы решили на одну задачу больше, чем минимально необходимо");
                    break;
                case 5:
                    Console.ForegroundColor = ColorMessage("darkgreen");
                    Console.WriteLine("Вы решили на 2 задачи больше, чем минимально необходимо");
                    break;
                case 6:
                    Console.ForegroundColor = ColorMessage("green");
                    Console.WriteLine("Вы решили все задачи");
                    break;
            }
        }
        public ConsoleColor ColorMessage(string color)
        {
            switch (color)
            {
                case "orange":
                    return ConsoleColor.DarkYellow;
                case "yellow":
                    return ConsoleColor.Yellow;
                case "darkgreen":
                    return ConsoleColor.DarkGreen;
                case "green":
                    return ConsoleColor.Green;
                default:
                    return ConsoleColor.Red;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Введите имя.");
        string Name = Console.ReadLine();
        Console.WriteLine("Введите количество решенных задач (от 1 до 6).");
        int num = Convert.ToInt32(Console.ReadLine());
        while(num<1 || num > 6)
            {
                Console.WriteLine("Введены неверные данные. Введите количество решенных задач от 1 до 6.");
                num = Convert.ToInt32(Console.ReadLine());
            }
            Person person = new Person(num, Name);
            person.Result();

        }
    }
}
