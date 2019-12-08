using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roteiro06_Repetição__While_
{
    public static class Exercicio05
    {
        public static void ex05()
        {
            /* 5. Escreva um programa em C# que leia uma quantidade indeterminada de números inteiros
               positivos. Para terminar, deve ser digitado -1. Ao final, informar:
               a. o maior número digitado;
               b. o menor número digitado;
               c. a média dos números digitados. */
            int num, maior, menor, media = 0, rep = 0, acumulador = 0;
            Console.Write("Digite um numero inteiro e positivo: ");
            num = int.Parse(Console.ReadLine());
            maior = num;
            menor = num;
            while (num >= 0)
            {
                rep++;
                acumulador += num;
                if (num > maior)
                    maior = num;
                if (num < menor)
                    menor = num;
                Console.Write("Digite um número inteiro e positivo: ");
                num = int.Parse(Console.ReadLine());
            }
            media = acumulador / rep;
            Console.WriteLine($"O maior numero digitado foi: {maior}");
            Console.WriteLine($"O menor numero digitado foi: {menor}");
            Console.WriteLine($"A media dos numeros digitados é: {media}");
            Console.ReadKey();
        }
    }
}
