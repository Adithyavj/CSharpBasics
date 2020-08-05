using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PATA = ProjectA.TeamA; //Alias Name of a namespace "PATA"
using PATB = ProjectA.TeamB;

namespace ConsoleApp
{
    class NamespaceSample
    {
        public static void main()
        {
            PATA.ClassA.Print();
            PATB.ClassA.Print();
        }
    }
}

