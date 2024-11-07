using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Time2Test
{
    static void Main()
    {
        var t1 = new Time2();
        var t2 = new Time2(2);
        var t3 = new Time2(2, 32);
        var t4 = new Time2(2,32,16);
        var t5 = new Time2(t4);

        Console.WriteLine($"T1:{t1.ToUniversalString()}");
        Console.WriteLine($"T2:{t2.ToUniversalString()}");
        Console.WriteLine($"T3:{t3.ToUniversalString()}");
        Console.WriteLine($"T4:{t4.ToUniversalString()}");
        Console.WriteLine($"T5:{t5.ToUniversalString()}");
    }
}
