﻿public delegate void PrintDetails(string msg);
class Program 
{
    event PrintDetails Print;
    void Show(string msg) => Console.WriteLine(msg.ToUpper());
    static void Main(string[] args)
    {
        Program p= new Program();
        p.Print += new PrintDetails(p.Show);
        p.Print("Hello world!");
        Console.ReadLine();
    }
}
