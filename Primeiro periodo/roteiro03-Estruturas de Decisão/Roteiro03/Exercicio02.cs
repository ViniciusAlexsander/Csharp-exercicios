using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roteiro03
{
    public static class Exercicio02
    {
        public static void ex02()
        {
            /* 2. Leia 3 números reais e verificar se o primeiro é maior que a soma dos outros dois. */
            float n1, n2, n3, soma3e2;
            Console.WriteLine("===Digite 3 números pra saber se a soma dos dois ultimos números é maior que o primeiro número === ");
            Console.Write("Digite um numero: ");
            n1 = float.Parse(Console.ReadLine());
            Console.Write("Digite outro numero: ");
            n2 = float.Parse(Console.ReadLine());
            Console.Write("Digite mais um numero: ");
            n3 = float.Parse(Console.ReadLine());
            soma3e2 = n2 + n3;
            if (n1 > soma3e2)
            {
                Console.Write($" {n1} é maior que a soma de {n2} e {n3} ");
            }
            else
            {
                Console.Write($" {n1} é menor que a soma de {n2} e {n3}. ");
            }
            Console.ReadKey();
        }
    }
}
