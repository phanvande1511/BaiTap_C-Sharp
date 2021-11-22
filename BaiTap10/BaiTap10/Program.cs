using System;

namespace BaiTap10
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Cac so le tu 1 - 99 la: ");
            Console.ReadKey();
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("\t {0} \n", i);
                }
            }
        }
    }
}
