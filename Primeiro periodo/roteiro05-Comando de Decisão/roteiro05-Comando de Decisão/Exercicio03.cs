using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roteiro05_Comando_de_Decisão
{
    public static class Exercicio03
    {
        public static void ex03()
        {
            /* 3.Escreva um algoritmo que leia o número de identificação, as 3 notas obtidas por um aluno nas 3
               verificações e a média dos exercícios que fazem parte da avaliação, e calcule a média de
               aproveitamento, usando a fórmula:
               MA = (nota1 + nota 2 * 2 + nota 3 * 3 + ME)/7
               Média de aproveitamento Conceito
                >= 90 A
                >= 75 e < 90 B
                >= 60 e < 75 C
                >= 40 e < 60 D
                < 40 E  
                */
            float nota1, nota2, nota3, mediaAproveitamento;
            Console.Write("Digite sua primeira nota: ");
            nota1 = float.Parse(Console.ReadLine());
            Console.Write("Digite sua segunda nota: ");
            nota2 = float.Parse(Console.ReadLine());
            Console.Write("Digite sua terceira nota: ");
            nota3 = float.Parse(Console.ReadLine());
            mediaAproveitamento = (nota1 + nota2 * 2 + nota3 * 3 + ((nota1 + nota2 + nota3) /
            3) / 7);
            if (mediaAproveitamento >= 90)
            {
                Console.Write("Seu conceito é A");
            }
            else
            {
                if (mediaAproveitamento >= 75 && mediaAproveitamento < 90)
                {
                    Console.Write("Seu conceito é B");
                }
                else
                {
                    if (mediaAproveitamento >= 60 && mediaAproveitamento < 75)
                    {
                        Console.Write("Seu conceito é C");
                    }
                    else
                    {
                        if (mediaAproveitamento >= 40 && mediaAproveitamento < 60)
                        {
                            Console.Write("Seu conceito é D");
                        }
                        else
                        {
                            Console.Write("Seu conceito é E");
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
