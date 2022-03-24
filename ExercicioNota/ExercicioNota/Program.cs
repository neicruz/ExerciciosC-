using System;
using System.Globalization;

namespace ExercicioNota
{
    class Program
    {
        static void Main(string[] args)
        {
            Alunos estudante = new Alunos();

            Console.WriteLine("Digite o Nome do Aluno: ");
            estudante.Nome = Console.ReadLine();
            Console.WriteLine("Digite as notas: ");
            estudante.Nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            estudante.Nota2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            estudante.Nota3 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine(estudante);
        }
    }
}
