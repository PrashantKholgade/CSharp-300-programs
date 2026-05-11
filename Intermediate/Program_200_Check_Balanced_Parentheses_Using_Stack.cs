// Program 200: Check Balanced Parentheses Using Stack
// Category: Intermediate

using System;
using System.Collections.Generic;
class Program {
    static bool IsBalanced(string s) {
        Stack<char> stk = new Stack<char>();
        foreach (char c in s) {
            if (c=='(' || c=='[' || c=='{') stk.Push(c);
            else if (c==')' || c==']' || c=='}') {
                if (stk.Count==0) return false;
                char top = stk.Pop();
                if ((c==')' && top!='(') || (c==']' && top!='[') || (c=='}' && top!='{')) return false;
            }
        }
        return stk.Count==0;
    }
    static void Main() {
        Console.Write("Enter expression: "); string s = Console.ReadLine();
        Console.WriteLine(IsBalanced(s) ? "Balanced" : "NOT Balanced");
    }
}
