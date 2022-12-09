using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    class BankAccount
    {
        public string name;
        private string accountNumber;
        private double balance;

        public BankAccount()
        {
            this.name = "";
            this.accountNumber = "";
            this.balance = 0.0;
        }

        public BankAccount(string name)
        {
            this.name = name;
            createAccountNo();
            this.balance = 0.0;
        }

        public void createAccountNo()
        {
            string accountNo = "";
            Random randomNo = new Random();

            for (int i = 0; i < 10; i++)
            {
                accountNo += randomNo.Next(0, 10);
            }
            
            accountNumber = accountNo;
        }

        public string getAccountNo()
        {
            return accountNumber;
        }

        public double getBalance()
        {
            return balance;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }

        public void setBalance(double amount)
        {
            this.balance = amount;
        }

        public void deposit(double amount)
        {
            this.balance += amount;
        }

        public void withdraw(double amount)
        {
            this.balance -= amount;
        }

        /*bool isDeposit = true;
        private string Name { get; set; }
        private string AccountNumber { get; }
        private double Balance;

        public double balance()
        {
            get
            {
                return Balance;
            }

            set{
                if (isDeposit)
                {
                    if (Balance - value > 0)
                    {
                        Balance = Balance - value;
                    }
                    else
                    {
                        MessageBox.Show("Insufficient Funds")
                    }
                }
                else
                {
                    Balance += value;
                }
            }
        }

        private void Deposit(double depositAmount)
        {
            isDeposit = false;
            Balance = depositAmount;
        }

        private void Withdraw(double withdrawAmount)
        {
            Balance = withdrawAmount;
        }

        public string AccountBalance()
        {

        }*/

        /*        bool IsDeposit = true;
                private string Name { get; set; }
                private string AccountNumber { get; }
                private double Balance;

                public double balance
                {

                    get { return Balance; }


                    set
                    {
                        if (IsDeposit)
                        {
                            if (Balance - value > 0)
                            {
                                Balance = Balance - value;
                            }
                            else
                            {
                                MessageBox.Show("Insufficient Funds!!!");
                            }
                        }
                        else
                        {
                            Balance = Balance + value;
                        }

                    }

                }

                public BankAccount(string Name, string AccountNumber)
                {
                    this.AccountNumber = AccountNumber;
                    this.Name = Name;
                    balance = 0;
                }

                public void Withdraw(double withdrawAmount)
                {
                    balance = withdrawAmount;

                }


                public void Deposit(double depositAmount)
                {
                    IsDeposit = false;
                    balance = depositAmount;

                }


                public string AccountBalance()
                {

                    return Name + AccountNumber + balance;

                }*/

    }
}
