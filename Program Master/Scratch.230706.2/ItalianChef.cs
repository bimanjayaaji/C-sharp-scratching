using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chicken;

// ----------- 30.inheritance -----------

//    parent      : child
//    superclass  : subclass
class ItalianChef : Chef
{
    // we can make another method
    public void MakePasta()
    {
        Console.WriteLine("making pasta");
    }

    // lets say italianchef doesnt wanna make bbq ribs for the special dish
    // lets just say he/she has his own special menu

    public override void MakeSpecialDish()
    {
        Console.WriteLine("chef is making chicken parm");
    }
}
