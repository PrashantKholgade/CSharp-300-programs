// Program 278: Simple Text Adventure
// Category: Advanced

using System;using System.Collections.Generic;
class Program{static void Main(){
    var desc=new Dictionary<string,string>{{"hall","You are in a dark hall. Doors: north, east."},{"garden","A beautiful garden. Door: south."},{"library","Old books everywhere. Door: west."}};
    var exits=new Dictionary<string,Dictionary<string,string>>{{"hall",new Dictionary<string,string>{{"north","garden"},{"east","library"}}},{"garden",new Dictionary<string,string>{{"south","hall"}}},{"library",new Dictionary<string,string>{{"west","hall"}}}};
    string room="hall";
    Console.WriteLine("Text Adventure! Type direction to move, quit to exit.");
    while(true){Console.WriteLine("
"+desc[room]);Console.Write("> ");string cmd=Console.ReadLine().Trim().ToLower();if(cmd=="quit")break;if(exits[room].ContainsKey(cmd))room=exits[room][cmd];else Console.WriteLine("Can't go that way.");}
}}
