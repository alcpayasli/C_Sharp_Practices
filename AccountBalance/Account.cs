using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Account
{
    public string Name { get; set; }
    private decimal balance;

    public Account(string accountName, decimal accountBalance)
    {
        Name = accountName;
        Balance = accountBalance;
    }

    public decimal Balance
    {
        get
        {
            return balance;
        }
        private set
        {
            if (value > 0.0m)
            {
                balance = value;
            }
        }
    }

    public void Deposit(decimal depositAmount)
    {
        if (depositAmount > 0.0m)
        {
            Balance = Balance + depositAmount;
        }
    }
}