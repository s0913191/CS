using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("整数を入力してください");
        var x = int.Parse(Console.ReadLine());
        var y = x * x;
        Console.WriteLine("{0} * {0} = {1}",x,y);

    }


}

