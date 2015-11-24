using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInventoryWF
{
    static class GlobalData
    {
        static private int choice;
        static public int Choice
        {
            get { return choice; }
            set { choice = value; }
        }

        static private Vehicle vehicule;
        static public Vehicle Vehicule
        {
            get { return vehicule; }
            set { vehicule = value; }
        }
    }
}
