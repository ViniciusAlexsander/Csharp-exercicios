using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roteiro06_Repetição__While_
{
    public static class Exercicio04
    {
        public static void ex04()
        {
            /* 4. Faça um programa em C# que calcule e escreva a seguinte soma:
               soma = 1/1 + 3/2 + 5/3 + 7/4 + ... + 99/50 */
            double resultado = 0, num1 = 1, num2 = 1;
            while (num1 <= 99)
            {
                resultado += num1 / num2;
                Console.WriteLine($"A conta é: {num1}/{num2} ");
                num1 += 2;
                num2 += 1;
            }
            Console.WriteLine($"A soma é: {resultado} ");
            Console.ReadKey();
        }
    }
}
