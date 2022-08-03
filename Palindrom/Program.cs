using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    internal class Program
    {
        static bool Palindrom(string word,bool ignoreCase=true)
        {
            if (ignoreCase)
            {
                word = word.ToLowerInvariant();
            }
            for (int first = 0, last = word.Length-1; first< last; ++first,--last)
            {
                if (word[first] != word[last])
                {
                    return false;
                }
            }
            return true;
        }
       
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedite jelaemoe slovo");
        string word = Console.ReadLine();
       bool result=   Palindrom(word);
            Console.WriteLine(result);
       

        }
    }
}
