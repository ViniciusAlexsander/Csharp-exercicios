using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roteiro03
{
    public static class Exercicio05
    {
        public static void ex05()
        {
            /* 5. Calcular a soma de dois valores apenas se ambos forem positivos, caso contrário avisar o usuário
               do valor negativo e abandonar a execução do programa. */
            float num1, num2, soma;
            Console.Write("Digite um número: ");
            num1 = float.Parse(Console.ReadLine());
            Console.Write("Digite um número: ");
            num2 = float.Parse(Console.ReadLine());
            if (num1 >= 0 && num2 >= 0)
            {
                soma = num1 + num2;
                Console.WriteLine($"Números validos");
                Console.Write($"Sua soma deu: {soma}");
            }
            else
                Console.WriteLine("Números invalidos para realizar a soma,tente novamente com números positivos.");
                Console.ReadKey();

        }
    }
}
