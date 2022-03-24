using System;
using System.Globalization;
using System.Collections.Generic;
using System.IO;

namespace ExercicioManipulandoArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcepath = @"C:\Users\neicr\source\repos\myfolder\file.csv";
            string targetpath = @"C:\Users\neicr\source\repos\myfolder\file2.csv";

            FileStream fs = null;
            StreamReader sr = null;

            try
            {

                sr = File.OpenText(sourcepath);

                fs = new FileStream(sourcepath, FileMode.Open);
                sr = new StreamReader(fs);



                string line = sr.ReadToEnd();
                /*Console.WriteLine(line);*/

                string[] vetor = line.Split(',');

                Console.WriteLine(vetor[0]);


                /*string[] texto = File.ReadAllLines(sourcepath);
                string[] text1 = texto[1].Split(',');
                Console.WriteLine(text1[1]);
                List<string> lista = new List<string>(texto);
                List<string> lista2 = new List<string>();
                foreach (string varrer in lista) {
                    Console.WriteLine(varrer);
                    varrer.Split(',');
                }


                for (int i =0;i<)
                {

                }*/
 
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred ");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }
        }
    }
}
