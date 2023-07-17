using System.Diagnostics;
namespace foobar;

class Program
{
    static void Main()
    {
        Dictionary<int, string> myDict = new Dictionary<int, string>();
        myDict[3] = "foo";
        myDict[5] = "bar";

        // creating new FooBar instance, passing condition in dictionary form
        var myFooBar = new FooBarv3(myDict);
        Console.WriteLine("---");

        // checking single number condition. returning string.
        Console.WriteLine(myFooBar.CheckSingleNumber(15));
        Console.WriteLine("---");

        // checking foobar sequence of the passed number
        Console.WriteLine(myFooBar.CheckNumber(150));
        Console.WriteLine("---");

        // adding 7 as "fizz"
        bool x = myFooBar.AddNumber(7, "fizz");
        Console.WriteLine(myFooBar.CheckNumber(150));
        Console.WriteLine("---");

        // removing 3
        bool y = myFooBar.RemoveNumber(3);
        Console.WriteLine(myFooBar.CheckNumber(150));
        Console.WriteLine("---");

        // listing the condition
        Dictionary<int, string> cond = myFooBar.ListCondition();
        foreach (KeyValuePair<int, string> kvp in cond)
        {
            Console.WriteLine("Key: " + kvp.Key + ", Value: " + kvp.Value);
        }
        Console.WriteLine("---");

        // timing the elapsed time
        Stopwatch checkNumber = Stopwatch.StartNew();
        Console.WriteLine(myFooBar.CheckNumber(1000000));
        checkNumber.Stop();
        Console.WriteLine(checkNumber.Elapsed);
    }
}
