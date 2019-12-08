using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roteiro05_Comando_de_Decisão
{
    public static class Exercicio02
    {
        public static void ex02()
        {
            /* 
               2.Elabore um algoritmo que leia o peso e a altura de um adulto e mostre sua condição de
               acordo com a tabela abaixo.
               • IMC em adultos Condição
                 - Abaixo de 18,5 Abaixo do peso
                 - Entre 18,5 e 25 Peso normal
                 - Entre 25 e 30 Acima do peso
                 - Acima de 30 obeso 
            */
            float altura, peso, imc;
            Console.Write("Digite seu peso: ");
            peso = float.Parse(Console.ReadLine());
            Console.Write("Digite sua altura: ");
            altura = float.Parse(Console.ReadLine());
            imc = peso / (altura * altura);
            if (imc <= 18.5)
            {
                Console.Write("você esta abaixo do peso ");
            }
            else
            if (imc >= 18.5 && imc <= 25)
            {
                Console.Write("Você esta no peso normal ");
            }
            else
            if (imc >= 25 && imc <= 30)
            {
                Console.Write("Você esta acima do peso");
            }
            else
                Console.Write("Você é obeso");
            Console.ReadKey();
        }
    }
}
