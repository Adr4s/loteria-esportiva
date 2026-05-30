using System;

class Program
{
    static void Main()
    {
        int[,] apostas = new int[13, 3];
        int[,] resultados = new int[13, 3];

        int pontos = 0;

        Console.WriteLine("=== LOTERIA ESPORTIVA ===");

        Console.WriteLine("\nDigite suas apostas");

        for (int jogo = 0; jogo < 13; jogo++)
        {
            Console.WriteLine("\nJogo " + (jogo + 1));

            Console.Write("Vitória do time 1 (0 ou 1): ");
            apostas[jogo, 0] = int.Parse(Console.ReadLine());

            Console.Write("Empate (0 ou 1): ");
            apostas[jogo, 1] = int.Parse(Console.ReadLine());

            Console.Write("Vitória do time 2 (0 ou 1): ");
            apostas[jogo, 2] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nDigite os resultados oficiais");

        for (int jogo = 0; jogo < 13; jogo++)
        {
            Console.WriteLine("\nResultado do jogo " + (jogo + 1));

            Console.Write("Time 1 venceu? (0 ou 1): ");
            resultados[jogo, 0] = int.Parse(Console.ReadLine());

            Console.Write("Empate? (0 ou 1): ");
            resultados[jogo, 1] = int.Parse(Console.ReadLine());

            Console.Write("Time 2 venceu? (0 ou 1): ");
            resultados[jogo, 2] = int.Parse(Console.ReadLine());
        }

        for (int jogo = 0; jogo < 13; jogo++)
        {
            for (int coluna = 0; coluna < 3; coluna++)
            {
                if (apostas[jogo, coluna] == 1 && resultados[jogo, coluna] == 1)
                {
                    pontos++;
                    break;
                }
            }
        }

        Console.WriteLine("\nTotal de pontos: " + pontos);

        Console.ReadKey();
    }
}