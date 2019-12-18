using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roteiro8_Repetição__For_
{
    public static class Exercicio01
    {
        public static void ex01()
        {
            //1.Implemente um programa em C# para ler as notas de 10 alunos, calcular e imprimir a média da turma.
            double mediaTurma, nota, notaTurma = 0;
            for (int aluno = 1; aluno <= 10; aluno++)
            {
                Console.Write("Digite sua nota: ");
                nota = double.Parse(Console.ReadLine());
                notaTurma = notaTurma + nota;
            }
            mediaTurma = notaTurma / 10;
            Console.WriteLine($"A media da turma é: {mediaTurma}");
            Console.ReadKey();
        }
    }
}
