using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInventoryWF
{
    [Serializable]
    abstract class Vehicle
    {
        private int nbWheel;
        protected int NbWheel
        {
            get { return nbWheel; }
            set { nbWheel = value; }
        }

        private string brand;
        protected string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        private string model;
        protected string Model
        {
            get { return model; }
            set { model = value; }
        }


        public abstract string Drive();
        public abstract string Park();

    }
}
