using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chicken;

// ----------- 28.static class attributes -----------
class Song
{
    public string title;
    public string artist;
    public int duration;

    // static
    public static int songCount = 0;

    public Song(string title, string artist, int duration)
    {
        this.title = title;
        this.artist = artist;
        this.duration = duration;

        songCount++; // static variable in Song class to track the songCount
    }

    public int getSongCount() // so that we can access the songCount by calling each instance like "kashmir"
    {
        return songCount;
    }


}
