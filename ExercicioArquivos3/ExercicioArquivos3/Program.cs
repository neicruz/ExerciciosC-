using System;
using System.IO;

namespace ExercicioArquivos3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\neicr\source\repos\file1.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
