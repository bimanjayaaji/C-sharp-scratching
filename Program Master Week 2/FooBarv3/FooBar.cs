using System;
using System.Text;
namespace foobar;

class FooBarv2
{
    public static List<object> theList = new List<object>();
    public static Dictionary<int, string> FooBarDict = new Dictionary<int, string>(); 
    public static int theListLen;

    public static List<object> Init(Dictionary<int, string> dict, int end)
    {
        List<int> keys = new List<int>(dict.Keys);
        keys.Sort();
        keys.Reverse();

        for (int i = 0; i <= Math.Abs(end); i++)
        {
            theList.Add(i);
        }

        theListLen = theList.Count;

        foreach (var key in keys)
        {
            for (int i = 0; i < theListLen; i++)
            {
                if (i % key == 0 && i != 0)
                {
                    theList[i] = dict[key];
                }
            }
        }
        return theList;
    }

    public static List<object> Config(List<object> list, int num, string word)
    {
        theList = list;
        theListLen = list.Count;

        if (num < theListLen)
        {
            //Console.WriteLine("inside range");
            for (int i = 0; i < theListLen; i++)
            {
                if (i % num == 0 && i != 0)
                {
                    theList[i] = word;
                }
            }
            return theList;
        }
        else
        {
            //Console.WriteLine("outside range");
            return theList;
        }
    }

    public static List<object> Remove(List<object> list, int num)
    {
        theList = list;
        theListLen = list.Count;

        if (num < theListLen)
        {
            //Console.WriteLine("inside range");
            string word = list[num].ToString();

            if (theList[num].ToString() != num.ToString())
            {
                //Console.WriteLine("removeable");
                for (int i = 0; i < theListLen; i++)
                {
                    if (i % num == 0 && i != 0)
                    {
                        if (list[i].ToString() == word)
                        {
                            theList[i] = i;
                        }
                    }
                }
                return theList;
            }
            else
            {
                //Console.WriteLine("nothing to remove");
                return theList;
            }
        }
        else
        {
            //Console.WriteLine("outside range");
            return theList;
        }
    }

    public static List<object> SetEndPoint(List<object> list, int end)
    {
        theList = list;
        theListLen = list.Count;

        if (end < 0)
        {
            return theList;
        }
        else
        {
            if (end != theListLen - 1)
            {
                if (end < theListLen - 1)
                {
                    for (int i = theListLen - 1; i >= end + 1; i--)
                    {
                        theList.RemoveAt(i);
                    }
                    return theList;
                }
                else
                {
                    FooBarList();

                    for (int i = theListLen; i <= Math.Abs(end); i++)
                    {
                        theList.Add(i);
                    }

                    List<int> keys = new List<int>(FooBarDict.Keys);
                    foreach (var key in keys)
                    {
                        for (int i = theListLen; i <= end; i++)
                        {
                            if (i % key == 0 && i != 0)
                            {
                                theList[i] = FooBarDict[key];
                            }
                        }
                    }

                    return theList;
                }
            }
            else
            {
                return theList;
            }
        }
    }

    public static void FooBarList()
    {
        for (int i = 0; i < theListLen; i++)
        {
            string? theWord = theList[i].ToString();
            if (theWord != i.ToString())
            {
                if (FooBarDict.ContainsValue(theWord) == false)
                {
                    FooBarDict[i] = theList[i].ToString();
                }
            }
        }
    }
}

class FooBarv1
{
    // declaring dictionary and endPoint data
    public Dictionary<int, string> theDict = new Dictionary<int, string>();
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
        for (int i = 0; i <= endPoint; i++)
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
                string? tempStr = this.theList[i].ToString();
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