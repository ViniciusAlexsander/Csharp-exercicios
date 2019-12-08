using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roteiro03
{
    public static class Exercicio04
    {
        public static void ex04()
        {
            /* 4. Calcular a nota final de um aluno considerando o processo de avaliação adotado pela disciplina.
               Em caso de dúvida verificar no plano de ensino da disciplina. Desta vez vamos considerar a
               situação de reavaliação. */
            float ex1, prova1, tp1, mod1, ex2, prova2, tp2, mod2, notaFinal, reavaliacao;
            Console.Write("Digite sua nota da primeira lista de exercicios: ");
            ex1 = float.Parse(Console.ReadLine());
            Console.Write("Digite sua nota da primeira prova: ");
            prova1 = float.Parse(Console.ReadLine());
            Console.Write("Digite sua nota da primeira TP: ");
            tp1 = float.Parse(Console.ReadLine());
            Console.Write("Digite sua nota da segunda lista de exercicios: ");
            ex2 = float.Parse(Console.ReadLine());
            Console.Write("Digite sua nota da segunda prova: ");
            prova2 = float.Parse(Console.ReadLine());
            Console.Write("Digite sua nota da segunda TP: ");
            tp2 = float.Parse(Console.ReadLine());
            mod1 = ex1 + prova1 + tp1;
            mod2 = ex2 + prova2 + tp2;
            notaFinal = mod1 + mod2;
            if (notaFinal < 60)
            {
                Console.WriteLine("Você tera que fazer a reavaliação");
                Console.Write("Digite sua nota na reavaliaçao: ");
                reavaliacao = float.Parse(Console.ReadLine());
                if (mod1 < mod2)
                {
                    notaFinal = mod2 + reavaliacao;
                    Console.Write($"Sua nota final foi: {notaFinal}");
                }
                else
                if (mod2 < mod1)
                {
                    notaFinal = mod1 + reavaliacao;
                    Console.Write($"Sua nota final foi: {notaFinal}");
                }
            }
            else
                Console.Write($"parabens você foi aprovado, sua nota final foi: {notaFinal}");
            Console.ReadKey();
        }
    }
}
