using System;
using System.IO;


namespace ExercicioDiretorios
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\neicr\source\repos\myfolder";
            try
            {
                var folders =  Directory.EnumerateDirectories(path,"*.*",SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS: ");
                foreach (string varrer in folders)
                {
                    Console.WriteLine(varrer);
                }

                var files= Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES: ");
                foreach (string varrer in files)
                {
                    Console.WriteLine(varrer);
                }

                Directory.CreateDirectory(path + @"\newfolder");


            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
