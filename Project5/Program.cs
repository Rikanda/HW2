using System;
using GT = Project1.Program;
using MT = Project2.Program;

namespace Project5
{
    class Program
    {
        static void Main(string[] args)
        {
          
            float t = GT.GetTemp();
            int m = MT.MonthTransform();
            string season = "";
            string modif = "";
            switch (m)
            {
                case 12:
                case 1:
                case 2:
                    season = "зима";
                    if (t>0)
                    {
                        modif = "дождливая ";
                    }
                    break;
                case 3:
                case 4:
                case 5:
                    season = "весна";
                    break;
                case 6:
                case 7:
                case 8:
                    season = "лето";
                    break;
                case 9:
                case 10:
                case 11:
                    season = "осень";
                    break;
            }

            Console.WriteLine($"Сейчас {modif}{season}");
           

        }
    }
}
