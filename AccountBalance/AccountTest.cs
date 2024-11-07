using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AccountTest { 

    static void Main() {
    
        Account myAccount1 = new Account("James Green", 50.00m);
        Account myAccount2 = new Account("Jack Kusher", -7.53m);

        Console.WriteLine($"{myAccount1.Name}'s balance: {myAccount1.Balance}");
        Console.WriteLine($"{myAccount2.Name}'s balance: {myAccount2.Balance}");

        Console.Write("Enter the deposit for account1:");
        decimal theDeposit = decimal.Parse(Console.ReadLine());
        myAccount1.Deposit(theDeposit);
        Console.WriteLine($"{myAccount1.Name}'s balance after deposit: {myAccount1.Balance}");



    }
}