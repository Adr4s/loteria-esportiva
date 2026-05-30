using System;

class Program
{
    static void Main()
    {
        int X = 10;
        int Y = 85;
        int D = 30;

        int pulos = (Y - X + D - 1) / D;

        Console.WriteLine("Número mínimo de pulos: " + pulos);
    }
}