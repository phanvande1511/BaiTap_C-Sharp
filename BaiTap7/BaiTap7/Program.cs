using System;

namespace BaiTap7
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\tMENU");
            Console.WriteLine("===================");
            Console.Write("Nhap vao so nguyen a: ");
            float soA = System.Single.Parse(Console.ReadLine());
            Console.Write("Nhap vao so nguyen b: ");
            float soB = System.Single.Parse(Console.ReadLine());

            float tong = soA + soB;
            float hieu = soA - soB;
            float tich = soA * soB;
            float thuong = soA / soB;

            Console.WriteLine("\nTong: {0} + {1} = {2}", soA, soB, tong);
            Console.WriteLine("Hieu: {0} - {1} = {2}", soA, soB, hieu);
            Console.WriteLine("Tich: {0} * {1} = {2}", soA, soB, tich);
            Console.WriteLine("Thuong: {0} : {1} = {2}", soA, soB, thuong);
            Console.WriteLine("===================");
            Console.WriteLine("Ket thuc");
        }
    }
}
