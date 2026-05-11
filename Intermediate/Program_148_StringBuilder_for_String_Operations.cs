// Program 148: StringBuilder for String Operations
// Category: Intermediate

using System;
using System.Text;
class Program {
    static void Main() {
        StringBuilder sb = new StringBuilder();
        sb.Append("Hello");
        sb.Append(", ");
        sb.Append("World");
        sb.Append("!");
        sb.Replace("World", "CSharp");
        Console.WriteLine(sb.ToString());
        Console.WriteLine("Length: " + sb.Length);
    }
}
