using System.Text;
namespace foobar;

public class FooBarv3
{
	public Dictionary<int,string> theDict = new Dictionary<int, string>();
	public int theListLen = 0;
	
	public FooBarv3(Dictionary<int,string> dict)
	{
		this.theDict = dict;
	}
	
	public bool AddNumber(int num, string word)
	{
		if (theDict.ContainsKey(num))
		{
			return false;
		} 
		else
		{
			theDict[num] = word;
			return true;
		}
	}
	
	public bool RemoveNumber(int num)
	{
		if (theDict.ContainsKey(num))
		{
			theDict.Remove(num);
			return true;
		} 
		else
		{
			return false;
		}
	}
	
	public Dictionary<int,string> ListCondition()
	{
		return theDict;
	}
	
	public string CheckNumber(int num)
	{
		string stringFooBar = "";
		List<object> theList = new List<object>();
		
		List<int> keys = new List<int>(theDict.Keys);
		keys.Sort();
		keys.Reverse();

		for (int i = 0; i <= Math.Abs(num); i++)
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
					theList[i] = theDict[key];
				}
			}
		}

		stringFooBar = TheListToString(theList);
		
		return stringFooBar;
	}
	
	private string TheListToString(List<object> obj)
	{
		StringBuilder sequenceFooBar = new StringBuilder();
		int iter = 0;

		foreach (object item in obj)
		{
			iter++;
			sequenceFooBar.Append(item.ToString());
			if (iter < obj.Count)
			{
				sequenceFooBar.Append(", ");
			}
		}
		
		return sequenceFooBar.ToString();
	}
}