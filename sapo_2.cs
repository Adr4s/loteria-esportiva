using System;

class Program
{
    static void Main()
    {
        int N = 5;
        int M = 5;
        int D = 2;

        int linha = N - 1;
        int coluna = 0;

        Console.WriteLine("Caminho do sapo:");

        Console.Write("(" + linha + "," + coluna + ")");

        while (linha - D >= 0)
        {
            linha -= D;
            Console.Write(" -> (" + linha + "," + coluna + ")");
        }

        while (coluna + D < M)
        {
            coluna += D;
            Console.Write(" -> (" + linha + "," + coluna + ")");
        }

        Console.WriteLine();
    }
}