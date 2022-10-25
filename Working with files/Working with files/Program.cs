using System;

namespace Files
{
    class Program
    {
        static void Main()
        {
            StreamReader reader = new StreamReader("D:\\texts\\test.txt");
            var parts = reader.ReadToEnd().Split();
            Dictionary<string, int> words = new Dictionary<string, int>();
            foreach (var word in parts)
            {
                if (!words.ContainsKey(word))
                    words.Add(word, 1);
                else
                    words[word]++;
            }
            foreach (var word in words)
                Console.WriteLine($"{word.Key} - {word.Value}");
        }
    }
}