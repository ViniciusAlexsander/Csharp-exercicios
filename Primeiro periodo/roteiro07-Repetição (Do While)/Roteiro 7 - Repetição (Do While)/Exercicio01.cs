using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roteiro_7___Repetição__Do_While_
{
    public static class Exercicio01
    {
        public static void ex01()
        {
            //1) Implemente um programa em C# para ler as notas de 10 alunos, calcular e imprimir a média da turma.
            int alunos = 0;
            double media, nota = 0, todasNotas = 0;
            do
            {
                Console.Write("Digite a nota do aluno: ");
                nota = double.Parse(Console.ReadLine());
                alunos = alunos + 1;
                todasNotas = todasNotas + nota;
            } while (alunos < 10);
            media = todasNotas / alunos;
            Console.WriteLine($"A média da sala foi: {media}");
            Console.ReadKey();
        }
    }
}
