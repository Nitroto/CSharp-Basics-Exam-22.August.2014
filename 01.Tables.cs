using System;
using System.Globalization;
using System.Threading;

class Tables
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        long firstBundle = long.Parse(Console.ReadLine());
        long secondBundle = long.Parse(Console.ReadLine());
        long thirdBundle = long.Parse(Console.ReadLine());
        long forthBundle = long.Parse(Console.ReadLine());
        long tableTops = long.Parse(Console.ReadLine());
        long tablesToBeMade = long.Parse(Console.ReadLine());
        long legs = (1 * firstBundle) + (2 * secondBundle) + (3 * thirdBundle) + (4 * forthBundle);
        long madedTables = Math.Min((legs/4),tableTops);
        if (madedTables > tablesToBeMade)
        {
            long topsLeft = tableTops - tablesToBeMade;
            long legsLeft = legs - (tablesToBeMade * 4);
            Console.WriteLine("more: {0}", madedTables - tablesToBeMade);
            Console.WriteLine("tops left: {0}, legs left: {1}",topsLeft, legsLeft);
        }
        else if (madedTables < tablesToBeMade)
        {
            long deficit = (madedTables - tablesToBeMade);
            long topsLeft = tablesToBeMade >= tableTops ? (tablesToBeMade - tableTops) : 0;
            long legsLeft = tablesToBeMade * 4 >= legs ? ((tablesToBeMade * 4) - legs) : 0;
            Console.WriteLine("less: {0}", deficit);
            Console.WriteLine("tops needed: {0}, legs needed: {1}", topsLeft, legsLeft);
        }
        else
        {
            Console.WriteLine("Just enough tables made: {0}", madedTables);
        }
    }
}
