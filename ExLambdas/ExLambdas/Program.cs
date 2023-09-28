using System.Linq;
namespace ExLambdas 
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "David", "jane", "Peter", "John", "Mark" };
            foreach (string name in names.OrderBy(x => x))
            {
                Console.WriteLine(name);
            }
        Console.ReadLine();
        }
    }
}
