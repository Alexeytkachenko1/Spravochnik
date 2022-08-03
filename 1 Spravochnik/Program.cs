using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//    public class UnitConverter
//    {
//        int ratio;// Поле
//        public UnitConverter(int unitRatio) // Конструктор
//        {
//            ratio = unitRatio;
//        }
//public int Convert(int unit) // Метод
//        {
//            return unit * ratio;
//        }
//    }
//    class Program
//    {

//        static void Main(string[] args)
//        {
//            UnitConverter feetToInchesConverter = new UnitConverter(12);
//            UnitConverter milesToFeetConverter = new UnitConverter(5280);

//            Console.WriteLine(feetToInchesConverter.Convert(30));   // 360
//            Console.WriteLine(feetToInchesConverter.Convert(100));  // 1200
//            Console.WriteLine(feetToInchesConverter.Convert(milesToFeetConverter.Convert(1)));   // 63360
//        }
//    }
//}
public class UnitConvert
{
    int ratio;
    public UnitConvert(int unitRatio)
    {
        ratio = unitRatio;
    }
    public int Convert(int unit)
    {
        return ratio* unit;
    }
}
class Program
{
    static void Main(string[] args)
    {
        UnitConvert unitConvertDM = new UnitConvert(10);
        UnitConvert unitConvertM = new UnitConvert(100);
        Console.WriteLine(unitConvertDM.Convert(26));
        Console.WriteLine(unitConvertDM.Convert(unitConvertM.Convert(1)));
    }
}


