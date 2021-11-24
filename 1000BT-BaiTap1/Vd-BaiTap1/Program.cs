using System;

namespace VdBaiTap1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int tong = 0;
            Console.Write("Nhap vao so nguyen N: ");
            int n = int.Parse(Console.ReadLine());

            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    tong += i;
                }
                Console.Write("Tong tu 1 den {0} la: {1}", n, tong);
            } else
            {
                Console.WriteLine("Loi");
            }
        }
    }
}
