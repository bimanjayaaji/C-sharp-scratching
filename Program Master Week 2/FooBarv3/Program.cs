using System.Text;
namespace foobar;

class Program
{
    static void Main()
    {
        Dictionary<int, string> myDict = new Dictionary<int, string>();
        myDict[3] = "foo";
        myDict[5] = "bar";
        int endPoint = 100;

        // Initializing new foobar list in "myFooBar" variable
        List<object> myFooBar = FooBarv2.Init(myDict, endPoint);
        Displaying(myFooBar);
        Console.WriteLine("----------");
        // Adding 15 as "foobar"
        myFooBar = FooBarv2.Config(myFooBar, 15, "foobar");
        Displaying(myFooBar);
        Console.WriteLine("----------");
        // Changing 15 as "limolas"
        myFooBar = FooBarv2.Config(myFooBar, 15, "limolas");
        Displaying(myFooBar);
        Console.WriteLine("----------");
        // Reassign 3 back as a number
        myFooBar = FooBarv2.Remove(myFooBar, 3);
        Displaying(myFooBar);
        Console.WriteLine("----------");
        // Changing the endPoint to 150
        myFooBar = FooBarv2.SetEndPoint(myFooBar, 150);
        Displaying(myFooBar);
        Console.WriteLine("----------");
        // Changing the endPoint to 50
        myFooBar = FooBarv2.SetEndPoint(myFooBar, 50);
        Displaying(myFooBar);
        Console.WriteLine("----------");
    }

    public static void Displaying(List<object> obj)
    {
        StringBuilder sb = new StringBuilder();
        int iter = 0;

        foreach (object item in obj)
        {
            iter++;
            sb.Append(item.ToString());
            if (iter < obj.Count)
            {
                sb.Append(", ");
            }
        }
        Console.WriteLine(sb.ToString());
    }
}

class Programv1
{
    static void Mainv1(string[] args)
    {
        Dictionary<int, string> myDict = new Dictionary<int, string>();

        myDict[3] = "telu";
        myDict[5] = "limo";
        myDict[15] = "limolas";
        myDict[7] = "pitu";

        int endPoint = 100;

        FooBarv1 foobar = new FooBarv1(myDict, endPoint);
        foobar.FooBarGo();

        Console.ReadLine();
    }
}