// Program 269: Chain of Responsibility Pattern
// Category: Advanced

using System;
abstract class Handler{protected Handler next;public Handler SetNext(Handler n){next=n;return n;}public abstract void Handle(int level,string msg);}
class InfoHandler:Handler{public override void Handle(int lvl,string msg){if(lvl==1)Console.WriteLine("[INFO] "+msg);else next?.Handle(lvl,msg);}}
class WarnHandler:Handler{public override void Handle(int lvl,string msg){if(lvl==2)Console.WriteLine("[WARN] "+msg);else next?.Handle(lvl,msg);}}
class ErrorHandler:Handler{public override void Handle(int lvl,string msg){if(lvl==3)Console.WriteLine("[ERROR] "+msg);else next?.Handle(lvl,msg);}}
class Program{static void Main(){var h=new InfoHandler();h.SetNext(new WarnHandler()).SetNext(new ErrorHandler());h.Handle(1,"App started");h.Handle(2,"Low memory");h.Handle(3,"Disk full");}}
