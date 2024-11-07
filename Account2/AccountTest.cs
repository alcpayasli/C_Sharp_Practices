using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AccountTest
{
    static void Main()
    {
        Account myAccount = new Account();
        Console.Write("Enter the name:");
        string theName = Console.ReadLine();
        myAccount.Name = theName;
        Console.WriteLine($"Account name: {myAccount.Name}");
    }
}
