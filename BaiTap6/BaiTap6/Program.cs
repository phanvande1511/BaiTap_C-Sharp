using System;

namespace BaiTap6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\tMENU");
            Console.WriteLine("===================");
            Console.WriteLine("1. Hinh tam giac");
            Console.WriteLine("2. Hinh chu nhat");
            Console.WriteLine("3. Hinh vuong");
            Console.WriteLine("4. Hinh tron");
            Console.WriteLine("===================");

            Console.Write("Chon hinh can tinh: ");
            int hinh = System.Int32.Parse(Console.ReadLine());

            switch (hinh)
            {
                case 1:
                    Console.WriteLine("\nBan da chon hinh tam giac");

                    Console.Write("\nNhap chieu dai canh a: ");
                    float tga = System.Single.Parse(Console.ReadLine());
                    Console.Write("Nhap chieu dai canh b: ");
                    float tgb = System.Single.Parse(Console.ReadLine());
                    Console.Write("Nhap chieu dai canh c: ");
                    float tgc = System.Single.Parse(Console.ReadLine());
                    Console.Write("Nhap chieu cao h: ");
                    float tgh = System.Single.Parse(Console.ReadLine());

                    float cvtg = tga + tgb + tgc;
                    float dttg = (tga * tgh) / 2;

                    Console.WriteLine("\nChu vi: P = {0} + {1} + {2} = {3}", tga, tgb, tgc, cvtg);
                    Console.WriteLine("Dien tich: S = ({0} * {1}) / 2 = {2}", tga, tgh, dttg);
                    break;
                case 2:
                    Console.WriteLine("\nBan da chon hinh chu nhat");

                    Console.Write("\nNhap chieu dai: ");
                    float cd = System.Single.Parse(Console.ReadLine());
                    Console.Write("Nhap chieu rong: ");
                    float cr = System.Single.Parse(Console.ReadLine());

                    float cvhcn = (cd + cr) * 2;
                    float dthcn = cd * cr;

                    Console.WriteLine("\nChu vi: P = ({0} + {1}) * 2 = {2}", cd, cr, cvhcn);
                    Console.WriteLine("Dien tich: S = {0} * {1} = {2}", cd, cr, dthcn);
                    break;
                case 3:
                    Console.WriteLine("\nBan da chon hinh vuong");

                    Console.Write("\nNhap chieu dai canh: ");
                    float canh = System.Single.Parse(Console.ReadLine());

                    float cvhv = canh * 4;
                    float dthv = canh * canh;

                    Console.WriteLine("\nChu vi: P = {0} * 4 = {1}", canh, cvhv);
                    Console.WriteLine("Dien tich: S = {0} * {0} = {1}", canh, dthv);
                    break;
                case 4:
                    Console.WriteLine("\nBan da chon hinh tron");

                    Console.Write("\nNhap ban kinh: ");
                    float r = System.Single.Parse(Console.ReadLine());

                    double cvht = 2 * r * Math.PI;
                    double dtht = (r * r) * Math.PI;

                    Console.WriteLine("\nChu vi: C = 2 * {0} * PI = {1}", r, cvht);
                    Console.WriteLine("Dien tich: S = ({0} * {0}) * PI = {1}", r, dtht);
                    break;
                default:
                    Console.WriteLine("Chon sai hinh roi");
                    break;
            }
        }
    }
}
