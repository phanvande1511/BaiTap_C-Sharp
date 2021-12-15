using System;
namespace Lab7_Cau1
{
    public class MARK
    {
        private string TenMH;
        private float DiemLT;
        private float DiemTH;

        public MARK(string tenMH, float DiemLT, float DiemTH)
        {
            this.TenMH = tenMH;
            this.DiemLT = DiemLT;
            this.DiemTH = DiemTH;
        }

        public void XuatTT()
        {
            Console.WriteLine("\tTHONG TIN MON HOC");
            Console.WriteLine("=====================================");
            Console.WriteLine("Ten MH: {0}", TenMH);
            Console.WriteLine("DiemLT = {0}", DiemLT);
            Console.WriteLine("DiemTH = {0}", DiemTH);
            Console.WriteLine("DiemTB = {0}", ((DiemLT + DiemTH) / 2));
        }
    }
}
