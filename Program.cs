using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество слов в массиве: ");
        int n = int.Parse(Console.ReadLine()!);

        // Создаем массив слов
        string[] words = new string[n];

        // Ввод слов пользователем
        for (int i = 0; i < n; i++)
        {
            Console.Write("Введите слово " + (i + 1) + ": ");
            words[i] = Console.ReadLine()!;
        }

        // Выводим массив на экран
        Console.WriteLine("\nИсходный массив слов:");
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

        // Фильтруем массив и создаем новый массив с короткими словами
        string[] filteredWords = FilterWords(words);

        // Выводим отфильтрованный массив
        Console.WriteLine("\nМассив коротких слов (длина <= 3 символов):");
        foreach (string word in filteredWords)
        {
            Console.WriteLine(word);
        }
    }

    // Фильтрация массива слов по длине
    static string[] FilterWords(string[] words)
    {
        int count = 0;
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length <= 3)
            {
                count++;
            }
        }

        string[] filteredWords = new string[count];
        int index = 0;

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length <= 3)
            {
                filteredWords[index] = words[i];
                index++;
            }
        }

        return filteredWords;
    }
}
