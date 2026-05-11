// Program 223: Dictionary Phonebook
// Category: Advanced

using System;using System.Collections.Generic;
class Program{static void Main(){
    Dictionary<string,string>book=new Dictionary<string,string>{{"Alice","9999"},{"Bob","8888"},{"Charlie","7777"}};
    Console.Write("Search name: ");string name=Console.ReadLine();
    Console.WriteLine(book.ContainsKey(name)?"Number: "+book[name]:"Not found.");
}}
