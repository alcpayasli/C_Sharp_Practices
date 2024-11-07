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
        Console.WriteLine($"Inital name: {myAccount.GetName()}");
        Console.Write("Enter the name:");
        string theName = Console.ReadLine();
        myAccount.SetName(theName);
        Console.WriteLine($"Name of account: {myAccount.GetName()}");
    }
}
