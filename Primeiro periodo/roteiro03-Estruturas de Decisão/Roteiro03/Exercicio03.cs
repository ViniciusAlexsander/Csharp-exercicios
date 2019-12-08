using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roteiro03
{
    public static class Exercicio03
    {
        public static void ex03()
        {
            /* 3. Leia 3 números do teclado e imprima-os em ordem crescente. */
            float num1, num2, num3;
            Console.Write("Digite um numero: ");
            num1 = float.Parse(Console.ReadLine());
            Console.Write("Digite mais um numero: ");
            num2 = float.Parse(Console.ReadLine());
            Console.Write("Digite outro numero: ");
            num3 = float.Parse(Console.ReadLine());
            if (num1 < num2 && num2 < num3)
            {
                Console.WriteLine($" A ordem é: {num1}, {num2}, {num3}");
            }
            else
            if (num2 < num1 && num1 < num3)
            {
                Console.WriteLine($" A ordem é: {num2}, {num1}, {num3}");
            }
            else
            if (num3 < num2 && num2 < num1)
            {
                Console.WriteLine($" A ordem é: {num3}, {num2}, {num1}");
            }
            else
            if (num1 < num2 && num2 > num3)
            {
                Console.WriteLine($" A ordem é: {num3}, {num1}, {num2}");
            }
            else
            if (num1 > num2 && num2 < num3)
            {
                Console.WriteLine($" A ordem é: {num2}, {num3}, {num1}");
            }
            Console.ReadKey();
        }
    }
}
