using System;
using System.Text.RegularExpressions;

namespace OOPlab1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3.5	Задан текст. Определить является ли он текстом на русском языке.
            Console.WriteLine("Напишите любое предложение:");
            var text = Console.ReadLine();
            Regex cyrillicTest = new Regex(@"[а-яё]+", RegexOptions.IgnoreCase);
            bool isCyrillic = cyrillicTest.IsMatch(text);
            if (isCyrillic)
                Console.WriteLine("Текст на русском языке");
            else
                Console.WriteLine("Текст не на русском языке");
            Console.ReadKey();
        }
    }
}
