using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roteiro04_Comando_de_Seleção_Múltipla
{
    public static class Exercicio01
    {
        public static void ex01()
        {
            /* 1. Faça um programa em C# para ler um número inteiro entre 1 e 12 inclusive e imprimi-lo
               por extenso. Use o comando switch. */
            int numero;
            Console.Write("Digite um número entre 1 e 12: ");
            numero = int.Parse(Console.ReadLine());
            switch (numero)
            {
                case 1:
                    {
                        Console.Write("Seu número é um");
                    }
                    break;
                case 2:
                    {
                        Console.Write("Seu número é dois");
                    }
                    break;
                case 3:
                    {
                        Console.Write("Seu número é três");
                    }
                    break;
                case 4:
                    {
                        Console.Write("Seu número é quatro");
                    }
                    break;
                case 5:
                    {
                        Console.Write("Seu número cinco");
                    }
                    break;
                case 6:
                    {
                        Console.Write("Seu número sexta");
                    }
                    break;
                case 7:
                    {
                        Console.Write("Seu número é sete");
                    }
                    break;
                case 8:
                    {
                        Console.Write("Seu número é oito");
                    }
                    break;
                case 9:
                    {
                        Console.Write("Seu número é nove");
                    }
                    break;
                case 10:
                    {
                        Console.Write("Seu número é dez");
                    }
                    break;
                case 11:
                    {
                        Console.Write("Seu número é onze");
                    }
                    break;
                case 12:
                    {
                        Console.Write("doze");
                    }
                    break;
                default:
                    {
                        Console.Write("numero invalido");
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}
