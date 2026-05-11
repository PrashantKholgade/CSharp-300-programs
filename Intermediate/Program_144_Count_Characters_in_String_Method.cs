// Program 144: Count Characters in String Method
// Category: Intermediate

using System;
class Program {
    static int CountChar(string s, char ch) { int c=0; foreach(char x in s) if(x==ch) c++; return c; }
    static void Main() {
        Console.Write("String: "); string s = Console.ReadLine();
        Console.Write("Count char: "); char c = char.Parse(Console.ReadLine());
        Console.WriteLine("'" + c + "' appears " + CountChar(s,c) + " times.");
    }
}
