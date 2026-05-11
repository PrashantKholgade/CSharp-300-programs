// Program 268: Simple ATM Simulation OOP
// Category: Advanced

using System;using System.Collections.Generic;
class ATM{
    Dictionary<string,(string Pin,double Balance)>accounts=new Dictionary<string,(string,double)>{{"4111",("1234",10000)},{"5222",("5678",25000)}};
    string current;
    public bool Login(string card,string pin){if(accounts.ContainsKey(card)&&accounts[card].Pin==pin){current=card;return true;}return false;}
    public void CheckBalance()=>Console.WriteLine("Balance: Rs."+accounts[current].Balance.ToString("F2"));
    public void Deposit(double a){var acc=accounts[current];accounts[current]=(acc.Pin,acc.Balance+a);Console.WriteLine("Deposited Rs."+a);}
    public void Withdraw(double a){var acc=accounts[current];if(a>acc.Balance)Console.WriteLine("Insufficient funds.");else{accounts[current]=(acc.Pin,acc.Balance-a);Console.WriteLine("Dispensed Rs."+a);}}
}
class Program{static void Main(){var atm=new ATM();Console.Write("Card#: ");string c=Console.ReadLine();Console.Write("PIN: ");string p=Console.ReadLine();if(!atm.Login(c,p)){Console.WriteLine("Invalid credentials.");return;}atm.CheckBalance();atm.Deposit(2000);atm.Withdraw(500);atm.CheckBalance();}}
