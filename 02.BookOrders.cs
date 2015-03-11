using System;
using System.Globalization;
using System.Threading;
class BookOrders
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int numberOfOrders = int.Parse(Console.ReadLine());
        double totalPrice = 0.0;
        int totalBooks = 0;
        for (int i = 0; i < numberOfOrders; i++)
        {
            int numberOfPackets = int.Parse(Console.ReadLine());
            int booksPerPacket = int.Parse(Console.ReadLine());
            double bookPrice = double.Parse(Console.ReadLine());
            int discount = 0;
            if (numberOfPackets>9&&numberOfPackets<=109)
            {
                discount = ((numberOfPackets / 10) + 4);
            }
            else if (numberOfPackets >109)
            {
                discount = 15;
            }
            double realPrice = bookPrice - (discount/100.0 * bookPrice);
            int booksForCurrentOrder = booksPerPacket * numberOfPackets;
            double currentOrderPrice = booksForCurrentOrder * realPrice;
            totalBooks += booksForCurrentOrder;
            totalPrice += currentOrderPrice;
        }
        Console.WriteLine(totalBooks);
        Console.WriteLine("{0:F2}",totalPrice);
    }
}
