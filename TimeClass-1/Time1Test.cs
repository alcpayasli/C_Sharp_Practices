using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Time1Test
{
    static void Main()
    {
        var time = new Time1();
        Console.WriteLine(
            $"Initial universal time is: {time.ToUniversalString()}");
        Console.WriteLine(
            $"Initial standart time is: {time.ToString()}");
        time.SetTime(13, 27, 6);
        Console.WriteLine(
            $"After settime time is: {time.ToUniversalString()}");
        Console.WriteLine(
            $"After settime standart time is: {time.ToString()}");
        try
        {
            time.SetTime(99, 99, 99);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
