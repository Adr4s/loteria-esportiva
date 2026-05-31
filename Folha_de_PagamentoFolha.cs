using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

        double salario = 1412;
        double horasMes = 220;

        double salarioClasse1 = salario * 1.3;
        double hora = salarioClasse1 / horasMes;
        double extra = hora * 1.3;

        Console.Write("Digite quantos funcionarios: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\nFuncionario " + (i + 1));

            Console.Write("Inscricao: ");
            int inscricao = int.Parse(Console.ReadLine());

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Horas normais: ");
            double horas = double.Parse(Console.ReadLine());

            Console.Write("Horas extras: ");
            double horasExtra = double.Parse(Console.ReadLine());

            double totalNormal = horas * hora;
            double totalExtra = horasExtra * extra;

            double bruto = totalNormal + totalExtra;

            double inss = bruto * 0.11;

            double liquido = bruto - inss;

            Console.WriteLine("\nContra-cheque");
            Console.WriteLine("Inscricao: " + inscricao);
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Salario horas normais: " + totalNormal.ToString("C"));
            Console.WriteLine("Salario horas extras: " + totalExtra.ToString("C"));
            Console.WriteLine("INSS: " + inss.ToString("C"));
            Console.WriteLine("Salario liquido: " + liquido.ToString("C"));
        }
    }
}
