using System;

namespace BaiTap11
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            if (number > 0 && number <= 100)
            {
                for (int i = 1; i <= 100; i++)
                {
                    if (i % number == 0)
                    {
                        Console.WriteLine("Multiples: {0}", i);
                    }
                }
            } else
            {
                Console.WriteLine("Error!!!");
            }
        }
    }
}
