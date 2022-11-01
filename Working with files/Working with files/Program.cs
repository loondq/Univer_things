using System.Text;

namespace Files
{
    class Program
    {
        static StringBuilder sb = new StringBuilder();

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

            MakeChanges(ref parts);
            foreach (var word in parts)
                Console.WriteLine(word);
        }
        static void MakeChanges(ref string[] parts)
        {
            for (int i = 0; i < parts.Length; i++)
            {
                if (parts[i].Length == 4)
                    SwapFirstLetterToTheEnd(ref parts[i]);
                if (parts[i].Length == 5)
                    SwapLastLetterToTheStart(ref parts[i]);
                if (parts[i].Length == 3)
                    DeleteFirstLetter(ref parts[i]);
                if (parts[i].Length == 6)
                    DeleteLastLetter(ref parts[i]);
            }
        }
        static void SwapFirstLetterToTheEnd(ref string word)
        {
            sb = new(word);
            char k = sb[0];
            for (int i = 0; i < sb.Length - 1; i++)
                sb[i] = sb[i + 1];
            sb[^1] = k;
            word = sb.ToString();
        }
        static void SwapLastLetterToTheStart(ref string word)
        {
            sb = new(word);
            char k = sb[^1];
            for (int i = 1; i < sb.Length; i++)
                sb[^i]= sb[^(i+1)];
            sb[0] = k;
            word = sb.ToString();
        }
        static void DeleteFirstLetter(ref string word)
        {
            sb = new(word);
            sb.Remove(0, 1);
            word = sb.ToString();
        }
        static void DeleteLastLetter(ref string word)
        {
            sb = new(word);
            sb.Remove(sb.Length - 1, 1);
            word = sb.ToString();
        }
    }
}