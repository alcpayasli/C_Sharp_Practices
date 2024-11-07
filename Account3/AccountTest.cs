using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AccountTest
{
    static void Main()
    {
        Account myObj = new Account("James Green");
        Console.WriteLine($"Account name is {myObj.Name}");
    }
}
