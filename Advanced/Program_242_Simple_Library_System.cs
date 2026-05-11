// Program 242: Simple Library System
// Category: Advanced

using System;using System.Collections.Generic;
class Book{public string Title,Author;public bool IsAvailable=true;}
class Library{
    List<Book>books=new List<Book>();
    public void AddBook(string t,string a)=>books.Add(new Book{Title=t,Author=a});
    public void Checkout(string t){var b=books.Find(x=>x.Title==t);if(b==null)Console.WriteLine("Not found.");else if(!b.IsAvailable)Console.WriteLine("Not available.");else{b.IsAvailable=false;Console.WriteLine("Checked out: "+t);}}
    public void Return(string t){var b=books.Find(x=>x.Title==t);if(b!=null){b.IsAvailable=true;Console.WriteLine("Returned: "+t);}}
    public void List(){foreach(var b in books)Console.WriteLine(b.Title+" by "+b.Author+" ["+(b.IsAvailable?"Available":"Checked out")+"]");}
}
class Program{static void Main(){var lib=new Library();lib.AddBook("C# Basics","Smith");lib.AddBook("OOP Design","Jones");lib.Checkout("C# Basics");lib.List();lib.Return("C# Basics");lib.List();}}
