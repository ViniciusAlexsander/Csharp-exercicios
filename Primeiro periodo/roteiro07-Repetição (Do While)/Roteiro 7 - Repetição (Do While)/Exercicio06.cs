using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roteiro_7___Repetição__Do_While_
{
    public static class Exercicio06
    {
        public static void ex06()
        {
            //6) Uma certa firma fez uma pesquisa de mercado para saber se as pessoas gostaram ou não de
            //um novo produto.Para isso, forneceu a idade e a resposta do participante(sim ou não).
            //Escreva um programa para ler os dados e escrever:
            //a) quantas pessoas gostaram do produto(responderam sim);
            //b) quantas pessoas não gostaram do produto(responderam não);
            //c) qual porcentagem de pessoas com idade <= a 25 anos gostaram do produto;
            //d) qual porcentagem de pessoas com idade > 25 anos gostaram do produto.
            //Considere terminar a leitura de dados quando a idade for igual a 0 e que haverá sempre no mínimo um participante na pesquisa.

            char gosto;
            int idade,gostaram=0,maior25gostou = 0,menor25gostou=0, porcetagemMaior25Gostou, naogostaram=0, porcetagemMenor25Gostou;
            do
            {
                Console.Write("Digite sua idade: ");
                idade = int.Parse(Console.ReadLine());
                if (idade > 0)
                {
                    Console.Write("você gostou do carro? Digite S para sim e N para não: ");
                    gosto = char.Parse(Console.ReadLine().ToUpper());
                    if (gosto == 'S')
                    {
                        gostaram = gostaram + 1;
                        if (idade >= 25)
                        {
                            maior25gostou = maior25gostou + 1;
                        }
                        else
                        {
                            if (idade <= 25)
                            {
                                menor25gostou = menor25gostou + 1;
                            }
                        }
                    }
                    else
                    {
                        if (gosto == 'N')
                        {
                            naogostaram = naogostaram + 1;
                        }
                    }
                }

            } while (idade > 0);
            porcetagemMaior25Gostou = (100 * maior25gostou) / gostaram;
            porcetagemMenor25Gostou = (100 * menor25gostou) / gostaram;
            Console.WriteLine($"{gostaram} pessoas gostaram do carro");
            Console.WriteLine($"{naogostaram} pessoas não gostaram do carro");
            Console.WriteLine($"{porcetagemMaior25Gostou}% dos que gostaram do carro tem mais do que 25 anos");
            Console.WriteLine($"{porcetagemMenor25Gostou}% dos que gostaram do carro tem menos do que 25 ");
            Console.ReadKey();
        }
    }
}
