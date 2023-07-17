using System.Text;
namespace foobar;

class Program
{
	static void Main()
	{
		Dictionary<int,string> myDict = new Dictionary<int,string>();
		myDict[3] = "foo";
		myDict[5] = "bar";
		myDict[15] = "foobar";
		int endPoint = -100;
		
		List<object> myFooBar = FooBarv2.Init(myDict,endPoint);
		
		Displaying(myFooBar);
	}
	
	public static void Displaying(List<object> obj)
	{
		StringBuilder sb = new StringBuilder();
		int iter = 0;

		foreach (object item in obj)
		{
			iter++;
			sb.Append(item.ToString());
			if (iter < obj.Count)
			{
				sb.Append(", ");
			}
		}
		Console.WriteLine(sb.ToString());
	}
}

class Programv1
{
	static void Mainv1(string[] args)
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