namespace Elephant;

class Program
{
    static void Main(string[] args)
    {

        // ----- 13.if statements -----
        //bool isMale = false;
        //bool isTall = false;

        //if (isMale )
        //{
        //    Console.WriteLine("You are male");
        //} 
        //else
        //{
        //    Console.WriteLine("You are not male");
        //}

        //if (isMale && isTall) // and
        //{
        //    Console.WriteLine("You are a tall male");
        //}
        //else
        //{
        //    Console.WriteLine("You are not tall or not male or not both");
        //}

        //if (isMale || isTall) // or
        //{
        //    Console.WriteLine("You are tall or a male or both");
        //}
        //else
        //{
        //    Console.WriteLine("You are not tall male");
        //}

        //if (isMale && isTall)
        //{
        //    Console.WriteLine("You are a tall male");
        //}
        //else if (isMale && !isTall)
        //{
        //    Console.WriteLine("You are a short male");
        //}
        //else if (!isMale && isTall)
        //{
        //    Console.WriteLine("You are not a male but you are tall");
        //}
        //else
        //{
        //    Console.WriteLine("You are not tall and not male");
        //}



        // ----- 14.more if statements -----
        //Console.WriteLine(GetMax(4, 6, 10));



        // ----- 15.better calculator -----
        //Console.Write("Enter 1st number: "); 
        //double num1 = Convert.ToDouble(Console.ReadLine()); // mungkin ben robust kasih if checker (not string)

        //Console.Write("Enter Operator: ");
        //string op = Console.ReadLine();

        //Console.Write("Enter 2nd number: ");
        //double num2 = Convert.ToDouble(Console.ReadLine()); // mungkin ben robust kasih if checker (not string)

        //if (op == "+")
        //{
        //    Console.WriteLine(num1 + num2);
        //} else if (op == "-")
        //{
        //    Console.WriteLine(num1 - num2);
        //} else if (op == "*")
        //{
        //    Console.WriteLine(num1 * num2);
        //} else if (op == "/")
        //{ 
        //    Console.WriteLine(num1 / num2);
        //} else
        //{
        //    Console.WriteLine("invalid op");
        //}



        // ----- 16.switch statements -----
        //Console.WriteLine(GetDay(5));



        // ----- 17.while loops -----
        //int index = 1;
        //while (index <= 5)
        //{
        //    Console.WriteLine(index);
        //    index++;
        //}
        //Console.WriteLine("");

        //// dowhile loops
        //index = 1;
        //do
        //{
        //    Console.WriteLine(index);
        //    index++;
        //} while (index <= 5);
        //// jadi while nya bakal jalan sekali sebelum beneran ngeloop



        // ----- 18.guessing game -----
        //string secretWord = "elephant";
        //string guess = "";
        //int trial = 0;
        //bool outOfGuesses = false;

        //while (guess != secretWord && trial != 5)
        //{
        //    Console.Write("Enter Guess: ");
        //    guess = Console.ReadLine();
        //    trial++;
        //}
        //if (trial == 5)
        //{
        //    Console.WriteLine("You lose!");
        //}
        //else
        //{
        //    Console.WriteLine("You win!");
        //}



        // ----- 19.for loops -----
        //int i = 0;
        //while (i <= 5)
        //{
        //    Console.WriteLine(i);
        //    i++;
        //} // we can actually do this using for loops

        //Console.WriteLine("");

        //for (int j = 1; j <= 5; j++)
        //{
        //    Console.WriteLine(j);
        //}

        //Console.WriteLine("");

        //int[] luckyNums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        //for (int k = 0; k < luckyNums.Length; k++)
        //{
        //    Console.WriteLine(luckyNums[k]);
        //}


    }

    // ----- 14.more if statements -----
    static int GetMax(int num1, int num2, int num3)
    {
        if (num1 >= num2 && num1 >= num3)
        {
            return num1;
        }
        else if (num2 >= num1 && num2 >= num3) 
        {
            return num2;
        } 
        else
        {
            return num3;
        }
    }

    // ----- 16.switch statements -----
    // jane isa pake if, tapi switch bikin lebih gampang in this case
    static string GetDay(int dayNum)
    {
        string dayName;

        switch (dayNum)
        {
            case 0:
                dayName = "Sunday"; 
                break; // break kek di python. keluar dari scope proses sekarang

            case 1:
                dayName = "Monday";
                break;

            case 2:
                dayName = "Tuesday";
                break;

            default: // kek jadi error message. soale ga match apa2
                dayName = "Invalid num";
                break;
        }

        return dayName;
    }
        
}