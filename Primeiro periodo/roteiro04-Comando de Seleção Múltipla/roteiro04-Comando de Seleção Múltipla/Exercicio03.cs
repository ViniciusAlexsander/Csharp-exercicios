using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roteiro04_Comando_de_Seleção_Múltipla
{
    public static class Exercicio03
    {
        public static void ex03()
        {
            /* 3. Faça um programa para mostrar o menu de opções abaixo, em seguida 
               leia a opção do usuário e os dados necessários para executar cada operação. Utilize switch.
               Menu de Opções
               1. Somar dois números
               2. Subtrair dois números
               3. Divisão de dois números
               Obs.: Verifique se a divisão é por 0 (zero). Caso seja imprimir “Erro” na tela. */
            int opcao;
            float n1, n2, resultado;
            Console.WriteLine(" 1 - Somar dois números");
            Console.WriteLine(" 2 - Subtrair dois números");
            Console.WriteLine(" 3 - Dividir dois números");
            Console.Write(" Digite o número da sua opção: ");
            opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    {
                        Console.Write(" Digite um número: ");
                        n1 = float.Parse(Console.ReadLine());
                        Console.Write(" Digite um número: ");
                        n2 = float.Parse(Console.ReadLine());
                        resultado = n1 + n2;
                        Console.WriteLine($" o Resultado é {resultado}");
                    }
                    break;
                case 2:
                    {
                        Console.Write(" Digite um número: ");
                        n1 = float.Parse(Console.ReadLine());
                        Console.Write(" Digite um número: ");
                        n2 = float.Parse(Console.ReadLine());
                        resultado = n1 - n2;
                        Console.WriteLine($" O Resultado é {resultado}");
                    }
                    break;
                case 3:
                    {
                        Console.Write(" Digite um número: ");
                        n1 = float.Parse(Console.ReadLine());
                        Console.Write(" Digite um número: ");
                        n2 = float.Parse(Console.ReadLine());
                        if (n2 == 0)
                        {
                            Console.WriteLine(" O segundo numero é invalido... ");
                        }
                        else
                        {
                            resultado = n1 / n2;
                            Console.WriteLine($" O Resultado é: {resultado}");
                        }
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}
