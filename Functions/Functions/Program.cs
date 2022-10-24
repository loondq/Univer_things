using System;

namespace Functions
{
    class Project
    {
        static void Main()
        {
            StreamWriter writer = new StreamWriter("D:\\texts\\output.txt");
            for (int i = 1; i <= 10; i++) 
                writer.WriteLine($"Text {i}");
            writer.Close();
            StreamReader reader = new StreamReader("D:\\texts\\output.txt");
            string text = reader.ReadToEnd();
            Console.WriteLine(text);
        }
    }
}