using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzirkovaya_sortirovka
{
    class Program
    {
        static void Swap(ref int firstValue,ref int secondValue)
        {
            (secondValue, firstValue) = (firstValue, secondValue);
        }
        static int[] BubleSort(ref int[] arrayForSort)
        {
            for (int i = 0; i < arrayForSort.Length; i++)
            {

                for (int j = 0; j < arrayForSort.Length-1; j++)
                {
                    if (arrayForSort[j] > arrayForSort[j+1])
                    {
                        Swap(ref arrayForSort[j],ref arrayForSort[j+1]);
                    }
                }
            }
            return arrayForSort;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Sortirovka puzurkom");
            Console.WriteLine("Vvedite kolvo elementov masssiva");
            int amountOfElements = int.Parse(Console.ReadLine());
            
            int[] arrayForSort = new int[amountOfElements];
            for (int i = 0; i <arrayForSort.Length; i++)
            {
                Console.WriteLine($"Vvedite elemet pod nomerom {i}");
                arrayForSort[i] = int.Parse(Console.ReadLine());
            }
            int []newArray= BubleSort(ref arrayForSort);
            foreach (var item in newArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}