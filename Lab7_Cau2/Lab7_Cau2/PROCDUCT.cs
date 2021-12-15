using System;
namespace Lab7_Cau2
{
    public class PROCDUCT
    {
        private int stt;
        private string tenSP;
        private int soluong;
        private int giaban;

        public PROCDUCT(int stt, string tenSP, int soluong, int giaban)
        {
            this.stt = stt;
            this.tenSP = tenSP;
            this.soluong = soluong;
            this.giaban = giaban;
        }

        public double TinhTongTien(int soluong, int giaban)
        {
            return soluong * giaban;
        }

        int sum(int soluong, int giaban)
        {
            int sum = soluong * giaban;
            return sum;
        }

        public void total()
        {
            sum(soluong, giaban);
        }

        public void InTT()
        {

            String st = String.Format("| {0} |", centeredString($"{stt}", -10))
          + String.Format("{0}|", centeredString($"{tenSP}", 20))
          + String.Format("{0}|", centeredString($"{soluong}", 10))
          + String.Format("{0}|", centeredString($"{giaban}", 10))
          + String.Format("{0}|", centeredString($"{sum(soluong, giaban)}", 10));
            Console.WriteLine(st);
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
