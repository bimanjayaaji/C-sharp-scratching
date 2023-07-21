// using System.Text;
// namespace foobar;

// class Program
// {
//     static void Main()
//     {
//         Dictionary<int, string> myDict = new Dictionary<int, string>();
//         myDict[3] = "foo";
//         myDict[5] = "bar";

//         // creating new FooBar instance, passing condition in dictionary form
//         var myFooBar = new FooBarv3(myDict);
//         Console.WriteLine("---");

//         // checking single number condition. returning string.
//         Console.WriteLine(myFooBar.CheckSingleNumber(150));
//         Console.WriteLine("---");

//         // checking foobar sequence of the passed number
//         Console.WriteLine(myFooBar.CheckNumber(150));
//         Console.WriteLine("---");

//         // adding 2 as "fizz"
//         bool x = myFooBar.AddNumber(2, "fizz");
//         Console.WriteLine(myFooBar.CheckNumber(150));
//         Console.WriteLine("---");

//         // removing 3
//         bool y = myFooBar.RemoveNumber(3);
//         Console.WriteLine(myFooBar.CheckNumber(150));
//         Console.WriteLine("---");

//         // listing the condition
//         Dictionary<int, string> cond = myFooBar.ListCondition();
//         foreach (KeyValuePair<int, string> kvp in cond)
//         {
//             Console.WriteLine("Key: " + kvp.Key + ", Value: " + kvp.Value);
//         }
//         Console.WriteLine("---");
//     }
// }

using System.Text;
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
		Console.WriteLine(myFooBar.CheckSingleNumber(150));
		Console.WriteLine("---");

		// checking foobar sequence of the passed number
		Console.WriteLine(myFooBar.CheckNumber(150));
		Console.WriteLine("---");

		// adding 2 as "fizz"
		bool x = myFooBar.AddNumber(2, "fizz");
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
	}
}

public class FooBarv3
{
	private Dictionary<int, string> _conditionDict = new Dictionary<int, string>();

	public FooBarv3(Dictionary<int, string> dict)
	{
		this._conditionDict = dict;
	}

	public bool AddNumber(int num, string word)
	{
		if (_conditionDict.TryAdd(num, word))
		{
			_conditionDict[num] = word;
			return true;
		}
		else
		{
			return false;
		}
	}

	public bool RemoveNumber(int num)
	{
		if (_conditionDict.ContainsKey(num))
		{
			_conditionDict.Remove(num);
			return true;
		}
		else
		{
			return false;
		}
	}

	public Dictionary<int, string> ListCondition()
	{
		return _conditionDict;
	}

	private SortedDictionary<int, string> Sorting()
	{
		var sorted = new SortedDictionary<int, string>(_conditionDict);
		
		return sorted;
	}
	
	public string CheckSingleNumber(int num)
	{
		string output = "";
		foreach (KeyValuePair<int, string> pair in Sorting())
		{
			if (num % pair.Key == 0 && num != 0)
			{
				output = output + this._conditionDict[pair.Key];
			}
		}

		if (output == "")
		{
			return num.ToString();
		}
		else
		{
			return output;
		}
	}

	public string CheckNumber(int num)
	{
		int iter  = 0;
		string output = "";
		StringBuilder sequenceSB = new StringBuilder();

		for (int i = 0; i <= num; i++)
		{
			iter++;
			output = CheckSingleNumber(i);
			sequenceSB.Append(output);
			if (iter < num+1)
			{
				sequenceSB.Append(", ");
			}
		}
		return sequenceSB.ToString();
	}
}