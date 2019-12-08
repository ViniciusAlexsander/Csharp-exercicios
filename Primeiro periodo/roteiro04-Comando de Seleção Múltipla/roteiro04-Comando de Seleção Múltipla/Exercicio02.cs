using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roteiro04_Comando_de_Seleção_Múltipla
{
    public static class Exercicio02
    {
        public static void ex02()
        {
            /* 2.Um funcionário irá receber um aumento de acordo com seu plano de trabalho,
               conforme a tabela abaixo.                PLANO  |  AUMENTO                A      |    20%                 B      |    30%               C      |    45%                 Faça um programa que leia o plano de trabalho e o salário atual de um funcionário, calcule e
               imprima o seu novo salário. Use o comando switch.*/
            float salario, NovoSalario;
            char plano;
            Console.Write("Digite seu salario: R$");
            salario = float.Parse(Console.ReadLine());
            Console.Write("Digite seu plano: ");
            plano = char.Parse(Console.ReadLine().ToUpper());
            switch (plano)
            {
                case 'A':
                    {
                        NovoSalario = salario + ((salario / 100) * 20);
                        Console.WriteLine($"Seu novo salario é {NovoSalario}");
                    }
                    break;
                case 'B':
                    {
                        NovoSalario = salario + ((salario / 100) * 30);
                        Console.WriteLine($"Seu novo salario é {NovoSalario}");
                    }
                    break;
                case 'C':
                    {
                        NovoSalario = salario + ((salario / 100) * 45);
                        Console.WriteLine($"Seu novo salario é {NovoSalario}");
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}
