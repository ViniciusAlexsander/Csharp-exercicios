using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roteiro8_Repetição__For_
{
    public static class Exercicio02
    {
        public static void ex02()
        {
            //2.Escreva um programa em C# que calcule e escreva a seguinte soma:
            //soma = 1 / 1 + 3 / 2 + 5 / 3 + 7 / 4 + ... + 99 / 50

            double soma = 0, conta, num1 = 1, num2 = 1;
            for (num2 = 1; num2 <= 50; num2++)
            {
                conta = num1 / num2;
                soma += conta;
                num1 += 2;
            }
            Console.WriteLine($"A soma foi: {soma}");
            Console.ReadKey();
        }
    }
}
