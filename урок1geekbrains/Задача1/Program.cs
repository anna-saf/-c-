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
        static void Main(string[] args)
        {
            Console.WriteLine("Ваше имя:");
            var Name = Console.ReadLine();
            Console.WriteLine("Ваша фамилия:");
            var LastName = Console.ReadLine();
            Console.WriteLine("Ваш возраст:");
            var Age = Console.ReadLine();
            Console.WriteLine("Ваш рост:");
            var Height = Console.ReadLine();
            Console.WriteLine("Ваш вес:");
            var Massa = Console.ReadLine();

            Console.WriteLine(Name + ", " + LastName + ", " + Age + ", " + Height + ", " + Massa);
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", Name, LastName, Age, Height, Massa);
            Console.WriteLine($"{Name}, {LastName}, {Age}, {Height}, {Massa}");

        }
    }
}
