using System;
namespace Lab9_Cau5
{
    public class Product
    {
        private string name;
        private string function;
        private double cost;

        public void input()
        {
            Console.WriteLine("\n\t------------------------\n");
            Console.Write("Nhap ten Sp: ");
            name = Console.ReadLine();
            Console.Write("Dien thong tin Sp: ");
            function = Console.ReadLine();
            Console.Write("Nhap gia tien: ");
            cost = double.Parse(Console.ReadLine());
            Console.WriteLine("\n\t------------------------\n");
        }

        public void information()
        {
            Console.WriteLine("\n\t------------------------\n");
            Console.WriteLine("Ten Sp: {0}", name);
            Console.WriteLine("Thong tin Sp: {0}", function);
            Console.WriteLine("Gia tien: {0:0.0}", cost);
            Console.WriteLine("\n\t------------------------\n");
        }

        public string getName()
        {
            return name;
        }

        
    }
}
