// Program 250: Contact Book with Dictionary
// Category: Advanced

using System;using System.Collections.Generic;
class Program{static void Main(){
    var contacts=new Dictionary<string,string>();
    string cmd;
    Console.WriteLine("add <name> <phone> | find <name> | list | quit");
    while((cmd=Console.ReadLine())!="quit"){
        string[]parts=cmd.Split(' ');
        if(parts[0]=="add"&&parts.Length==3){contacts[parts[1]]=parts[2];Console.WriteLine("Saved.");}
        else if(parts[0]=="find"&&parts.Length==2)Console.WriteLine(contacts.ContainsKey(parts[1])?parts[1]+": "+contacts[parts[1]]:"Not found.");
        else if(parts[0]=="list")foreach(var kv in contacts)Console.WriteLine(kv.Key+": "+kv.Value);
    }
}}
