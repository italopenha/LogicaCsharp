﻿
namespace TesteDeSelecao1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int a = int.Parse(valores[0]);
            int b = int.Parse(valores[1]);
            int c = int.Parse(valores[2]);
            int d = int.Parse(valores[3]);

            int somaCD = c + d;
            int somaAB = a + b;

            if (b > c && d > a && somaCD > somaAB && c > 0 && d > 0 && a % 2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}