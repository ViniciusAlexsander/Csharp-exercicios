using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roteiro06_Repetição__While_
{
    public static class Exercicio02
    {
        public static void ex02()
        {
            /* 2. Uma Instituição de Ensino Superior precisa cadastrar a sua comunidade acadêmica e uma das
               informações é o tipo do vínculo do indivíduo com a Instituição, que deverá ser uma das três opções abaixo:
               Tipo | Descrição
                 A  |  Aluno
                 F  |  Funcionário
                 P  |   Professor
               Faça um programa em C# para ler o tipo do vínculo de um indivíduo. Ler a informação do teclado,
               enquanto o caractere digitado não for ‘A’ ou ‘a’, ‘F’ ou ‘f’, nem ‘P’ ou ‘p’. Ao final, imprimir o tipo de
               vínculo válido digitado. */
            char vinculo;
            Console.Write("Digite seu vinculo: (A - aluno/ F - funcionario / P - professor) ");
            vinculo = char.Parse(Console.ReadLine().ToUpper());
            while ((vinculo != 'A') && (vinculo != 'P') && (vinculo != 'F'))
            {
                Console.WriteLine("Tipo invalido");
                Console.Write("Digite seu vinculo: (A - aluno/ F - funcionario / P - professor) ");
                vinculo = char.Parse(Console.ReadLine().ToUpper());
            }
            switch (vinculo)
            {
                case 'A':
                    Console.WriteLine("Você é um aluno");
                    break;
                case 'P':
                    Console.WriteLine("Você é um professor");
                    break;
                case 'F':
                    Console.WriteLine("Você é funcionario");
                    break;
            }
            Console.ReadKey();
        }
    }
}
