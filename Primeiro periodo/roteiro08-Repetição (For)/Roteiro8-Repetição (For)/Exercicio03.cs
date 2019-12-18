using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roteiro8_Repetição__For_
{
    public static class Exercicio03
    {
        public static void ex03()
        {
            //3.Implemente um programa em C# para calcular e escrever o perímetro de círculos com raios
            //variando de 1 a 10 cm, de 0.5 em 0.5 cm.
            //Dica: o cálculo do perímetro de um círculo pode ser feito utilizando a fórmula
            //Perímetro(r) = r^2, onde  é aproximadamente 3,14 e r é o raio do círculo

            double raio, perimetro;
            for (raio = 1; raio <= 10; raio += 0.5)
            {
                perimetro = 3.14 * (raio * raio);
                Console.WriteLine($"O raio é: {raio} e o perimetro é: { perimetro} ");
            }
            Console.ReadKey();
        }
    }
}
