class Program
{
    static void Main(string[] args)
    {
        Dictionary<int,string> dict = new Dictionary<int,string>();

        dict[3] = "foo";
        dict[5] = "bar";

        foreach (var x in dict.Keys)
        {
            Console.WriteLine(x.GetType());
        }
    }
}