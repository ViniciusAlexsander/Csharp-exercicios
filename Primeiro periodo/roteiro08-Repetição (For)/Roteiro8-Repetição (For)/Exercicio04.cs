using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roteiro8_Repetição__For_
{
    public static class Exercicio04
    {
        public static void ex04()
        {
            //4.A conversão de graus Farenheit para centígrados é obtida por C = 5/9(Farenheit-32). Fazer um
            //programa que calcule e escreva uma tabela de graus centígrados em função de graus Farenheit,
            //que variam de 50 a 100, de 5 em 5.

            double centigrados;
            for (double F = 50; F <= 100; F += 5)
            {
                centigrados = (F - 32) * (5.0 / 9.0);
                Console.WriteLine($"{F}ºF = {centigrados:F2}ºC");
            }
            Console.ReadKey();
        }
    }
}
