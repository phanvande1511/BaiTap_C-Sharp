using System;

namespace Lab3_Cau5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhap chieu dai quang duong: ");
            int km = System.Int32.Parse(Console.ReadLine());

            int tien1 = 1 * 15000;
            int tien2 = tien1 + ((km - 1) * 13500);
            int tien3 = tien2 + ((km - 5) * 11000);

            if (km <= 1 && km > 0)
            {
                Console.WriteLine("Tong tien: {0} dong", tien1);
            } else if (km > 1 && km <= 5)
            {
                Console.WriteLine("Tong tien: {0} dong", tien2);
            } else if (km >= 6)
            {
                Console.WriteLine("Tong tien: {0} dong", tien3);
            } else
            {
                Console.WriteLine("Da di dau ma doi tinh tien");
            }
        }
    }
}
