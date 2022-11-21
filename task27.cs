using System;

public class MainClass
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int i = 0;
        while (num > 0)
        {
            i = num % 10 + i;
            num /= 10;
        }
        Console.WriteLine(i);
    }
}