using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roteiro05_Comando_de_Decisão
{
    public static class Exercicio06
    {
        public static void ex06()
        {
            /* 6.Faça um algoritmo que receba o nome a idade, o sexo e
               salário fixo de um funcionário. Mostre o nome e o salário
               final de acordo com a tabela de abonos abaixo:

            Sexo  |  Idade  |  Abono
             M    |   >=30  |  100,00
             M    |   <30   |   80,00 
             F    |   >=30  |  200,00
             F    |   <30   |   80,00 
             Obs.: Salario final = salário fixo informado + abono */
            float salarioFixo, salarioFinal;
            int idade;
            string nome;
            char sexo;
            Console.Write("Digite seu nome: ");
            nome = (Console.ReadLine());
            Console.Write("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());
            Console.Write("Digite seu salario: ");
            salarioFixo = float.Parse(Console.ReadLine());
            Console.Write("Digite seu sexo,use M para masculino e F para feminino: ");
            sexo = char.Parse(Console.ReadLine().ToUpper());
            if (sexo == 'M')
            {
                if (idade >= 30)
                {
                    salarioFinal = salarioFixo + 100;
                    Console.WriteLine($"O salario final de {nome} é {salarioFinal}");
                }
                else
                {
                    salarioFinal = salarioFixo + 80;
                    Console.WriteLine($"O salario final de {nome} é {salarioFinal}");
                }
            }
            else
            {
                if (idade >= 30)
                {
                    salarioFinal = salarioFixo + 200;
                    Console.WriteLine($"O salario final de {nome} é {salarioFinal}");
                }
                else
                {
                    salarioFinal = salarioFixo + 80;
                    Console.WriteLine($"O salario final de {nome} é {salarioFinal}");
                }
            }
            Console.WriteLine("Digite uma tecla para finalizar o programa...");
            Console.ReadKey();
        }
    }
}
