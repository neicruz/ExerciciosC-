using System;
using System.IO;

namespace ExercicioArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\neicr\source\repos\file1.txt";
            string targetPath = @"C:\Users\neicr\source\repos\file2.txt";

            try
            {
                FileInfo fileinfo = new FileInfo(sourcePath);
                fileinfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string varrer in lines)
                {
                    Console.WriteLine(varrer);
                }

            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);

            }



        }
    }
}
