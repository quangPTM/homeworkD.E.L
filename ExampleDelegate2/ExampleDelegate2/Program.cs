public delegate void MyDelegate(string msg);
class MyClass
{
    public static void Print (string message) =>
        Console.WriteLine ($"{message.ToUpper()}");
    public static void Show (string message) =>
        Console.WriteLine($"{message.ToLower()}");
}
class Program 
{
    static void InvokeDelagate(MyDelegate dele, string msg) => dele(msg);
    static void Main(string[] args)
    {
        string msg = "Passing Delegate As a Paramater";
        InvokeDelagate(MyClass.Print, msg);
        InvokeDelagate(MyClass.Show, msg);
        Console.ReadLine();
    }
}
