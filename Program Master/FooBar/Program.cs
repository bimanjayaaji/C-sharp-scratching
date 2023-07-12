namespace foobar;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter endpoint : ");
        int end = Convert.ToInt32(Console.ReadLine());
        FooBar.FooBarGo(end);
    }
}