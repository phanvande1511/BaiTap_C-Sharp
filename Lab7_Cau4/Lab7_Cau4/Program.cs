using System;

namespace Lab7_Cau4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Account accountName = new Account();
            double temp = 0;
            double temp1 = 0;

            accountName.NAME();
            dividingLine();
            accountName.SendMoney();

            if (accountName.MoneySend() < 0)
            {
                Console.WriteLine("Error!!!");
            } else
            {
                temp = accountName.MoneySend();
            }

            accountName.WithdrawMoney();

            if (accountName.MoneyWithdraw() < 0 || accountName.MoneyWithdraw() > 200000)
            {
                Console.WriteLine("Error!!!");
            } else
            {
                temp1 = accountName.MoneyWithdraw();
            }
            dividingLine();
            Console.WriteLine("After Send And Withdraw");
            accountName.Name();

        }

        static void dividingLine()
        {
            Console.WriteLine("\t-----");
        }
    }
}
