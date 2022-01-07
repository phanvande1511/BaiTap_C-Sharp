using System;
using System.Collections;

namespace Lab9_Cau5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            Product product = new Product();

            ArrayList PRODUCT = new ArrayList();
            PRODUCT.Add(product);

            infor();

            int choose = 0;

            do
            {
                Console.Write("Ban muon chon muc nao: ");
                choose = int.Parse(Console.ReadLine());

                switch(choose)
                {
                    //case 1:
                    //    Console.WriteLine("\n\tKhoi Tao Danh Sach");
                    //    foreach (Product temp in PRODUCT)
                    //    {
                    //    }
                    //    Console.WriteLine();
                    //    break;
                    case 2:
                        product.input();
                        break;
                    case 3:
                        
                        break;
                    case 4:
                        foreach(Product temp in PRODUCT)
                        {
                            temp.information();
                        }
                        break;
                }
            } while (choose >= 1 && choose <= 8);

        }

        static void infor()
        {
            Console.WriteLine("Chuong trinh quan ly danh sach san pham SHOP ABC");
            Console.WriteLine("================================================");
            Console.WriteLine("1. Khoi tao danh sach");
            Console.WriteLine("2. Them 1 san pham vao danh sach");
            Console.WriteLine("3. Xoa 1 san pham ra khoi danh sach");
            Console.WriteLine("4. Duyet danh sach");
            Console.WriteLine("5. Tim thong tin san pham theo ten");
            Console.WriteLine("6. Tim thong tin san pham theo gia");
            Console.WriteLine("7. Tim thong tin san pham theo khoang gia");
            Console.WriteLine("8. Sap xep danh sach giam dan theo gia ban");
            Console.WriteLine("0. Thoat\n");
            Console.WriteLine("\t------------------------\n");
        }
    }
}
