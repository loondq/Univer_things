using System;

namespace test
{
    class Project
    {
        static void Main()
        {
            String str = "Шалаш комок Два три абвгд катер мадам";
            Console.WriteLine(FindPalindromes(str));
            Console.WriteLine(IsFirstLetterOccursAgain(str));
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
    }
}
