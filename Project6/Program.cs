using System;

namespace Project6
{
    class Program
    {
        public enum Days
        { 
            Monday = 0b_0000001,
            Tuesday = 0b_0000010,
            Wednesday = 0b_0000100,
            Thursfay = 0b_0001000,
            Frifay = 0b_0010000,
            Saturday = 0b_0100000,
            Sunday = 0b_10000000,
        }
        static void Main(string[] args)
        {
            Days office1 = Days.Tuesday | Days.Wednesday | Days.Thursfay | Days.Frifay;
            Days office2 = Days.Monday | Days.Tuesday | Days.Wednesday | Days.Thursfay | Days.Frifay | Days.Saturday | Days.Sunday;

            Console.Write("Укажите номер дня недели: ");

               string da = Console.ReadLine();
               int day = Convert.ToInt16(da)-1;
          
            
            Days d = (Days)Enum.GetValues(typeof(Days)).GetValue(day);

            string s = Enum.GetName(typeof(Days), d);
            Days times1 = office1 & d;
            Days times2 = office2 & d;

            bool isopen1 = times1 == d;
            bool isopen2 = times2 == d;

            string o1;
            string o2;

            if (isopen1)
            {
                o1 = "офис 1 открыт";
            }
            else
            {
                o1 = "офис 1 закрыт";
            }
            if (isopen2)
            {
                o2 = "офис 2 открыт";
            }
            else
            {
                o2 = "офис 2 закрыт";
            }
           
           Console.WriteLine($"Сегодня {s}, {o1}, {o2}");
            

        }
    }
}
