using System;

namespace Project1
{
    public class Program
       

    {
        

        static void Main(string[] args)
        {
            GetTemp();
        }

        public static float GetTemp()
        {
            Console.Write("Введите температуру утром, градусов Цельсия: ");
            string tMorning = Console.ReadLine();
            double t1 = Convert.ToDouble(tMorning);
            Console.Write("Введите температуру вечером, градусов Цельсия: ");

            string tEvening = Console.ReadLine();
            double t2 = Convert.ToDouble(tEvening);

            float temp = (float)((t1 + t2) / 2);
            Console.WriteLine($"Среднесуточная температура {temp}");
            return temp;
            
        }

    }
}
