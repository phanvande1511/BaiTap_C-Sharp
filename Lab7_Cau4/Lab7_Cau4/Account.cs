using System;
namespace Lab7_Cau4
{
    public class Account
    {
        public Account()
        {
        }
        private int accountNumber = 1234567890;
        private string accountName = "Bill";
        private double money = 200000;
        private double extraMoney;//tien du
        private double sendMoney;// gui tien
        private double withdrawMoney;//rut tien
        private double profit = 0.045;//tien lai

        public void NAME()// nhap ten va in ten + so tien trong tk
        {
            Console.WriteLine("Name: {0}", accountName);
            Console.WriteLine("Account Number: {0}", accountNumber);
            Console.WriteLine("Current Amount: {0}", money);
        }

        double MoneyExtra()
        {
            double moneyExtra = 0;
            if (MoneySend() >= 0 && MoneyWithdraw() >= 0)
            {
                moneyExtra = (money + MoneySend()) - MoneyWithdraw();
            } else if (MoneySend() >= 0 && MoneyWithdraw() < 0)
            {
                moneyExtra = money + MoneySend();
            } else if (MoneySend() < 0 && MoneyWithdraw() >= 0)
            {
                moneyExtra = money + MoneyWithdraw();
            } else if (MoneySend() < 0 && MoneyWithdraw() < 0)
            {
                moneyExtra = money;
            }
            return moneyExtra;
        }

        public void Name()
        {
            Console.WriteLine("Name: {0}", accountName);
            Console.WriteLine("Account Number: {0}", accountNumber);
            Console.WriteLine("Extra Money: {0}", MoneyExtra());
        }

        public void SendMoney()// nhap so tien muon gui
        {
            Console.Write("Enter Money Want To Send: ");
            sendMoney = double.Parse(Console.ReadLine());
        }

        public void WithdrawMoney()// nhap so tien muon rut
        {
            Console.Write("Enter Money Want To Withdraw: ");
            withdrawMoney = double.Parse(Console.ReadLine());
        }

        public double MoneySend()
        {
            double temp = 0;
            temp = sendMoney;
            return temp;
        }

        public double MoneyWithdraw()
        {
            double temp = 0;
            temp = withdrawMoney;
            return temp;
        }
    }
}
