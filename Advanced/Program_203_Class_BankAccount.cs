// Program 203: Class BankAccount
// Category: Advanced

using System;
class BankAccount{
    string owner; double balance;
    public BankAccount(string o,double b){owner=o;balance=b;}
    public void Deposit(double amt){balance+=amt;Console.WriteLine("Deposited "+amt+". Balance="+balance);}
    public void Withdraw(double amt){if(amt>balance)Console.WriteLine("Insufficient funds.");else{balance-=amt;Console.WriteLine("Withdrawn "+amt+". Balance="+balance);}}
    public void Show()=>Console.WriteLine(owner+"'s Balance: "+balance);
}
class Program{static void Main(){var acc=new BankAccount("Bob",1000);acc.Deposit(500);acc.Withdraw(200);acc.Show();}}
