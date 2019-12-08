using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roteiro05_Comando_de_Decisão
{
    public static class Exercicio04
    {
        public static void ex04()
        {
            /* 4.Faça um algoritmo que receba o número do mês e mostre o mês correspondente. Informe
               mês inválido. 
            */
            int mes;
            Console.Write("Digite o número de um mês para ver sua forma escrita: ");
            mes = int.Parse(Console.ReadLine());
            switch (mes)
            {
                case 1:
                    {
                        Console.Write("O mês correspondente ao número digitado é Janeiro ");
                    }
                    break;
                case 2:
                    {
                        Console.Write("O mês correspondente ao número digitado é Fevereiro");
                    }
                    break;
                case 3:
                    {
                        Console.Write("O mês correspondente ao número digitado é Março");
                    }
                    break;
                case 4:
                    {
                        Console.Write("O mês correspondente ao número digitado é Abril");
                    }
                    break;
                case 5:
                    {
                        Console.Write("O mês correspondente ao número digitado é Maio");
                    }
                    break;
                case 6:
                    {
                        Console.Write("O mês correspondente ao número digitado é Junho");
                    }
                    break;
                case 7:
                    {
                        Console.Write("O mês correspondente ao número digitado é Julho");
                    }
                    break;
                case 8:
                    {
                        Console.Write("O mês correspondente ao número digitado é Agosto");
                    }
                    break;
                case 9:
                    {
                        Console.Write("O mês correspondente ao número digitado é Setembro");
                    }
                    break;
                case 10:
                    {
                        Console.Write("O mês correspondente ao número digitado é Outubro");
                    }
                    break;
                case 11:
                    {
                        Console.Write("O mês correspondente ao número digitado é Novembro");
                    }
                    break;
                case 12:
                    {
                        Console.Write("O mês correspondente ao número digitado é Dezembro");
                    }
                    break;
                default:
                    {
                        Console.Write("O mês correspondente ao número digitado é invalido");
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}
