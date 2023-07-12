using System.Text;
namespace foobar;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int,string> myDict = new Dictionary<int,string>();

        myDict[3] = "telu";
        myDict[5] = "limo";
        myDict[15] = "limolas";
        myDict[7] = "pitu";

        int endPoint = 100;

        FooBarv1 foobar = new FooBarv1(myDict,endPoint);
        foobar.FooBarGo();

        Console.ReadLine();
    }
}

class FooBarv1
{
    // declaring dictionary and endPoint data
    public Dictionary<int,string> theDict = new Dictionary<int,string>();
    public int endPoint;

    // declaring numbers sequence data from 0 up to the endPoint
    public List<object> theList = new List<object>();

    // constructor. taking <int,string> dictionary and endPoint
    public FooBarv1(Dictionary<int, string> dict, int point) 
    { 
        this.theDict = dict;
        this.endPoint = point;
    }

    // main method
    public void FooBarGo()
    {
        Process();
        Displaying();
    }

    // display method. for the sake of displaying the result
    public void Displaying()
    {
        StringBuilder sb = new StringBuilder();
        int iter = 0;

        foreach (object item in this.theList)
        {
            iter++;
            sb.Append(item.ToString());
            if (iter < this.theList.Count)
            {
                sb.Append(", ");
            }
        }
        Console.WriteLine(sb.ToString());
    }

    public void Process()
    {
        // sorting the keys so that we know the biggest and the lowest
        List<int> keys = new List<int>(theDict.Keys);
        keys.Sort();
        keys.Reverse();

        // adding numbers from 0 to endPoint to "theList" variable declared earlier
        for(int i = 0; i <= endPoint; i++)
        {
            this.theList.Add(i);
        }

        // changing "theList" members according to their modulo result
        foreach (var key in keys) // the denumerator
        {
            for (int i = 0; i < this.theList.Count; i++) // iterating for indexing purpose
            {
                // converting object to string. then string to number.
                // already tried to convert object to nums directly, resulting error
                // still no idea exactly why
                string tempStr = this.theList[i].ToString(); 
                bool success = int.TryParse(tempStr, out int theNums); 
                
                if (success)
                {
                    if (theNums % key == 0 && theNums != 0)
                    {
                        this.theList[i] = theDict[key];
                    }
                }
            }
        }
    }
}