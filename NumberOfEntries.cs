using System;

class PrintOneToN
{
    static void Main()
    {
        int N;
        do
        {
            Console.Write("Input an Int = ");
        } while (!int.TryParse(Console.ReadLine(), out N) || N <= 0);
        for (int i = 1; i <= N; i++)
        {
            Console.WriteLine(i);
        }
    }
}
