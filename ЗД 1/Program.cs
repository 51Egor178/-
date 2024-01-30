using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение M: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int n = int.Parse(Console.ReadLine());

        PrintNaturalNumbersInRange(m, n);
    }

    static void PrintNaturalNumbersInRange(int m, int n)
    {
        if (m <= n)
        {
            Console.WriteLine(m);
            PrintNaturalNumbersInRange(m + 1, n);
        }
    }
}
