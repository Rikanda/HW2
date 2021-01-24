using System;

namespace Project4
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            string rn = "0000790278052486";
            string fn = "1000010006000937";
            string fns = "nalog.ru";
            int smena = 127;
            int checknumber = 197;
            string action = "Пополнение проездного";
            double count = 2;
            double price = 98.04;
            double result = count * price;

            Console.WriteLine($"КАССОВЫЙ ЧЕК/ПРИХОД \nРН ККТ: {rn} \nФН: {fn} \nСайт ФНС: {fns}") ;
            Console.WriteLine($"СМЕНА: {smena}  ЧЕК {checknumber}");
            Console.WriteLine(action);
            Console.Write("         {0:0.000} X ", count);
            Console.WriteLine(price);
            Console.WriteLine("ИТОГ: {0:0.00}", result);
        
        }
    }
}
