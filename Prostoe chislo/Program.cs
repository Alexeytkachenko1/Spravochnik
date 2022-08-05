using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prostoe_chislo
{
    internal class Program
    {
       
        static void SimpleNumber(double divider, double sumOfElement)
        {
            bool simpleNumber = ((sumOfElement / divider != divider)&& (sumOfElement % 2 != 0)) ? true : false;
            Console.WriteLine("Простое число: " + simpleNumber);
        }
        static void SimpleNumberException(double divider, double sumOfElement)
        {
            if ((sumOfElement / divider != divider) && (sumOfElement % 2 != 0))
            {
                Console.WriteLine("Простое число: " + true);
            }
            else
            {
                Console.WriteLine("Простое число: " + false);
            }
        }

        static void FindOfDivider(double sumOfElement)
        {
            double divider = 0;
            for (double i = 2; i < sumOfElement; i++)
            {
                if (i == (sumOfElement / i))
                {
                     divider= i;
                    
                    SimpleNumber(divider, sumOfElement);
                    break;
                }
            }
                SimpleNumberException(divider, sumOfElement);

        }
        static double SumOfElements(int[] myArray)
        {
            double sumOfElements = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                sumOfElements += myArray[i];
            }
            return sumOfElements;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива: ");
            double myMassiv = double.Parse(Console.ReadLine());
            int[] myArray = new int[(int)myMassiv];
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"Введите элемент под индексом {i}: ");
                myArray[i] = int.Parse(Console.ReadLine());
            }
            double result = SumOfElements(myArray);
           FindOfDivider(result);
          
       
          


           
        }
    }
}
