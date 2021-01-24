using System;

namespace Project2
{
    public class Program
    {

        public enum Months
        {
            январь = 1,
            февраль,
            март,
            апрель,
            май,
            июнь,
            июль,
            август,
            сентябрь,
            октябрь,
            ноябрь,
            декабрь


        }

        static void Main(string[] args)
        {
            MonthTransform();
        }

        public static int MonthTransform()
        {
            Console.Write("Укажите номер месяца: ");

            string mn = Console.ReadLine();
            int m = Convert.ToInt16(mn);
            string mon = Enum.GetName(typeof(Months), m);
            if (m<=12&&m>0)
            {
                Console.WriteLine($"Сейчас {mon}");
            }

            else
            {
                Console.WriteLine("Такого месяца не существует");
            }
            return m;
        }
    }
}
