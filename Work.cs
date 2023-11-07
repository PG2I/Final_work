

class Program
{
    static void Main()
    {
        Mass();
    }

    static void Mass()
    {
        Console.Write("Введите количество слов в массиве: ");
        int n = int.Parse(Console.ReadLine());

        string[] words = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Введите слово " + (i + 1) + ": ");
            words[i] = Console.ReadLine();
        }

        Console.WriteLine("\nИсходный массив слов:");
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

        string[] filteredWords = FilterWords(words);

        Console.WriteLine("\nМассив коротких слов (длина <= 3 символов):");
        foreach (string word in filteredWords)
        {
            Console.WriteLine(word);
        }
    }

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