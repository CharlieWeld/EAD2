using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        StreamReader reader = new StreamReader("text.txt");

        string line = "";

        while (line != null)
        {
            line = reader.ReadLine();
            if (line != null)
            {
                Console.WriteLine(line);
            }
        }

        reader.Close();
        Console.ReadLine();
    }
}