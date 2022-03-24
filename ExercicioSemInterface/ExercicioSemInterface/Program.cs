using System;
using System.Globalization;
using ExercicioSemInterface.Entities;
using System.IO;

namespace ExercicioSemInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcefile = @"C:\Users\neicr\source\repos\myfolder\exercicio\file1.csv";
            string targetfile = @"C:\Users\neicr\source\repos\myfolder\exercicio\file2.csv";
            

            StreamWriter sw =null;
            FileStream fs = null;

            fs = new FileStream(targetfile, FileMode.Create);
            sw = new StreamWriter(fs);

            try
            {

                string[] vetor = File.ReadAllLines(sourcefile);
                Rent rent = new Rent();
                for (int i = 0; i< vetor.Length; i++)
                {
                    string[] vetor2 = vetor[i].ToString(CultureInfo.InvariantCulture).Split(',');
                    string name = vetor2[0];
                    DateTime pick = DateTime.Parse(vetor2[1]);
                    DateTime put = DateTime.Parse(vetor2[2]);
                    double perhour = double.Parse(vetor2[3], CultureInfo.InvariantCulture);
                    double perday = double.Parse(vetor2[4], CultureInfo.InvariantCulture);
                    rent =new Rent(name,pick,put,perhour,perday);

                }


                Console.WriteLine(rent);

                sw.WriteLine(rent);

                
            }
            catch (IOException e) {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
            catch (InvalidDataException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);

            }
            finally
            {
                if (sw != null) sw.Close();
                if (fs != null) fs.Close();

            }


        }
    }
}
