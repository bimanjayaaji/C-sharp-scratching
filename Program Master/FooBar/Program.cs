namespace foobar;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter endpoint : ");
        int end = Convert.ToInt32(Console.ReadLine());
        FooBar fubar = new FooBar(end);
        fubar.process();
    }
}

class FooBar
{
    public int endPoint;

    public FooBar(int endpoint)
    {
        endPoint = endpoint;
    }

    public void process()
    {
        for(int i = 0; i <= endPoint; i++)
        {
            if (i % 3 == 0 && i % 5 == 0 && i != 0)
            {
                Console.Write("foobar");
            } else if (i % 3 == 0 && i != 0)
            {
                Console.Write("foo");
            } else if (i % 5 == 0 && i != 0)
            {
                Console.Write("bar");
            } else
            {
                Console.Write(i);
            }

            if (i < endPoint)
            {
                Console.Write(", ");
            }
        }
    }
}