// Program 267: Simple Cinema Seat Booking
// Category: Advanced

using System;
class Cinema{
    bool[,]seats;int rows,cols;
    public Cinema(int r,int c){rows=r;cols=c;seats=new bool[r,c];}
    public void Show(){Console.Write("   ");for(int j=0;j<cols;j++)Console.Write((j+1).ToString().PadLeft(3));Console.WriteLine();for(int i=0;i<rows;i++){Console.Write((i+1).ToString().PadLeft(3));for(int j=0;j<cols;j++)Console.Write(seats[i,j]?"  X":"  O");Console.WriteLine();}}
    public void Book(int r,int c){if(seats[r-1,c-1])Console.WriteLine("Already booked.");else{seats[r-1,c-1]=true;Console.WriteLine("Booked row "+r+" seat "+c);}}
}
class Program{static void Main(){var c=new Cinema(4,5);c.Show();c.Book(2,3);c.Book(1,1);c.Show();}}
