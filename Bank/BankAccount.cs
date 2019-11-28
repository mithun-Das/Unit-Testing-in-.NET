using System;

namespace BankAccountNS
{
    public class BankAccount
    {
        private readonly string m_customerName;
        private double m_balance;

        private BankAccount() { }

        public BankAccount(string customerName, double balance)
        {
            m_customerName = customerName;
            m_balance = balance;
        }

        public string CustomerName
        {
            get { return m_customerName; }
        }

        public double Balance
        {
            get { return m_balance; }
        }

        public void Debit(double amount)
        {
            if(amount > m_balance || amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
                //throw new ApplicationException("amount");
            }

            m_balance -= amount;
        }

        public void Credit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            m_balance += amount;
        }

        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount();

            ba.Credit(5.77);
            ba.Debit(11.22);
            Console.WriteLine("Current balance is {0}", ba.Balance);
        }
    }
}
