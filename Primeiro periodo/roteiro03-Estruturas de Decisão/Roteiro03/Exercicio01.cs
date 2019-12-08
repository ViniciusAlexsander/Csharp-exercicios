using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roteiro03
{
    public static class Exercicio01
    {
        public static void ex01()
        {
            /* 1. Ler 2 números inteiros, verificar e imprimir qual deles é o maior, ou a mensagem “valores iguais” 
               caso sejam iguais. */
            int n1, n2;
            Console.WriteLine("==== Comparador de números ==== ");
            Console.Write("Digite um número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite outro número: ");
            n2 = int.Parse(Console.ReadLine());
            if (n1 > n2)
            {
                Console.Write($" {n1} é maior que {n2}");
            }
            else
            if (n2 > n1)
                Console.Write($"{n2} é maior que {n1}");
            else Console.Write("Seus números são iguais");
            Console.ReadKey();
        }
    }
}
