using System;

public class MainClass
{
    public static void Main()
    {
        int height = int.Parse(Console.ReadLine());
        int space = 0;
        int star = 1;
        while (height > 0)
        {
            space = height - 1;
            while (space > 0)
            {
                Console.Write(" ");
                space--;
            }
            for (int i = star; i > 0; i--)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            star +=2;
            height--;
        }
    }
}