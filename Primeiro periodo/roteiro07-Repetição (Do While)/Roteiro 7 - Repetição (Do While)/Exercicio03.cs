using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roteiro_7___Repetição__Do_While_
{
    public static class Exercicio03
    {
        public static void ex03()
        {
            //3) Escreva um programa em C# que leia uma quantidade indeterminada de números inteiros positivos.  
            //Para terminar, deve ser digitado -1.Ao final, informar:
            //a.o maior número digitado;
            //b.o menor número digitado;
            //c.a média dos números digitados.
            int num, maior = 1, menor = 99999, acumulador = 0, contador = 0;
            double media;
            do
            {
                Console.Write("Digite um número: ");
                num = int.Parse(Console.ReadLine());
                if (num >= 0)
                {
                    if (num > maior)
                    {
                        maior = num;
                    }
                    if (num < menor)
                    {
                        menor = num;
                    }
                    acumulador += num;
                    contador++;
                }
            } while (num >= 0);
            media = acumulador / contador;
            Console.WriteLine($"O maior número foi: {maior}");
            Console.WriteLine($"O menor número foi: {menor}");
            Console.WriteLine($"A média dos números foi: {media}");
            Console.ReadKey();
        }

    }
}
