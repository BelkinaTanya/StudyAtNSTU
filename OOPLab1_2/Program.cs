using System;
using System.Collections.Generic;

namespace OOPLab1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2.5	Строка, содержащая произвольный русский текст, состоит не более чем из 200 символов. Написать, какие буквы и сколько раз встречаются в этом тексте. Ответ должен приводиться в грамматически правильной форме: например, а — 25 раз, к — 3 раза и т.д.
            Console.WriteLine("Введите текст:");
            var text = Console.ReadLine().ToLower();
            var symbol = new Dictionary<char, int>();
            foreach (char ch in text)
            {
                if (char.IsLetter(ch))
                {
                    if (!symbol.ContainsKey(ch))
                    {
                        symbol.Add(ch, 0);
                    }
                    symbol[ch]++;
                }
            }
            foreach (KeyValuePair<char, int> kvp in symbol)
            {
                if (kvp.Value == 2 || kvp.Value == 3 || kvp.Value == 4)
                    Console.WriteLine("Буква \"{0}\" встречается {1} раза", kvp.Key, kvp.Value);
                else
                    Console.WriteLine("Буква \"{0}\" встречается {1} раз", kvp.Key, kvp.Value);
            }
          
        }
    }
}
