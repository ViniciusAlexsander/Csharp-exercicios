using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roteiro8_Repetição__For_
{
    public static class Exercicio05
    {
        public static void ex05()
        {
            //5.Fazer um programa para calcular e escreve o valor do número , com precisão de 0,001, usando a série: ...
            //pi = 4 - 4/3 + 4/5 - 4/7 + 4/9 - 4/11...
            //Para obter a precisão desejada, adicionar apenas os termos cujo valor absoluto seja maior ou igual a 0,001

            double pi = 0, conta = 1, denominador;
            int contador = 0;
            for (denominador = 1; conta >= 0.001; denominador += 2)
            {
                conta = 4 / denominador;
                if (contador % 2 == 0)
                    pi = pi + conta;
                else
                    pi = pi - conta;
                contador++;
            }
            Console.WriteLine($"Pi = {pi}");
            Console.ReadKey();
        }
    }
}
