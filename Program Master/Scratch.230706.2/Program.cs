namespace Chicken;

class Program
{
    static void Main(string[] args)
    {
        // ----------- 24.object and class -----------

        //Book book = new Book(); // an instance of a book
        //book.title = "Narnia";
        //book.author = "Lewis";
        //book.pages = 400;

        //Book book1 = new Book(); // an instance of a book
        //book1.title = "LOTR";
        //book1.author = "Tolkien";
        //book1.pages = 500;

        //Console.WriteLine(book.title);
        //Console.WriteLine(book.author);
        //Console.WriteLine(book1.title);
        //Console.WriteLine(book1.author);



        // ----------- 25.constructor -----------
        //Book book = new Book("CIL","Eka",200);
        //Book book1 = new Book("LB","Leila",400);
        //Book book2 = new Book();



        // ----------- 26.object methods -----------
        //Student student1 = new Student("Ferguso", "Engineering", 2.8);
        //Student student2 = new Student("Alex", "Med", 3.6);

        //Console.WriteLine(student1.HasHonors());
        //Console.WriteLine(student1.HasHonors());



        // ----------- 27.getters and setters -----------
        // control the access that people has of the attributes of that classes.
        // makes class more secure.

        //Movie avengers = new Movie("avengers","joss","PG13");
        //Movie shrek = new Movie("shrek", "adam", "PG");
        //Movie check = new Movie("check", "check", "Dog");
        //// G, PG, PG13, R, NR

        ////Console.WriteLine(avengers.rating); // error because "private"
        ////avengers.rating = "Dog"; // error because "private"

        //Console.WriteLine(check.Rating); // will return "NR". gets filtered by setter
        //check.Rating = "R"; // you can do this because its a valid rating
        //Console.WriteLine(check.Rating);



        // ----------- 28.static class attributes -----------

        //Song holiday = new Song("holiday", "green day", 200);
        //Song kashmir = new Song("kashmir", "zeppelin", 150);

        //Console.WriteLine(holiday.title);
        //Console.WriteLine(kashmir.title);

        /*
         * when you create an object, you are allowing it to has its own unique attributes.
         * in this case, holiday has its own title, artist, and duration.
         * this is a normal attributes.
         * 
         * and there is a STATIC attributes.
         * isnt unique to each of the objects
         * static attribute is an attribute about the actual class <--- THIS!
         * static attribute will be the same across all of the object of the class
         */

        //Console.WriteLine(Song.songCount); // because songCount is static
        ////Console.WriteLine(Song.title); // error
        ////Console.WriteLine(Song.artist); // error

        //Song pergi = new Song("di", "hari", 150);
        //Console.WriteLine(Song.songCount);

        //Song bawah = new Song("batu", "kini", 150);
        //Console.WriteLine(bawah.getSongCount()); // result is 4



        // ----------- 29.static method and classes ----------- !!!
        // like attributes, static method is a method that belongs to the actual class

        //Console.WriteLine(Math.Sqrt(144)); // Sqrt is the static method of the Math class
        //// we dont have to create an instance of the Math class
        //// but we can access the method inside Math class
        //// thats static!

        //UsefulTools.SayHi("shit");

        //Math myMath = new Math(); // error.cannot create an instance because Math class is a static class
        //UsefulTools myTools = new UsefulTools(); // UsefulTools is not static class. just has a static method
        //// now UsefulTools is static, so it shows error



        // ----------- 30.inheritance -----------
        // class can inherit attributes or methods from other classes

        Chef chef = new Chef();
        chef.MakeChicken();

        ItalianChef italianchef = new ItalianChef();
        italianchef.MakeChicken();
        italianchef.MakePasta();

        //chef.MakePasta(); // error

        // about virtual ---> overriding
        Console.WriteLine("");
        chef.MakeSpecialDish();
        italianchef.MakeSpecialDish(); // at this point, both of them are making bbq ribs. kakean. mubadzir.
        // I just changed it, so its gotta look different now :)

        /*
         * 1. You can inherit concrete class attributes and methods
         * 2. You can extend it by adding more attributes and methods
         * 3. You can override the methods by using "virtual" and "override" keyword
         */

    }
}
