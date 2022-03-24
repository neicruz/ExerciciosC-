using System;
using System.IO;

namespace ExercicioArquivo3
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcepath = @"C:\Users\neicr\source\repos\file1.txt";
            string targepath = @"C:\Users\neicr\source\repos\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcepath);

                using (StreamWriter sw = File.AppendText(targepath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
