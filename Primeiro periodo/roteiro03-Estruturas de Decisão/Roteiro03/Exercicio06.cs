using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roteiro03
{
    public static class Exercicio06
    {
        public static void ex06()
        {
            float num1, num2, num3, num4, num5;
            Console.Write("Digite o primeiro número: ");
            num1 = float.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            num2 = float.Parse(Console.ReadLine());
            if (num1 < num2)
            {
                Console.Write("Digite o terceiro numero: ");
                num3 = float.Parse(Console.ReadLine());
                if (num2 < num3)
                {
                    Console.Write("Digite o quarto número: ");
                    num4 = float.Parse(Console.ReadLine());
                    if (num3 < num4)
                    {
                        Console.Write("Digite o quinto número: ");
                        num5 = float.Parse(Console.ReadLine());
                        if (num4 < num5)
                        {
                            Console.Write($"Os número digitados foram: {num1}, {num2}, {num3}, {num4}, {num5}");
                        }
                        else
                            Console.Write($"O QUINTO NÚMERO DIGITADO É INVALIDO...");
                    }
                    else
                        Console.Write($"O QUARTO NÚMERO DIGITADO É INVALIDO...");
                }
                else
                    Console.Write($"O TERCEIRO NÚMERO DIGITADO É INVALIDO...");
            }
            else
                Console.Write($"O SEGUNDO NÚMERO DIGITADO É INVALIDO...");
            Console.ReadKey();
        }
    }
}
