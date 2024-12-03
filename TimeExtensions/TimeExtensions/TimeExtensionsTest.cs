
using System;

class TimeExtensionsTest
{
   static void Main()
   {
      var myTime = new Time2(); // call Time constructor
      myTime.SetTime(11, 34, 15); // set the time to 11:34:15

      // test the DisplayTime extension method
      Console.Write("Use the DisplayTime extension method: ");
      myTime.DisplayTime();

      // test the AddHours extension method
      Console.Write("Add 5 hours with the AddHours extension method: ");
      var timeAdded = myTime.AddHours(5); // add five hours
      timeAdded.DisplayTime(); // display the new Time2 object

      // add hours and display the time in one statement
      Console.Write("Add 15 hours with the AddHours extension method: ");
      myTime.AddHours(15).DisplayTime(); // add hours and display time

      // use fully qualified extension-method name to display the time
      Console.Write("Use fully qualified extension-method name: ");
      TimeExtensions.DisplayTime(myTime);

        Console.ReadKey();
   }
}

// extension-methods class
static class TimeExtensions
{
   // display the Time2 object in console
   public static void DisplayTime(this Time2 aTime)
   {
      Console.WriteLine(aTime.ToString());
   }

   // add the specified number of hours to the time
   // and return a new Time2 object
   public static Time2 AddHours(this Time2 aTime, int hours)
   {
      // create a new Time object
      var newTime = new Time2() {
         Minute = aTime.Minute, Second = aTime.Second};

      // add the specified number of hours to the given time
      newTime.Hour = (aTime.Hour + hours) % 24;

      return newTime; // return the new Time2 object
   }
}



