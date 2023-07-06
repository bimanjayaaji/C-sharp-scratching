using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chicken;

// ----------- 30.inheritance -----------

class Chef
{
    public void MakeChicken()
    {
        Console.WriteLine("making chicken");
    }
    public void MakeSalad()
    {
        Console.WriteLine("making salad");
    }
    public virtual void MakeSpecialDish() // notice the "virtual"
    {
        Console.WriteLine("chef making bbq ribs");
        // this method can be overrode by the subclass
    }

}
