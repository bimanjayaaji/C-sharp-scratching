using System.Collections.Generic;
using System.Text;
namespace foobar;

public class FooBarv3
{
	private Dictionary<int, string> _conditionDict = new Dictionary<int, string>();
    private List<int> keys = new List<int>();

	public FooBarv3(Dictionary<int, string> dict)
	{
		this._conditionDict = dict;
		foreach (var x in _conditionDict.Keys)
		{
			keys.Add(x);
			keys.Sort();
        }
	}

	public bool AddNumber(int num, string word)
	{
		if (_conditionDict.TryAdd(num, word))
        {
            _conditionDict[num] = word;
            keys.Add(num);
            keys.Sort();
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
			keys.Remove(num);
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

	public string CheckSingleNumber(int num)
	{
		string output = "";
		foreach (var key in keys)
		{
			if (num % key == 0 && num != 0)
			{
				output = output + this._conditionDict[key];
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