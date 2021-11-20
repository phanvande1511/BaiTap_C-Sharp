using System;

namespace Lab3_Cau9
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double a;
            double b;
            double c;

            Console.WriteLine("- Nhap toa do diem A");
            Console.Write("\tNhap toa do xA: ");
            int xA = int.Parse(Console.ReadLine());
            Console.Write("\tNhap toa do yA: ");
            int yA = int.Parse(Console.ReadLine());

            Console.WriteLine("-------------------------");

            Console.WriteLine("- Nhap toa do diem B");
            Console.Write("\tNhap toa do xB: ");
            int xB = int.Parse(Console.ReadLine());
            Console.Write("\tNhap toa do yB: ");
            int yB = int.Parse(Console.ReadLine());

            Console.WriteLine("-------------------------");

            Console.WriteLine("- Nhap toa do diem C");
            Console.Write("\tNhap toa do xC: ");
            int xC = int.Parse(Console.ReadLine());
            Console.Write("\tNhap toa do yC: ");
            int yC = int.Parse(Console.ReadLine());

            a = (double)(Math.Sqrt(((xB - xA) * (xB - xA)) + ((yB - yA) * (yB - yA))));
            b = (double)(Math.Sqrt(((xC - xB) * (xC - xB)) + ((yC - yB) * (yC - yB))));
            c = (double)(Math.Sqrt(((xA - xC) * (xA - xC)) + ((yA - yC) * (yA - yC))));

            Console.WriteLine("-------------------------");

            Console.WriteLine("Do dai doan AB la: {0}", a);
            Console.WriteLine("Do dai doan BC la: {0}", b);
            Console.WriteLine("Do dai doan CA la: {0}", c);

            double temp = 0;
            double max = 0;
            double min = 0;
//Tim bien lon thu hai
            if ((b > a && a < c) || (c > a && a < b))
            {
                temp = a;
            }

            if ((a > b && b < c) ||(c > b && b < a))
            {
                temp = b;
            }

            if ((b > c && c < a) || (a > c && c < b))
            {
                temp = c;
            }
//Tim bien lon nhat
            if (a > b && a > c)
            {
                max = a;
            }

            if (b > a && b > c)
            {
                max = b;
            }

            if (c > a && c > b)
            {
                max = c;
            }
//Tim bien nho nhat
            if (a < b && a < c)
            {
                min = a;
            }

            if (b < a && b < c)
            {
                min = b;
            }

            if (c < a && c < b)
            {
                min = c;
            }

            Console.WriteLine("-------------------------");
            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("Day khong phai la hinh tam giac");
            } else if (a == c && a == b && b == c)
            {
                Console.WriteLine("Day la tam giac deu");
            } else if (max == Math.Sqrt((temp * temp) + (min * min)))
            {
                Console.WriteLine("Day la tam giac vuong");
            } else if (a == b || a == c || b == c)
            {
                Console.WriteLine("Day la tam giac can");
            } else if (Math.Abs(a - b) < c && Math.Abs(a - c) < b && Math.Abs(c - b) < a)
            {
                Console.WriteLine("Day la tam giac thuong");
            } else
            {
                Console.WriteLine("Day khong phai la hinh tam giac");
            }
        }
    }
}
