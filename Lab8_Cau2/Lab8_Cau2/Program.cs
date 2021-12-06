using System;

namespace Lab8_Cau2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhap vao 1 chuoi: ");
            string chuoi = Console.ReadLine();
            Console.WriteLine("So ki tu trong chuoi la: {0}", DemKiTu(chuoi));
            NgAmPAm(chuoi);
            Dem(chuoi);
        }

        static int DemKiTu(string chuoi)// dem ki tu co trong chuoi
        {
            int dem = 0;
            for (int i = 0; i < chuoi.Length; i++)
            {
                dem++;
            }
            return dem;
        }

        static void NgAmPAm(string chuoi)// dem so nguyen am va phu am
        { 
            int dem1 = 0;
            int dem2 = 0;
            for (int i = 0; i < chuoi.Length; i++)
            {
                if (chuoi[i] == 85 || chuoi[i] == 117 || chuoi[i] == 69 || chuoi[i] == 101 || chuoi[i] == 79 || chuoi[i] == 111 || chuoi[i] == 65 || chuoi[i] == 97 || chuoi[i] == 73 || chuoi[i] == 105)
                {
                    dem1++;
                }
                if (chuoi[i] >= 66 && chuoi[i] <= 68 || chuoi[i] >= 70 && chuoi[i] <= 72 || chuoi[i] >= 74 && chuoi[i] <= 78 || chuoi[i] >= 80 && chuoi[i] <= 84 || chuoi[i] >= 86 && chuoi[i] <= 90 || chuoi[i] >= 98 && chuoi[i] <= 100 || chuoi[i] >= 102 && chuoi[i] <= 104 || chuoi[i] >= 106 && chuoi[i] <= 110 || chuoi[i] >= 112 && chuoi[i] <= 116 || chuoi[i] >= 118 && chuoi[i] <= 122)
                {
                    dem2++;
                }
            }
            Console.WriteLine("So ki tu nguyen am la: {0}", dem1);
            Console.WriteLine("So ki tu phu am la: {0}", dem2);
        }

        static void Dem(string chuoi)// dem so tu co trong chuoi
        {
            int dem = 0;
            chuoi.Trim();// xoa khoang trang va cuoi
            for (int i = 0; i < chuoi.Length; i++)// xac dinh vi tri dau cach 
            {
                if (chuoi[i] == 32 && chuoi[i + 1] != 32) 
                {
                    dem++;
                }
            }
            Console.WriteLine("So tu trong chuoi la: {0}", (dem + 1));
        }
    }
}
