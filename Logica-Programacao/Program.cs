using System;
using System.Globalization;

namespace Logica_Programacao
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 10.40534;
            int idade = 30;
            string nome = "Maria";
            Console.Write("Olá mundo!");

            Console.WriteLine();
            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine(x.ToString("F4"));
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("RESULTADO = " + x);
            Console.WriteLine("O valor do troco é " + x + " reais");
            Console.WriteLine("O valor do troco é " + x.ToString("F2") + " reais");
            Console.WriteLine();
            Console.WriteLine("O meu nome é " + nome + " tenho " + idade + " anos");
            Console.ReadLine();
        }
    }
}
