// Program 174: Enum - Months with Switch
// Category: Intermediate

using System;
enum Month { Jan=1,Feb,Mar,Apr,May,Jun,Jul,Aug,Sep,Oct,Nov,Dec }
class Program {
    static void Main() {
        Console.Write("Enter month number (1-12): ");
        Month m = (Month)int.Parse(Console.ReadLine());
        switch (m) {
            case Month.Jan: case Month.Mar: case Month.May: case Month.Jul:
            case Month.Aug: case Month.Oct: case Month.Dec:
                Console.WriteLine(m + " has 31 days."); break;
            case Month.Apr: case Month.Jun: case Month.Sep: case Month.Nov:
                Console.WriteLine(m + " has 30 days."); break;
            case Month.Feb:
                Console.WriteLine(m + " has 28/29 days."); break;
        }
    }
}
