using System;
using System.Globalization;
using System.Threading;

class DoubleDowns
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n = int.Parse(Console.ReadLine());
        int[] nums = new int[n];
        int vertical = 0;
        int right = 0;
        int left = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int bit = 0; bit < 31; bit++)
            {
                int num1Bit = nums[i] >> bit & 1;
                int num2Bit = nums[i + 1] >> bit & 1;
                if (num1Bit == 1 && num2Bit == 1)
                {
                    vertical++;
                }
            }
            for (int bit = 1; bit < 31; bit++)
            {
                int num1Bit = nums[i] >> bit & 1;
                int num2Bit = nums[i + 1] >> bit - 1 & 1;
                if (num1Bit == 1 && num2Bit == 1)
                {
                    right++;
                }
            }
            for (int bit = 0; bit < 30; bit++)
            {
                int num1Bit = nums[i] >> bit & 1;
                int num2Bit = nums[i + 1] >> bit + 1 & 1;
                if (num1Bit == 1 && num2Bit == 1)
                {
                    left++;
                }
            }
        }
        Console.WriteLine(right);
        Console.WriteLine(left);
        Console.WriteLine(vertical);
    }
}
