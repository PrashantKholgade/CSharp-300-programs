// Program 186: Generic Stack Class
// Category: Intermediate

using System;
class MyStack<T> {
    T[] items = new T[100]; int top = -1;
    public void Push(T item) { items[++top] = item; }
    public T Pop() { return items[top--]; }
    public T Peek() { return items[top]; }
    public bool IsEmpty() { return top == -1; }
}
class Program {
    static void Main() {
        MyStack<int> stack = new MyStack<int>();
        stack.Push(10); stack.Push(20); stack.Push(30);
        Console.WriteLine("Peek: " + stack.Peek());
        while (!stack.IsEmpty()) Console.Write(stack.Pop() + " ");
        Console.WriteLine();
    }
}
