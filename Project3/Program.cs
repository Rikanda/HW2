using System;

namespace Project3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите любое целое число: ");
            string num = Console.ReadLine();
            int n = Convert.ToInt32(num);
            if (n%2 == 0)
            {
                Console.Write("Вы ввели четное число");
            }
            else
            {
                Console.Write("Вы ввели нечетное число");
            }
        }
    }
}
