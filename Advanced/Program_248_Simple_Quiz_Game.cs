// Program 248: Simple Quiz Game
// Category: Advanced

using System;using System.Collections.Generic;
class Question{public string Text;public string[]Options;public int Answer;public Question(string t,string[]o,int a){Text=t;Options=o;Answer=a;}}
class Program{static void Main(){
    var quiz=new List<Question>{
        new Question("Capital of France?",new[]{"London","Berlin","Paris","Rome"},3),
        new Question("2+2=?",new[]{"3","4","5","6"},2)};
    int score=0;
    foreach(var q in quiz){Console.WriteLine(q.Text);for(int i=0;i<q.Options.Length;i++)Console.WriteLine((i+1)+". "+q.Options[i]);Console.Write("Answer: ");int ans=int.Parse(Console.ReadLine());if(ans==q.Answer){Console.WriteLine("Correct!");score++;}else Console.WriteLine("Wrong. Answer was "+q.Answer);}
    Console.WriteLine("Score: "+score+"/"+quiz.Count);
}}
