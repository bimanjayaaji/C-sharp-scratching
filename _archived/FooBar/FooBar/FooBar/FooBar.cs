using System.Text;
namespace foobar;

class FooBarv2
{
	public static List<object> theList = new List<object>();
	public static int valid = 0;
	
	public static List<object> Init(Dictionary<int,string> dict, int end)
	{
		List<int> keys = new List<int>(dict.Keys);
		keys.Sort();
		keys.Reverse();
	
		for(int i = 0; i <= Math.Abs(end); i++)
		{
			theList.Add(i);
		}
	
		foreach (var key in keys)
		{
			for (int i = 0; i < theList.Count; i++)
			{
				string? tempStr = theList[i].ToString(); 
				bool success = int.TryParse(tempStr, out int theNums); 
			
				if (success)
				{
					if (theNums % key == 0 && theNums != 0)
					{
						theList[i] = dict[key];
					}
				}
			}
		}
		
	return theList;
	
	}
	
	
	public static List<object> Add(List<object> list, int num, string word)
	{
		theList = list;
		
		// step1 : cek apakah num yang dituju sudah ada isinya.
		//		   - kalo terisi, langsung step3.
		//		   - kalo kosong, proceeds.
		// step2 : proses ganti (int)bilangan jadi (string)kata.
		// step3 : return theList.
		
		int theList_Len = theList.Count;
		
		
		
		return theList;
	}
	
	public static List<object> Remove(List<object> list, int num)
	{
		theList = list;
		
		// step1 : cek apakah num yang dituju sudah ada isinya.
		//		   - kalo terisi, proceeds.
		//		   - kalo kosong, langsung step3.
		// step2 : proses ganti (string)kata jadi (int)bilangan.
		// step3 : return theList. 
		
		return theList;
	}
	
	public static List<object> Change(List<object> list, int num, string word)
	{
		theList = list;
		
		// step1 : cek apakah num yang dituju sudah ada isinya.
		// 		   - kalo terisi, proceeds.
		//		   - kalo kosong, langsung step3.
		// step2 : proses ganti (string)kata jadi (string)kata lain.
		// step3 : return theList.
		
		return theList;
	}
	
	public static List<object> SetEndPoint(List<object> list, int end)
	{
		theList = list;
		
		// step1 : cek apakah endPoint masuk akal (kriteria : (int) min 0 max ...).
		//		   - kalo iy, proceeds.
		//		   - kalo ga, langsung step3.
		// step2 : nambah atau ngurangi data dalam list.
		
		
		return theList;
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