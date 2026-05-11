// Program 173: Enum - Days of Week
// Category: Intermediate

using System;
enum Day { Monday=1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }
class Program {
    static void Main() {
        Day today = Day.Wednesday;
        Console.WriteLine("Today: " + today + " (value " + (int)today + ")");
        if (today == Day.Saturday || today == Day.Sunday) Console.WriteLine("Weekend!");
        else Console.WriteLine("Weekday.");
    }
}
