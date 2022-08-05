using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prostoe_chislo
{
    internal class Program
    {
        static int SumOfElements(int[]myArray)
        {
            int SumOfElements = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                SumOfElements += myArray[i];
            }
            if (SumOfElements%2 !=0)
            {
                return SumOfElements;
            }
            return 0;
        }
      
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedite massiv");
            int myMassiv=int.Parse(Console.ReadLine());
            int[] myArray = new int[myMassiv];
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"Vvedite element pod indexom {i}: ");
                myArray[i] = int.Parse(Console.ReadLine());
            }
            int result = SumOfElements(myArray);
            Console.WriteLine(result);
        }
    }
}
