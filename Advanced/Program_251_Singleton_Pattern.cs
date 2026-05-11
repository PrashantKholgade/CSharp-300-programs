// Program 251: Singleton Pattern
// Category: Advanced

using System;
class Config{
    private static Config _instance;
    private Config(){AppName="MyApp";Version="1.0";}
    public static Config Instance=>_instance??(_instance=new Config());
    public string AppName;public string Version;
}
class Program{static void Main(){var c1=Config.Instance;var c2=Config.Instance;Console.WriteLine("Same instance: "+(c1==c2));Console.WriteLine(c1.AppName+" v"+c1.Version);}}
