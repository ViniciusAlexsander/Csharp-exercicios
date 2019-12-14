using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roteiro_7___Repetição__Do_While_
{
    public static class Exercicio04
    {
        public static void ex04()
        {
            //4) Escreva um programa em C# para ler uma sequência de números inteiros positivos e verificar
            //se cada um deles é divisível por 3, escrevendo mensagem adequada.O último número digitado deverá ser zero.
            //Ex: Digite um número: 3
            //“É divisível por 3”.
            //Digite um número: 5
            //“Não é divisível por 3”.
            //Digite um número: 0

            int num = 0, teste;
            do
            {
                Console.Write("Digite um número para saber se é divisível: ");
                num = int.Parse(Console.ReadLine());
                if (num > 0)
                {
                    teste = num % 3;
                    if (teste == 0)
                    {
                        Console.WriteLine("É divisivel por 3");
                    }
                    if (teste != 0)
                    {
                        Console.WriteLine("Não é divisivel por 3");
                    }
                }
            } while (num > 0);
            Console.ReadKey();
        }
    }
}
