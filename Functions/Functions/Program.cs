using System;

namespace Functions
{
    class Project
    {
        static void Main()
        {
            StreamReader reader = new StreamReader("D:\\texts\\test.txt");
            var text = reader.ReadToEnd();
            StreamWriter writer = new StreamWriter("D:\\texts\\newTest.txt");
            writer.WriteLine(RemoveRepeatableWords(text));
            writer.Close(); 
            string word = "бак";
            Console.WriteLine($"Есть ли слово {word} в тексте? - {IsWordInText(text, word)}");
            Console.WriteLine($"Есть ли подстрока {word} в тексте? - {IsSubstringInText(text, word)}");
        }
        static string RemoveRepeatableWords(string str)
        {
            var parts = str.ToLower().Split();
            for (int i = 0; i < parts.Length - 1; i++)
            {
                for (int y = i; y < parts.Length - 1; y++)
                {
                    if (parts[i] == parts[y + 1])
                        parts[y + 1] = "";
                }
            }
            string result = String.Join(" ", parts);
            while (result.Contains("  ")) { result = result.Replace("  ", " "); }
            return result;
        }
        static bool IsWordInText(string text, string word)
        {
            var words = text.Split();
            for (int i = 0; i < words.Length; i++)
                if (words[i] == word)
                    return true;
            return false;
        }
        static bool IsSubstringInText(string text, string substring)
        {
            int n = substring.Length;
            text = text.Replace(" ", "");   
            for (int i = 0; i < text.Length - n; i++)
                if (string.Equals(text[i..(i+n)], substring))
                    return true;
            return false;
        }
    }
}
