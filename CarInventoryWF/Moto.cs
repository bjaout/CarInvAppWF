using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInventoryWF
{
    [Serializable]
    class Moto : MotorVehicle
    {
        private int nbHelmet;
        protected int NbHelmet
        {
            get { return nbHelmet; }
            set { nbHelmet = value; }
        }

        public Moto(string brand, string model, int nbGearRatio, int horsePower, int nbHelmet)
        {
            this.Brand = brand;
            this.Model = model;
            this.NbGearRatio = nbGearRatio;
            this.HorsePower = horsePower;
            this.NbWheel = 2;
            this.NbHelmet = nbHelmet;
        }

        public override string Drive()
        {
            throw new NotImplementedException();
        }

        public override string Park()
        {
            throw new NotImplementedException();
        }

        public override string Start()
        {
            throw new NotImplementedException();
        }

        public override string Stop()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            string textValue;
            textValue = "Je suis une moto de marque " + this.Brand + " de modèle " + this.Model + " avec " + this.NbHelmet + " casque(s).\n";
            textValue += "Je possède une puissance de " + this.HorsePower + " chevaux, avec " + NbGearRatio + " vitesses.\n";
            return textValue;
        }
    }
}
