using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Задача2
{
    class Message
    {
        public static void FindWordInMessage(int length, string mes)
        {
            var words = GetStrForSplit(mes).Split(' ').ToList().FindAll(x=>x.Length!=0);
            foreach (string word in words)
            {
                if(word.Length<= length)
                {
                    Console.Write(word + " ");
                }
            }
            Console.WriteLine();
        }

        public static string DelWord(char symbol, string mes)
        {
            var words = GetStrForSplit(mes).Split(' ').ToList().FindAll(x => x.Length != 0);
            foreach (string word in words)
            {
                if (word[word.Length-1] == symbol)
                {
                    mes = Regex.Replace(mes, @"(?<=[^a-z,A-Z,0-9])"+ word + @"(?=[^a-z,A-Z,0-9])","");
                }
            }
            return mes;
        }

        public static string MaxWord(string mes)
        {
            string maxWord = "";
            var words = GetStrForSplit(mes).Split(' ').ToList().FindAll(x => x.Length != 0);
            foreach (string word in words)
            {
                if (word.Length > maxWord.Length)
                {
                    maxWord = word;
                }
            }
            return maxWord;
        }

        public static string MaxWordStr(string mes)
        {
            StringBuilder returnmes = new StringBuilder();
            string maxWord = MaxWord(mes);
            var words = GetStrForSplit(mes).Split(' ').ToList().FindAll(x => x.Length != 0);
            foreach (string word in words)
            {
                if (word.Length == maxWord.Length)
                {
                    returnmes.Append(word).Append(" ");
                }
            }
            return returnmes.ToString();
        }

        public static string GetStrForSplit(string message)
        {
            return Regex.Replace(Regex.Replace(message, @"\n|\r|\||\,|\.|\;|\:|""|\]|\[|\}|\{|\\|\/|\?|\!|'|\$|\@|\%|\#|\№|\^|\*|\(|\)|\=|\+|\-|_|\>|\<", " "), @" {1,100}", " ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader str = new StreamReader("data.txt");
            string message = str.ReadToEnd();
            Message.FindWordInMessage(10, message);
            Console.WriteLine();
            Console.WriteLine(Message.MaxWord(message));
            Console.WriteLine();
            Console.WriteLine(Message.MaxWordStr(message));
            Console.WriteLine();
            Console.WriteLine(Message.DelWord('s', message));
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
