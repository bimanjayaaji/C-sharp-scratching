using System.Text;
namespace foobar;

class FooBar
{
    public static List<object> myList = new List<object>();

    public static void FooBarGo(int end)
    {
        Process(end);
        Displaying();
    }

    public static void Displaying()
    {
        StringBuilder sb = new StringBuilder();
        int iter = 0;

        foreach (object item in myList)
        {
            iter++;
            sb.Append(item.ToString());
            if (iter < myList.Count)
            {
                sb.Append(", ");
            }
        }
        Console.WriteLine(sb.ToString());
    }

    public static void Process(int end)
    {
        for (int i = 0; i <= end; i++)
        {
            if (i % 3 == 0 && i % 5 == 0 && i != 0)
            {
                myList.Add("foobar");
            }
            else if (i % 3 == 0 && i != 0)
            {
                myList.Add("foo");
            }
            else if (i % 5 == 0 && i != 0)
            {
                myList.Add("bar");
            }
            else
            {
                myList.Add(i);
            }
        }
    }
}