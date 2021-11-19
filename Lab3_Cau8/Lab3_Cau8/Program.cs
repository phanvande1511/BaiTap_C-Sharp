using System;

namespace Lab3_Cau8
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhap vao so thu nhat: ");
            float nSo1 = System.Single.Parse(Console.ReadLine());
            Console.Write("Nhap vao so thu hai: ");
            float nSo2 = System.Single.Parse(Console.ReadLine());
            Console.WriteLine("\tMENU");
            Console.WriteLine("==================");
            Console.WriteLine("+");
            Console.WriteLine("-");
            Console.WriteLine("*");
            Console.WriteLine(":");
            Console.WriteLine("==================");

            float tong = nSo1 + nSo2;
            float hieu = nSo1 - nSo2;
            float tich = nSo1 * nSo2;
            float thuong = nSo1 / nSo2;

            Console.Write("Chon: ");
            char pheptinh =  Convert.ToChar(Console.ReadLine());
            byte ascii = (byte)pheptinh;

            if (ascii == 43)
            {
                Console.WriteLine("Tong: {0} + {1} = {2}", nSo1, nSo2, tong);
            } else if (ascii == 45)
            {
                Console.WriteLine("Hieu: {0} - {1} = {2}", nSo1, nSo2, hieu);
            } else if (ascii == 42)
            {
                Console.WriteLine("Tich: {0} * {1} = {2}", nSo1, nSo2, tich);
            } else if (ascii == 47)
            {
                Console.WriteLine("Thuong: {0} / {1} = {2}", nSo1, nSo2, thuong);
            } else
            {
                Console.WriteLine("Nhap sai phep toan");
            }
        }
    }
}
