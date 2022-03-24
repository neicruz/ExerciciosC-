using System;
using System.Collections.Generic;

namespace ExercicioListas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");
            list.Insert(2,"Marco");

            foreach (string varrer in list)
            {
                Console.WriteLine(varrer);
            }
            Console.WriteLine(list.Count);

            string s1 = list.Find(x => x[0]=='A');
            Console.WriteLine("Primeira 'A': "+s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("A ultima ocorrencia de 'A' é: "+s2);

            int p1 = list.FindIndex(x=>x[0]=='A');
            Console.WriteLine("Primeira posição começando com A: " +p1);

            int p2 = list.FindLastIndex(x=>x[0]=='A');
            Console.WriteLine("A ultima posição começando com A: "+p2);

            List<string> list2 = list.FindAll(x => x.Length == 5);

            Console.WriteLine("-------------------------");

            foreach (string varrer in list2)
            {
                Console.WriteLine(varrer);
            }

            list.Remove("Alex");
            Console.WriteLine("-----------------------------"  );

            foreach (string varrer in list)
            {
                Console.WriteLine(varrer);
            }
            Console.WriteLine("-----------------------------");

            list.RemoveAll(x=>x[0]=='M');

            foreach (string varrer in list)
            {
                Console.WriteLine(varrer);
            }
        }
    }
}
