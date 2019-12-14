using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roteiro_7___Repetição__Do_While_
{
    public static class Exercicio05
    {
        public static void ex05()
        {
            //5) Fazer um programa para calcular e escreve o valor do número , com precisão de 0.001, usando a série:
            //π = 4−4 / 3 + 4 / 5 - 4 / 7 + 4 / 9 - 4 / 11
            //Para obter a precisão desejada, adicionar apenas os termos cujo valor absoluto seja maior ou igual a 0.001.

            double contador = 0, soma = 4, num2 = 3, conta;
            do
            {
                conta = 4 / num2;
                num2 = num2 + 2;
                if (contador % 2 == 0)
                    soma = soma - conta;
                else
                    soma = soma + conta;
                contador = contador + 1;
                Console.WriteLine($" 4 / {num2} = {conta}");
            } while (conta >= 0.001);
            Console.WriteLine($"pi = {soma}");
            Console.ReadKey();


        }
    }
}
