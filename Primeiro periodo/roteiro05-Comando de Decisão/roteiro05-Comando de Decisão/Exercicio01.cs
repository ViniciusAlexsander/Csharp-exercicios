using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roteiro05_Comando_de_Decisão
{
    public static class Exercicio01
    {
        public static void ex01()
        {
            /* 1.Tendo como dados de entrada a altura e o sexo de uma pessoa, construa um algoritmo que
               calcule seu peso ideal, utilizando as seguintes fórmulas:
               • para homens: (72.7 * h) – 58
               • para mulheres: (62.1 * h) – 44.7 */
            char sexo;
            double altura, pesoIdeal;
            Console.WriteLine("Digite o seu sexo:");
            Console.WriteLine("Digite H para homem");
            Console.WriteLine("Digite F para mulher");
            sexo = char.Parse(Console.ReadLine().ToUpper());
            Console.Write("Digite sua altura: ");
            altura = float.Parse(Console.ReadLine());
            if (sexo == 'H')
            {
                pesoIdeal = (72.7 * altura) - 58;
                Console.WriteLine($"Seu peso ideal é {pesoIdeal}");
            }
            else
            {
                pesoIdeal = (62.1 * altura) - 44.7;
                Console.WriteLine($"Seu peso ideal é {pesoIdeal}");
            }
            Console.ReadKey();
        }
    }
}
