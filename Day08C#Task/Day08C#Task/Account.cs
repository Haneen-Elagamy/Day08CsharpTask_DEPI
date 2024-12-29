using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08C_Task
{
    internal struct Account
    {
        #region fields
        private int accountId;
        private string accountHolder;
        private decimal balance;
        #endregion

        #region properties
        public int AccountId
        {
            get { return accountId; }
            set
            {
                if (value > 0)
                    accountId = value;
                else
                    throw new ArgumentException("Account Id must be positive");
            }
        }

        public string AccountHolder
        {
            get { return accountHolder; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    accountHolder = value;
                else
                    throw new ArgumentException("AccountHolder cannot be empty");
            }
        }

        public decimal Balance
        {
            get { return balance; }
            set
            {
                if (value >= 0)
                    balance = value;
                else
                    throw new ArgumentException("Balance cannot be negative");
            }
        }

        #endregion

        #region Methods
        public void DisplayAccountDetails()
        {
            Console.WriteLine($"Account Id is {AccountId}");
            Console.WriteLine($"Account Holder is {AccountHolder}");
            Console.WriteLine($"Balance is {Balance}");
        } 
        #endregion 

    }
}
