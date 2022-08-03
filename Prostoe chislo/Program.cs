using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prostoe_chislo
{
    internal class Program
    {

        static int [] ProstoeChislo(int [] myArray)
        {
            int[]massivProstihChisel=new int[myArray.Length];
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 != 0 )
                {
                    massivProstihChisel[i] = myArray[i];
                }
                else
                {
                    massivProstihChisel[i] = 0;
                }
                
            }
            return massivProstihChisel;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedite massiv");
            int myMassiv=int.Parse(Console.ReadLine());
            int[] myArray = new int[myMassiv];
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"Vvedite element pod indexom: {i}");
                myArray[i] = int.Parse(Console.ReadLine());
            }
            int [] result = ProstoeChislo(myArray);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
