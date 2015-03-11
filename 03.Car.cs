using System;
using System.Globalization;
using System.Threading;

class Car
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n = int.Parse(Console.ReadLine());
        int spacesBefore = n;
        int spacesMiddle = n;
        Console.Write(new string('.', spacesBefore));
        Console.Write(new string('*', spacesMiddle));
        Console.Write(new string('.', spacesBefore));
        Console.WriteLine();
        spacesBefore--;
        for (int i = 0; i < n/2 - 1; i++)
        {
            Console.Write(new string('.', spacesBefore));
            Console.Write('*');
            Console.Write(new string('.', spacesMiddle));
            Console.Write('*');
            Console.Write(new string('.', spacesBefore));
            Console.WriteLine();
            spacesBefore--;
            spacesMiddle += 2;
        }
        Console.Write(new string('*', (n/2+1)));
        Console.Write(new string('.', spacesMiddle));
        Console.Write(new string('*', (n / 2 + 1)));
        Console.WriteLine();
        for (int i = 0; i < (n/2- 2); i++)
        {
            Console.Write('*');
            Console.Write(new string('.', (3*n-2)));
            Console.Write('*');
            Console.WriteLine();
        }
        Console.Write(new string('*', 3*n));
        Console.WriteLine();
        for (int i = 0; i < (n / 2-2); i++)
        {
            Console.Write(new string('.', (n / 2)));
            Console.Write('*');
            Console.Write(new string('.', (n / 2-1)));
            Console.Write('*');
            Console.Write(new string('.', (n - 2)));
            Console.Write('*');
            Console.Write(new string('.', (n / 2 - 1)));
            Console.Write('*');
            Console.Write(new string('.', (n / 2)));
            Console.WriteLine();
        }
        Console.Write(new string('.', (n / 2)));
        Console.Write(new string('*',n/2+1));
        Console.Write(new string('.', (n - 2)));
        Console.Write(new string('*', n / 2 + 1));
        Console.Write(new string('.', (n / 2)));
        Console.WriteLine();
    }
}
