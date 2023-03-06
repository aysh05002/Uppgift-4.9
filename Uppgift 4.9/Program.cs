using System;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Skriv ett tal för sidlängden till triangeln");
        int x = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i <= x; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}