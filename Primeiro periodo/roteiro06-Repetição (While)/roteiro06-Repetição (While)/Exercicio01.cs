using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roteiro06_Repetição__While_
{
    public static class Exercicio01
    {
        public static void ex01()
        {
            /* 1. Implemente um programa em C# para ler as notas de 10 alunos, calcular e imprimir a média da turma. */
            float nota, notaGeral = 0, mediaGeral;
            int rep = 1;
            while (rep <= 10)
            {
                ++rep;
                Console.Write("Digite sua nota: ");
                nota = float.Parse(Console.ReadLine());
                notaGeral += nota;
            }
            mediaGeral = notaGeral / 10;
            Console.WriteLine($"A media geral da turma foi: {mediaGeral}");
            Console.ReadKey();
        }
    }
}
