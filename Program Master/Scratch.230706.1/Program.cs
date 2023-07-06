namespace Lion;

class Program
{
    static void Main(string[] args)
    {
        // ----- 20.building an exponent method -----
        //Console.Write(GetPow(10, 5));



        // ----------- 21. 2d arrays -----------
        //int[,] numberGrid = {
        //    {1, 2 },
        //    {3, 4 }, 
        //    {5, 6 },
        //};

        //int[,] myArray = new int[2,3]; // how many rows and columns

        //Console.WriteLine(numberGrid[0, 0]);
        //Console.WriteLine(numberGrid[1, 1]);



        // ----------- 22.comments -----------
        /* asdasdasd
         * asdasdasdasd
         * asdasdasdasd
         * asdasdasdasdas
         * dasdasdasdasd
         */



        // ----------- 23.exception handling -----------
        // keep the program to keep going when error occurs
        // make our program more durable

        //try
        //{
        //    Console.Write("Enter a number: ");
        //    int num1 = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Enter another number: ");
        //    int num2 = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine(num1 / num2);
        //} // when we enter 0 or not-number-string
        //catch(Exception e)
        //{
        //    Console.WriteLine(e.Message);
        //}
 
        /*
         * NICEE!!
         * what if we want to define specific method
         * for specific error?
         * we can do multiple catch
         */

        try
        {
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 / num2);
        } // when we enter 0 or not-number-string
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }
        finally // gonna get executed no matter what. optional.
        {
        }
    }

    // ----- 20.building an exponent method -----
    static int GetPow(int baseNum, int powNum)
    {
        int result = 1;

        for(int i = 1; i <= powNum; i++)
        {
            result = result * baseNum;
        }

        return result;
    }
}
