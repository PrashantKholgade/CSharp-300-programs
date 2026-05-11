// Program 243: Simple Banking System OOP
// Category: Advanced

using System;using System.Collections.Generic;
class Account{
    public int Id;public string Owner;public double Balance;
    public Account(int id,string o,double b){Id=id;Owner=o;Balance=b;}
    public void Deposit(double a){Balance+=a;}
    public bool Withdraw(double a){if(a>Balance)return false;Balance-=a;return true;}
    public override string ToString()=>$"[{Id}] {Owner}: Rs.{Balance:F2}";
}
class Bank{
    List<Account>accounts=new List<Account>();int nextId=1;
    public Account Create(string o,double b){var acc=new Account(nextId++,o,b);accounts.Add(acc);return acc;}
    public Account Find(int id)=>accounts.Find(a=>a.Id==id);
    public void ShowAll(){foreach(var a in accounts)Console.WriteLine(a);}
}
class Program{static void Main(){var bank=new Bank();var a1=bank.Create("Alice",5000);var a2=bank.Create("Bob",3000);a1.Deposit(1500);a2.Withdraw(500);bank.ShowAll();}}
