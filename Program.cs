/* 
 Royerzinho quer calcular e mostrar a quantidade de litros de combustível gastos em uma viagem, ao utilizar um automóvel que faz
12 KM/L. Para isso, ele gostaria que você o auxiliasse através de um simples programa. Para efetuar o cálculo, deve-se fornecer 
o tempo gasto na viagem (em horas) e a velocidade média durante a mesma (em km/h). Assim, pode-se obter distância percorrida e,
em seguida, calcular quantos litros seriam necessários. Mostre o valor com 3 casas decimais após o ponto.

OBS.:  Pode ser desenvolvida em console, windows forms, wpf ou sem front apenas com testes unitários

*/
using System;

namespace Royerzinho
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Royerzinho Transportes - Calcule seu frete agora mesmo! ");
            Console.WriteLine();
            Console.WriteLine("**********************************************************");
            Console.WriteLine();

            double horas = 0;
            double velocidadeMed;
            double distancia;
            double qdeCombustivel;
            double mediaKmLitro = 12;

            Console.WriteLine("Digite o tempo de viagem em horas");
            horas = double.Parse(Console.ReadLine());
                 
            Console.WriteLine("Digite a velocidade média da viagem em km/h");
            velocidadeMed = double.Parse(Console.ReadLine());

            // calculamos a distância percorrida 
            Console.WriteLine("Distância da viagem: " + (distancia = velocidadeMed * horas) + " Kilometros");

            /* calculamos a quantidade de combustível da viagem
            Considerando que o carro faz 12km/litro      */
            qdeCombustivel = distancia / mediaKmLitro;

            // usamos Math.Round() para permitir que somente seja exibido 3 casas decimais após o ponto
            Console.WriteLine("Considerando que seu carro faz 12km/Litro, Para essa viagem você precisa: " + Math.Round(qdeCombustivel, 3) + " litros de combustível");

        }
    }
}
