using System;

namespace BaiTap9
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i < 20; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("Tong cua 10 so chan dau tien: {0}", sum);
        }
    }
}
