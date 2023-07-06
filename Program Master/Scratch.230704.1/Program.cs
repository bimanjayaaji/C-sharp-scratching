namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            // -------- 1.first step ---------
            //Console.WriteLine("Hello World!");



            // ---------- 2.shape ------------
            //Console.WriteLine(@"\   |"); // @ kepake buat ngeprint "\" as it is. bukan sebagai enter
            //Console.WriteLine(@" \  |");
            //Console.WriteLine(@"  \ |");
            //Console.WriteLine(@"   \|");



            // -------- 3.variables ----------
            // what if I want to change the name or age not manually change the string?
            // imagine if the lines are hundreds
            //string characterName = "John",
            //    characterDog = "Miki";
            //int characterAge = 35, 
            //    characterWeight = 60;

            //Console.WriteLine("There was once a man named " + characterName);
            //Console.WriteLine("He was " + characterAge + " years old");
            //Console.WriteLine("He really liked the name " + characterName);
            //Console.WriteLine("But didn't like being " + characterAge);
            //Console.WriteLine("His weight was " + characterWeight);
            //Console.WriteLine("He had a dog called " + characterDog);

            //characterName = "Moli";
            //Console.WriteLine("Now the name is " + characterName);



            // -------- 4.data types ---------
            //string phrase = "Miki Academy";
            //char grade = 'A'; // one single character only
            //int weight = -30;
            //float myFloat = 3; // least accurate
            //double myDouble = 3.0; // accurate
            //decimal myDecimal = 3; // most accurate
            //// kalo aku bikin decimal dengan nilai 3.0 malah error
            //// jadi 3.0 dianggap double!
            //bool isMale = true;
            //// basically these are enough data types to be used as beginner



            // ---- 5.working w/ strings -----
            //Console.WriteLine("Giraffe\nAcademy"); // print in new line
            //Console.WriteLine(@"Giraffe\nAcademy"); // print \n as it is
            //Console.WriteLine("\n");

            //string phrase = "Hello Ferguso";
            //Console.WriteLine(phrase);
            //phrase = "Hello Ferguso" + ", you are cool";
            //Console.WriteLine(phrase);
            //Console.WriteLine("\n");

            //Console.WriteLine(phrase.Length); // methods for string!!!
            //Console.WriteLine(phrase.ToUpper()); // convert to upper
            //Console.WriteLine(phrase.ToLower()); // convert to lower
            //Console.WriteLine(phrase.Contains("Academy")); // find if there is some specific phrase
            //Console.WriteLine(phrase[0]); // indexing like python
            //Console.WriteLine(phrase[3]);
            //Console.WriteLine(phrase.IndexOf("Ferguso")); // nyari index dari suatu karakter/string
            //Console.WriteLine(phrase.IndexOf("Fergusoni")); // gegara ga ada, jadi nilainya -1
            //Console.WriteLine(phrase.IndexOf("l")); // the first l
            //Console.WriteLine(phrase.Substring(8)); // take rest of the string from that index
            //Console.WriteLine(phrase.Substring(8,3)); // take 3 char after index 8



            // ---- 6.working with numbers ----
            //Console.WriteLine(5 + 8);
            //Console.WriteLine(5 - 8);
            //Console.WriteLine(5 / 8); // kok 0?
            //Console.WriteLine(5 * 8);
            //Console.WriteLine(5 % 8);
            //Console.WriteLine(5 / 8);

            //double division = 5 / 8;
            //Console.WriteLine(division); // ????? hmmm

            //division = 5 / 8.0;
            //Console.WriteLine(division); // ????? hmmm

            //// first of all, C# does distinguish between int and decimal
            //// kalo operasi pake int dengan int, hasilnya int
            //// kalo operasi pake int dan dec, maka hasilnya dec

            //division++;
            //Console.WriteLine(division);

            ////math operations
            //Console.WriteLine(Math.Abs(-50));
            //Console.WriteLine(Math.Pow(3,3));
            //Console.WriteLine(Math.Pow(3.4, 3));
            //Console.WriteLine(Math.Sqrt(37));
            //Console.WriteLine(Math.Max(4, 90)); // manfaate opo nda iki?
            //Console.WriteLine(Math.Min(4, 90));
            //Console.WriteLine(Math.Round(4.6));
            //Console.WriteLine(Math.Round(4.2));

        }
    }
}
