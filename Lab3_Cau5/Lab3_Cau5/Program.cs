using System;

namespace Lab3_Cau5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhap chieu dai quang duong: ");
            int km = System.Int32.Parse(Console.ReadLine());

            float tien1 = 1 * 15000;
            float tien2 = (tien1) + ((km - 1) * 13500);
            float tien3 = ((1 * 15000) + (4 * 13500)) + ((km - 5) * 11000);
            float tien4 = tien3 * 0.9f; 

            if (km <= 1 && km > 0)
            {
                Console.WriteLine("Tong tien: {0} dong", tien1);
            } else if (km > 1 && km <= 5)
            {
                Console.WriteLine("Tong tien: {0} dong", tien2);
            } else if (km > 5 && km < 121)
            {
                Console.WriteLine("Tong tien: {0} dong", tien3);
            } else if (km > 120)
            {
                Console.WriteLine("Tong tien: {0} dong", tien4);
            } else
            {
                Console.WriteLine("Da di dau ma doi tinh tien");
            }
        }
    }
}
