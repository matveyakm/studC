using System;

namespace studB
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            double average = 0;
            bool isFirst = true;
            for (double R = 10000000; R >= 3000000; R--) // for (double R = 10000000; R >= 3000000; R--)
            {
                if (isPrime(R) == true && isPrime(R - 2) == true)
                {
                    count++;
                    if (isFirst == true)
                    {
                        isFirst = false;
                        average = (R + (R - 2)) / 2;
                        Console.WriteLine(R);
                    }
                }
            }

            Console.WriteLine(count + "  " + average);
        }
        static bool isPrime(double x)
        {
            for (int y = 2; y <= Math.Sqrt(x); y++)
            {
                if (x % y == 0) return false;
            }
            return true;

        }
    }
}
