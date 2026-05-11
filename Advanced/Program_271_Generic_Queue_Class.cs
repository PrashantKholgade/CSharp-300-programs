// Program 271: Generic Queue Class
// Category: Advanced

using System;
class MyQueue<T>{
    T[]data=new T[100];int front=0,back=0;
    public void Enqueue(T item)=>data[back++]=item;
    public T Dequeue()=>data[front++];
    public T Peek()=>data[front];
    public bool IsEmpty()=>front==back;
    public int Count=>back-front;
}
class Program{static void Main(){var q=new MyQueue<string>();q.Enqueue("A");q.Enqueue("B");q.Enqueue("C");Console.WriteLine("Peek: "+q.Peek());while(!q.IsEmpty())Console.Write(q.Dequeue()+" ");Console.WriteLine();}}
