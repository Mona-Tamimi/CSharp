using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static int CountVowels (string m)
        {
            int count = 0;//a, e, i, o, u
            char[] stringArray = m.ToCharArray();
            for (int i = 0; i < stringArray.Length; i++)
            {
                if (stringArray[i] == 'a' || stringArray[i] == 'e' || stringArray[i] == 'i' || stringArray[i] == 'o' || stringArray[i] == 'u')
                {
                    count++;
                }
            }

            return count;
        }
        static int CountVowels1(string m)
        {
            int count = 0;
            string vowels = "aeiou";
            foreach (char c in m)
            {
                if (vowels.Contains(c))
                {
                    count++;
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
           Console.WriteLine(CountVowels("hello"));
           Console.WriteLine(CountVowels1("hello"));
        }
    }
}
