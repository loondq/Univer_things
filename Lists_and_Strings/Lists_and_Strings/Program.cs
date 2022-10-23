using System;

namespace ListsAndStrings
{
    class Project
    {
        static void Main()
        {
            String str = "Шалаш комок Два три абвгд катер абвгд три мадам кукуруза";
            Console.WriteLine(FindPalindromes(str));
            Console.WriteLine(IsFirstLetterOccursAgain(str));
            Console.WriteLine(IsOrderedString(str));
            Console.WriteLine($"самое длинное - {FindLongestAndShortestWords(str)[0]}, самое короткое - {FindLongestAndShortestWords(str)[1]}");
            Console.WriteLine(RemoveRepeatableWords(str));  
        }
        // 1 task
        static string FindPalindromes(string str)
        {
            var parts = str.ToLower().Split(" ");
            var palindromes = "";
            var fl = true;
            for (int k = 0; k < parts.Length; k++)
            {
                for (int i = 0; i < parts[k].Length / 2; i++)
                {
                    fl = true;
                    if (parts[k][i] != parts[k][parts[k].Length - (i + 1)])
                        fl = false;
                }
                if (fl)
                    palindromes += $"{parts[k]} ";
            }
            return palindromes;
        }
        // 2 task
        static bool IsFirstLetterOccursAgain(string str)
        {
            str = str.ToLower();
            for (int i = 1; i < str.Length; i++)
                if (str[0] == str[i])
                    return true;
            return false;
        }
        // 3 task
        static bool IsOrderedString(string str)
        {
            bool fl = true;
            for (int i = 0; i < str.Length - 1; i++)
                if (str[i] > str[i + 1])
                    fl = false;
            return fl;
        }
        // 4 task
        /// <returns>1. Longest | 2. Shortest</returns>
        static string[] FindLongestAndShortestWords(string str)
        {
            string[] longestAndShortestWords = new string[2]; 
            var parts = str.ToLower().Split();
            int longest = int.MinValue, shortest = int.MaxValue;
            for (int i = 0; i < parts.Length; i++)
            {
                if (parts[i].Length < shortest)
                {
                    longestAndShortestWords[1] = parts[i];
                    shortest = parts[i].Length;
                }
                if (parts[i].Length > longest)
                {
                    longestAndShortestWords[0] = parts[i];
                    longest = parts[i].Length;
                }
            }
            return longestAndShortestWords;
        }
        // 5 task
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
    }
}
