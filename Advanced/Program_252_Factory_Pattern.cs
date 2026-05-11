// Program 252: Factory Pattern
// Category: Advanced

using System;
abstract class Notification{public abstract void Send(string msg);}
class EmailNotification:Notification{public override void Send(string msg)=>Console.WriteLine("Email: "+msg);}
class SMSNotification:Notification{public override void Send(string msg)=>Console.WriteLine("SMS: "+msg);}
class NotificationFactory{public static Notification Create(string type)=>type=="email"?new EmailNotification():new SMSNotification();}
class Program{static void Main(){NotificationFactory.Create("email").Send("Hello!");NotificationFactory.Create("sms").Send("Hi there!");}}
