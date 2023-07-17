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

        // printing the object return of foobar sequence
        Console.WriteLine(myFooBar.CheckNumber(50));
        Console.WriteLine("---");

        // adding 7 as "sugiono"
        bool x = myFooBar.AddNumber(7, "sugiono");
        Console.WriteLine(myFooBar.CheckNumber(50));
        Console.WriteLine("---");

        // removing 3
        bool y = myFooBar.RemoveNumber(3);
        Console.WriteLine(myFooBar.CheckNumber(50));
        Console.WriteLine("---");

        // listing the condition
        Dictionary<int, string> cond = myFooBar.ListCondition();
        foreach (KeyValuePair<int, string> kvp in cond)
        {
            Console.WriteLine("Key: " + kvp.Key + ", Value: " + kvp.Value);
        }
        Console.WriteLine("---");
    }
}