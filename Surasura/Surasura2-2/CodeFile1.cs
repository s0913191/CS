using System;

class Program
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = (x > 5) ? 10 : 0;
        int z = (y == 10) ? 1000 : 2;
        Console.WriteLine("{0},{1}", y,z);
    }
}
