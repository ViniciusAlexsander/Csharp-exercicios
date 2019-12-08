using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roteiro06_Repetição__While_
{
    public static class Exercicio03
    {
        public static void ex03()
        {
            /* 3. Escreva um programa em C# para ler uma sequência de números inteiros positivos e verificar se
               cada um deles é divisível por 3, escrevendo mensagem adequada. O último número digitado
               deverá ser zero. */
            int numero = 1, divisivel;
            while (numero > 0)
            {
                Console.Write("Digite um numero: ");
                numero = int.Parse(Console.ReadLine());
                divisivel = numero % 3;
                if (numero != 0)
                {
                    if (divisivel == 0)
                        Console.WriteLine("É divisível por 3");
                    else
                        Console.WriteLine("Não é divisível por 3");
                }
            }
            Console.ReadKey();
        }
    }
}
