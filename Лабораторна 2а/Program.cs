using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab__02
{
    class Printer
    {
        public string Brand;
        public string Country;
        public string Region;
        public int Price;
        public double Weight;
        public double Lenghth;
        public bool HasHydraulicBrake;
        public bool HasHydraulicSeatPost;
        public double GetYearIncomePerInhabitant()
        {
            return Price / Weight;
        }

        static void Main()
        {
            Printer[] arrPrinter;
            Console.Write("Введiть кiлькiсть моделей: ");
            int cntPrinter = int.Parse(Console.ReadLine());
            arrPrinter = new Printer[cntPrinter];

            for (int i = 0; i < cntPrinter; i++)
            {
                Console.OutputEncoding = System.Text.Encoding.Default;

                Console.Write("Введiть назву Принтера: ");
                string sBrand = Console.ReadLine();
                Console.Write("Введiть назву краiни виробника: ");
                string sCountry = Console.ReadLine();
                Console.Write("Введiть назву регіону виробництва: ");
                string sRegion = Console.ReadLine();
                Console.Write("Введiть ціну: ");
                string sPrice = Console.ReadLine();
                Console.Write("Швидкість чорно-білого друку (ст/хв): ");
                string sWeight = Console.ReadLine();
                Console.Write("Швидкість кольорового друку (ст/хв): ");
                string sLenghth = Console.ReadLine();
                Console.Write("Струйний принтер? (y-так, n-нi): ");
                ConsoleKeyInfo keyHasPrintertype = Console.ReadKey();
                Console.WriteLine();
                Console.Write("Подача бумаги сзаду? (y-так, n-нi): "); ConsoleKeyInfo keyHasPaperfeedtype = Console.ReadKey();
                Console.WriteLine();
                Printer OurPrinter = new Printer();
                OurPrinter.Brand = sBrand;
                OurPrinter.Country = sCountry;
                OurPrinter.Region = sRegion;
                OurPrinter.Price = int.Parse(sPrice);
                OurPrinter.Weight = double.Parse(sWeight);
                OurPrinter.Lenghth = double.Parse(sLenghth);
                OurPrinter.HasHydraulicBrake = keyHasPrintertype.Key == ConsoleKey.Y ? true : false; OurPrinter.HasHydraulicSeatPost = keyHasPaperfeedtype.Key == ConsoleKey.Y ? true : false;
                double YearIncomePerInhabitant = OurPrinter.GetYearIncomePerInhabitant();
                Console.WriteLine();
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine(" "); Console.WriteLine("Данi про об`ект: ");
                Console.WriteLine("");
                Console.WriteLine("Назва: " + OurPrinter.Brand);
                Console.WriteLine("Країна: " + OurPrinter.Country);
                Console.WriteLine("Регіон: " + OurPrinter.Region);
                Console.WriteLine("Ціна: " +
                OurPrinter.Price.ToString());
                Console.WriteLine("Швидкість чорно-білого друку (ст/хв): " +
                OurPrinter.Weight.ToString("0"));
                Console.WriteLine("Швидкість кольорового друку (ст/хв): " + OurPrinter.Lenghth.ToString("0")); Console.WriteLine(OurPrinter.HasHydraulicBrake ? "Струйний принтер Так" : "Струйний принтер Ні");
                Console.WriteLine(OurPrinter.HasHydraulicBrake ? "Подача бумаги сзаду Так" : "Подача бумаги сзаду Ні");
                Console.WriteLine();


            }
        }


    }
}
