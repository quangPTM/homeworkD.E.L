public delegate void MyDelegate(string message);
class Myclass
{
    public static void Print(string msg) =>
    Console.WriteLine($"{msg.ToUpper()}");
    public static void Show(string msg) =>
    Console.WriteLine($"{msg.ToLower()}");
    public static void Display(string msg) =>
    Console.WriteLine($"{msg}");
}
class Program
{
    static void Main(string[] args)
    {
        string msg = "Multicast Delagate";
        MyDelegate MyDele01 = Myclass.Print;
        MyDelegate MyDele02 = Myclass.Show;
        Console.WriteLine("**** Combines Mydele01 +Mydele02 ****");
        MyDelegate MyDele = MyDele01 + MyDele02;
        MyDele(msg);

        Console.WriteLine("**** Combines Mydele01 +Mydele02 + Mydele03 ****");
        MyDelegate MyDele03 = Myclass.Display;
        MyDele += MyDele03;
        MyDele(msg);
        Console.WriteLine("-----------------"); 
        Console.WriteLine("**** Remove Mydele02 ****");
        MyDele -= MyDele02;
        MyDele("Hello world!");
        Console.ReadLine(); 
    }
}