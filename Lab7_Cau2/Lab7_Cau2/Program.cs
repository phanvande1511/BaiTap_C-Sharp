using System;

namespace Lab7_Cau2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            PROCDUCT temp1 = new PROCDUCT(1, "May In", 5, 150);
            PROCDUCT temp2 = new PROCDUCT(2, "Man Hinh LCD", 10, 350);
            PROCDUCT temp3 = new PROCDUCT(3, "Chuot Mitsumi", 25, 10);
            PROCDUCT temp4 = new PROCDUCT(4, "Ban Phim", 10, 12);
            PROCDUCT temp5 = new PROCDUCT(5, "USB 2G", 100, 13);

            double sum = temp1.TinhTongTien(5, 150) + temp2.TinhTongTien(10, 350) + temp3.TinhTongTien(25, 10) + temp4.TinhTongTien(10, 12) + temp5.TinhTongTien(100, 13);
            String tongtien = String.Format("|{0, 54}   |", sum);

            String st = String.Format("|{0}|", centeredString("STT", -10))
              + String.Format("{0}|", centeredString("Ten san pham", 20))
              + String.Format("{0}|", centeredString(" So luong ", -20))
              + String.Format("{0}|", centeredString(" Don gia  ", -20))
              + String.Format("{0}|", centeredString(" Tongtien ", -20));

            Console.WriteLine("DANH MUC SAN PHAM");
            ngancach();
            Console.WriteLine();
            Console.WriteLine(st);
            ngancach();
            Console.WriteLine();
            temp1.InTT();
            temp2.InTT();
            temp3.InTT();
            temp4.InTT();
            temp5.InTT();
            ngancach();
            Console.WriteLine();
            Console.WriteLine(tongtien);
            ngancach();
        }

        static void ngancach()
        {
            for (int i = 0; i < 59; i++)
            {
                Console.Write("-");
            }
        }

        static string centeredString(string s, int width)
        {
            if (s.Length >= width)
            {
                return s;
            }

            int leftPadding = (width - s.Length) / 2;
            int rightPadding = width - s.Length - leftPadding;

            return new string(' ', leftPadding) + s + new string(' ', rightPadding);
        }
    }
}
