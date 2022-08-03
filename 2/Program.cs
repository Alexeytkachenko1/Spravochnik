using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        
        /*
        //public class Panda
        //        {
        //            public string Name;// Поле экземпляра
        //            public static int Population;  // Статическое поле
        //            public Panda(string n) // Конструктор
        //            {
        //                Name = n;// Присвоить значение полю экземпляра
        //                Population = Population + 1;// Инкрементировать значение  статического поля Population
        //            }
        //        }
        Panda pi = new Panda("Pan Dee");
        Panda p2 = new Panda("Pan Dah");
        Console.WriteLine(pi.Name);
Console.WriteLine(p2.Name);
Console.WriteLine(Panda.Population);
        */


        public class Panda
        {
            public string Name;
            public static int Population;
            public Panda(string n)
            {
                Name = n;
                Population = Population + 1;
            }
        }
        static void Main(string[] args)
        {
            Panda panda1 = new Panda("PAnda 1");
            Panda panda2 = new Panda("Panda 2");

            Console.WriteLine(panda1.Name);
            Console.WriteLine(panda2.Name);
            Console.WriteLine(Panda.Population);
        }
    }
}
    

            























            //Panda pi = new Panda("Pan Dee");
            //Panda p2 = new Panda("Pan Dah");
            //Console.WriteLine(pi.Name);// Pan Dee
            //Console.WriteLine(p2.Name);// Pan Dah
            //Console.WriteLine(Panda.Population); // 2
    
