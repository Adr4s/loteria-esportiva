using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] A = { 0, 0, 0, 1, 1, 0, 1, 0, 0, 0, 0 };

        int resultado = CalcularMinimoSaltos(A);

        if (resultado != -1)
            Console.WriteLine($"Número mínimo de saltos: {resultado}");
        else
            Console.WriteLine("O sapo não consegue atravessar.");
    }

    static int CalcularMinimoSaltos(int[] A)
    {
        int N = A.Length;

        List<int> fibs = GerarFibs(N + 1);

        Queue<(int posicao, int saltos)> fila =
            new Queue<(int, int)>();

        bool[] visitado = new bool[N];

        fila.Enqueue((-1, 0));

        while (fila.Count > 0)
        {
            var atual = fila.Dequeue();

            foreach (int f in fibs)
            {
                int prox = atual.posicao + f;

                if (prox == N)
                    return atual.saltos + 1;

                if (prox >= 0 &&
                    prox < N &&
                    A[prox] == 1 &&
                    !visitado[prox])
                {
                    visitado[prox] = true;

                    fila.Enqueue((prox,
                                   atual.saltos + 1));
                }
            }
        }

        return -1;
    }

    static List<int> GerarFibs(int limite)
    {
        List<int> fibs = new List<int>();

        int a = 1;
        int b = 1;

        while (b <= limite)
        {
            fibs.Add(b);

            int temp = a + b;
            a = b;
            b = temp;
        }

        fibs.Reverse();

        return fibs;
    }
}