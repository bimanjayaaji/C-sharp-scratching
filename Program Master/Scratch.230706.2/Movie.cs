using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chicken;

// ----------- 27.getters and setters -----------
class Movie
{
    public string title;
    public string director;
    private string rating; // notice the "private"

    public Movie(string title, string director, string rating)
    {
        this.title = title;
        this.director = director;
        //this.rating = rating;

        // you can also do this
        Rating = rating; // set the rating through the setter down here
    }

    public string Rating
    {
        get { return this.rating; }
        set // if we want to set rating. user have to go through this if statement. makes it more secure
        {
            if (value == "G" ||  value == "PG" || value == "PG13" || value == "NR" || value == "R")
            {
                this.rating = value;
            }
            else
            {
                this.rating = "NR"; // default 
            }
        }
    }
}
