using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using ExercicioFixacaoArquivos.Entities;

namespace ExercicioFixacaoArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcepath = @"C:\Users\neicr\source\repos\myfolder\file.csv";
            string targetpath = @"C:\Users\neicr\source\repos\myfolder\file4.csv";
            

            FileStream fs = null;
            StreamWriter sr = null;

            fs = new FileStream(targetpath, FileMode.Create);
            sr = new StreamWriter(fs);

            try
            {
                string[] vetor = File.ReadAllLines(sourcepath);
             
                List<Products> lista = new List<Products>();
                
                for (int i = 0; i < vetor.Length; i++)
                {
                    string[] vetor2 = vetor[i].Split(',');

                    string name = vetor2[0];
                    double price = double.Parse(vetor2[1], CultureInfo.InvariantCulture);
                    int quantity = int.Parse(vetor2[2], CultureInfo.InvariantCulture);
                    lista.Add(new Products(name, price, quantity));

                }

                //List<string> lista2 = new List<string>();




                foreach (Products varrer in lista)
                {
                    sr.WriteLine(varrer.Name+","+ varrer.TotalPrice().ToString("F2",CultureInfo.InvariantCulture));
                    Console.WriteLine(varrer.Name + "," + varrer.TotalPrice().ToString("F2", CultureInfo.InvariantCulture));
                    //fileInfo2.CreateText(varrer.Name);// (varrer.Name+","+varrer.TotalPrice().ToString("F2", CultureInfo.InvariantCulture)) ;
                }

                /*Console.WriteLine(name+" "+price.ToString("F2",CultureInfo.InvariantCulture)+" "+quantity);
                
                */



                /*foreach (string varrer in vetor)
                {
                    Console.WriteLine(varrer);
                    
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
                if (fs != null) sr.Close();
            }

        }
    }
}
