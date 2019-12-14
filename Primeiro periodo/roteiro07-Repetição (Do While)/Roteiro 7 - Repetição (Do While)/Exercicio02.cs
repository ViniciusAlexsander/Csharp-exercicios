using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roteiro_7___Repetição__Do_While_
{
    public static class Exercicio02
    {
        public static void ex02()
        {
            //2) Faça um programa em C# que calcule e escreva a seguinte soma:
            //soma = 1 / 1 + 3 / 2 + 5 / 3 + 7 / 4 + ... + 99 / 50
            double soma = 0, divisao, num1 = 1, num2 = 1;
            do
            {
                Console.WriteLine($"{num1}/{num2}");
                divisao = num1 / num2;
                soma = soma + divisao;
                num1 = num1 + 2;
                num2 = num2 + 1;
            } while (num1 <= 99 && num2 <= 50);
            Console.WriteLine($"{soma}");
            Console.ReadKey();
        }
    }
}
