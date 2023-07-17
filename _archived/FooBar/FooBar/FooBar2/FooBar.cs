using System.Text;
namespace foobar;

public class FooBarv3
{
    private Dictionary<int, string> _conditionDict = new Dictionary<int, string>();

    public FooBarv3(Dictionary<int, string> dict)
    {
        this._conditionDict = dict;
    }

    public bool AddNumber(int num, string word)
    {
        if (_conditionDict.ContainsKey(num))
        {
            return false;
        }
        else
        {
            _conditionDict[num] = word;
            return true;
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

    public string CheckNumber(int num)
    {
        List<object> sequence = new List<object>();

        List<int> keys = new List<int>(_conditionDict.Keys);
        keys.Sort();
        keys.Reverse();

        for (int i = 0; i <= Math.Abs(num); i++)
        {
            sequence.Add(i);
        }

        foreach (var key in keys)
        {
            for (int i = 0; i < sequence.Count; i++)
            {
                if (i % key == 0 && i != 0)
                {
                    sequence[i] = _conditionDict[key];
                }
            }
        }

        return ListToString(sequence);
    }

    private string ListToString(List<object> obj)
    {
        StringBuilder sequenceSB = new StringBuilder();
        int iter = 0;

        foreach (object item in obj)
        {
            iter++;
            sequenceSB.Append(item.ToString());
            if (iter < obj.Count)
            {
                sequenceSB.Append(", ");
            }
        }

        return sequenceSB.ToString();
    }
}