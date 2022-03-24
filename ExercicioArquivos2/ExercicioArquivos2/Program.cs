using System;
using System.IO;

namespace ExercicioArquivos2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\neicr\source\repos\file1.txt";

            
            StreamReader sr = null;

            try
            {
            
                sr = File.OpenText(path);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }

            }
            catch(IOException E)
            {
                Console.WriteLine("An error accurred");
                Console.WriteLine(E.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
            
            }
           
        }
    }
}
