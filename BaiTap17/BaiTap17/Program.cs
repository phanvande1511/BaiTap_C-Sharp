using System;

namespace BaiTap17
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Multiples of 3: ");
            for (int i = 3; i <= 300; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
