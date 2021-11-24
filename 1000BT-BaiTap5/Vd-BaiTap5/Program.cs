using System;

namespace VdBaiTap5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double tong = 0.0;
            Console.Write("Nhap vao so nguyen N: ");
            int n = int.Parse(Console.ReadLine());

            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    tong += 1 / (float)((i * 2) + 1);
                }
                Console.WriteLine("Tong tu 1 den 1/{0} la: {1}", n, tong);
            }
            else
            {
                Console.WriteLine("Loi");
            }
        }
    }
}
