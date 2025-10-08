// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        int[] n = new int[10];
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Número: ");
            n[i] = int.Parse(Console.ReadLine());
        }

        int maior = n[0];
        int pos = 0;

        for (int i = 1; i < 10; i++)
        {
            if (n[i] > maior)
            {
                maior = n[i];
                pos = i;
            }
        }

        Console.WriteLine("Maior valor: {0}, índice: {1}.", maior, pos);
    }
}
