using System;

namespace VdBaiTap2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int tong = 0;
            Console.Write("Nhap vao 1 so nguyen N: ");
            int n = int.Parse(Console.ReadLine());

            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    tong += (i * i);
                }
                Console.WriteLine("Tong luy thua bac 2 tu 1 den {0} la: {1}", n, tong);
            } else
            {
                Console.WriteLine("Loi");
            }
        }
    }
}
