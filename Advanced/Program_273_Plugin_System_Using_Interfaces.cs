// Program 273: Plugin System Using Interfaces
// Category: Advanced

using System;using System.Collections.Generic;
interface IPlugin{string Name{get;}void Execute();}
class LogPlugin:IPlugin{public string Name=>"Logger";public void Execute()=>Console.WriteLine("[LOG] Logging data...");}
class AuthPlugin:IPlugin{public string Name=>"Auth";public void Execute()=>Console.WriteLine("[AUTH] Authenticating user...");}
class PluginManager{List<IPlugin>plugins=new List<IPlugin>();public void Register(IPlugin p)=>plugins.Add(p);public void RunAll(){foreach(var p in plugins){Console.Write("Running "+p.Name+": ");p.Execute();}}}
class Program{static void Main(){var pm=new PluginManager();pm.Register(new LogPlugin());pm.Register(new AuthPlugin());pm.RunAll();}}
