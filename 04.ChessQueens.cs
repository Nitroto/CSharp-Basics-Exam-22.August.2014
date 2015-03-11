using System;
using System.Globalization;
using System.Threading;

class ChessQueens
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        bool validPosition = false;
        char[] letters = new char[n];
        for (int i = 0; i < n; i++)
        {
            letters[i] = (char)('a' + i);
        }
        for (int q1x = 0; q1x < n;q1x++)
        {
            for (int q1y = 0; q1y < n; q1y++)
            {
                for (int q2x = 0; q2x < n; q2x++)
                {
                    for (int q2y = 0; q2y < n; q2y++)
                    {
                        bool hLine = q1x == q2x && Math.Abs(q1y - q2y) == (d + 1);
                        bool vLine = q1y == q2y && Math.Abs(q1x - q2x) == (d + 1);
                        bool dLine = Math.Abs(q1x - q2x) == (d + 1) && Math.Abs(q1y - q2y) == (d + 1);
                        if (hLine||vLine||dLine)
                        {
                            Console.WriteLine("{0}{1} - {2}{3}",letters[q1x],(q1y+1), letters[q2x], (q2y+1));
                            validPosition = true;
                        }
                    }
                }
            }
        }
        if (!validPosition)
        {
            Console.WriteLine("No valid positions");
        }
    }
}
