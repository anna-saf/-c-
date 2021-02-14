using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача3
{

    

    class Program
    {
        public static bool PermutationWordsWithMethods(string str1, string str2)
        {
            var str1List = str1.ToLower().ToList<char>();
            str1List.Sort();
            str1=String.Join("", str1List);

            var str2List = str2.ToLower().ToList<char>();
            str2List.Sort();
            str2=String.Join("", str2List);

            if (str1.Equals(str2))
                return true;
            else return false;
        }
        public static bool PermutationWordsWithoutMethods(string str1, string str2)
        {
            Dictionary<char, int> dictionary1 = new Dictionary<char, int>();
            Dictionary<char, int> dictionary2 = new Dictionary<char, int>();
            foreach ( char symbol in str1)
            {
                if (!dictionary1.ContainsKey(symbol))
                {
                    dictionary1.Add(symbol, 1);
                }
                else dictionary1[symbol] = dictionary1[symbol] + 1;
            }
            foreach (char symbol in str2)
            {
                if (!dictionary2.ContainsKey(symbol))
                {
                    dictionary2.Add(symbol, 1);
                }
                else dictionary2[symbol] = dictionary2[symbol] + 1;
            }

            bool TrueSymbol = false;
            foreach(var a in dictionary1)
            {
                foreach(var b in dictionary2)
                {
                    if (a.Key==b.Key && a.Value == b.Value)
                    {
                        TrueSymbol = true;
                        break;
                    }
                }
                if (!TrueSymbol)
                {
                    return false;
                }
                else TrueSymbol = false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            string str1 = "bcad";
            string str2 = "abcd";
            if (!str1.Equals(str2))
            {
                Console.WriteLine(PermutationWordsWithMethods(str1, str2));
                Console.WriteLine(PermutationWordsWithoutMethods(str1, str2));
            } else Console.WriteLine("Строки равны");
        }
    }
}
