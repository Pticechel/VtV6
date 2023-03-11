using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int size = 10;
        int num = 50;

        Random rand = new Random();
        List<int> list = Enumerable.Range(1, size)
                                   .Select(x => rand.Next(100))
                                   .Where(x => Math.Abs(x - num) <= 4)
                                   .ToList();

        Console.WriteLine(string.Join(", ", list));
    }
}