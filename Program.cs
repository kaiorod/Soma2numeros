using System;

namespace Soma2numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, soma;

            Console.Write("Digite o primeiro número : ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("\nDigite o segundo número : ");
            n2 = int.Parse(Console.ReadLine());

            soma = n1 + n2;

            Console.Write("\nSoma : ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(soma);
            Console.ResetColor();


        }
    }
}
