using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class EmployeeTest
{
    static void Main()
    {
        Console.WriteLine(
            $"Employees before instantiation: {Employee.Count}");

        var e1 = new Employee("Susan", "Baker");
        var e2 = new Employee("Bob", "Blue");
        Console.WriteLine(
        $"Employees after instantiation: {Employee.Count}");
    }
}
