namespace Buffalo;

class Program
{
    static void Main(string[] args)
    {
        // ---- 7.getting user input ----
        //Console.Write("Enter your name dude: ");
        //string name = Console.ReadLine();

        //Console.Write("Enter your age dude: ");
        //string age = Console.ReadLine();

        //Console.WriteLine("Hello " + name);
        //Console.WriteLine("You are " + age);



        // ---- 8.building calculator ----
        // how do user enter number? not string?
        // converting string to a number?

        // int num = "45"; // error
        // int num = Convert.ToInt32("45");
        // Console.WriteLine(num + 6);

        // int num = Convert.ToInt32("45asd"); //error

        //Console.WriteLine("Adder");
        //Console.WriteLine("Enter 1st number: ");
        //string sNum = Console.ReadLine();
        //double num = Convert.ToDouble(sNum);

        //Console.WriteLine("Enter 2nd number: ");
        //string sNum2 = Console.ReadLine();
        //double num2 = Convert.ToDouble(sNum2);

        //Console.WriteLine(num + num2);



        // ---- 9.building mad libs game ----
        //string color, plural, people;

        //Console.Write("Enter a color : ");
        //color = Console.ReadLine();

        //Console.Write("Enter a plural : ");
        //plural = Console.ReadLine();

        //Console.Write("Enter a people : ");
        //people = Console.ReadLine();

        //Console.WriteLine($"Roses are {color}");
        //Console.WriteLine($"{plural} are blue");
        //Console.WriteLine($"I Love {people}");



        // ----- 10.arrays -----
        // variable can only store single value
        // what if we want to store multiple value?

        //int[] unluckyNumbers = { 1,2,3,4,5,6,7,8,9 }; // these are called element of array
        //string[] friends = new string[3]; // in case we havent put any element upfront
        //// the size is configures upfront
        //friends[0] = "miki";
        //friends[1] = "moli";
        //friends[2] = "jeki";

        //unluckyNumbers[8] = 1;

        //Console.WriteLine(unluckyNumbers[5]);
        //Console.WriteLine(unluckyNumbers[8]);
        //Console.WriteLine(friends);
        //Console.WriteLine(friends[0]);



        // ----- 11.methods -----
        //SayHi("shit",1);
        //SayHi("damn",2);
        //SayHi("well shit",69);



        // --- 12.return statement ---
        double shit = Cube(18.5);
        Console.WriteLine(shit); // or
        Console.WriteLine(Cube(18.5));

    }

    // ----- 11.methods -----
    static void SayHi(string name, int age) // static, return type, name
    {
        Console.Write("Hello User " + name);
        Console.WriteLine(" you are " + age);
    }

    // --- 12.return statement ---
    static double Cube(double num)
    {
        //return num * num * num; // or
        return Math.Pow(num, 3);

        // you can also return an array
    }

}

