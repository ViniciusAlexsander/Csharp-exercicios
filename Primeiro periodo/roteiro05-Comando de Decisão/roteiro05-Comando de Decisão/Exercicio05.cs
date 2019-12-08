using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roteiro05_Comando_de_Decisão
{
    public static class Exercicio05
    {
        public static void ex05()
        {
            /* 5.Dados três valores A, B e C, em que A e B são números inteiros e C é um caractere, pede-se
               para imprimir o resultado da operação de A por B se C for um símbolo de
               operador aritmético; caso contrário deve ser impressa uma mensagem de operador não definido.
               Obs.: Tratar erro de divisão por zero e considerar apenas as operações de soma, subtração,
               multiplicação, divisão e resto */
            int A, B, conta;
            char C;
            Console.Write("Digite um valor númerico para A: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Digite um valor númerico para B: ");
            B = int.Parse(Console.ReadLine());
            Console.Write("Digite um valor de operação para C: ");
            C = char.Parse(Console.ReadLine());
            switch (C)
            {
                case '+':
                    {
                        conta = A + B;
                        Console.Write($"Seu resultado deu: {conta}");
                    }
                    break;
                case '-':
                    {
                        conta = A - B;
                        Console.Write($"Seu resultado deu: {conta}");
                    }
                    break;
                case '*':
                    {
                        conta = A * B;
                        Console.Write($"Seu resultado deu: {conta}");
                    }
                    break;
                case '/':
                    {
                        if (B == 0)
                        {
                            Console.Write("nao foi possivel dividir por 0");
                        }
                        else
                        {
                            conta = A / B;
                            Console.Write($"Seu resultado deu: {conta}");
                        }
                    }
                    break;
                case '%':
                    {
                        conta = A % B;
                        Console.Write($"Seu resultado deu: {conta}");
                    }
                    break;
                default:
                    {
                        Console.Write("impossivel realizar a conta");
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}
