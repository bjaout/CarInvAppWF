using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInventoryWF
{
    [Serializable]
    abstract class MotorVehicle:Vehicle
    {
        public enum DrivetrainType { RearWheel, FrontWheel };
        public enum GearboxType { Manual, Automatic };

        private int nbGearRation;
        protected int NbGearRatio
        {
            get { return nbGearRation; }
            set { nbGearRation = value; }
        }

        private int horsePower;
        protected int HorsePower
        {
            get { return horsePower; }
            set { horsePower = value; }
        }
        
        private DrivetrainType drivetrain;
        protected DrivetrainType Drivetrain
        {
            get { return drivetrain; }
            set { drivetrain = value; }
        }

        private GearboxType gearbox;
        protected GearboxType Gearbox
        {
            get { return gearbox; }
            set { gearbox = value; }
        }

        public abstract string Start();
        public abstract string Stop();
    }
}
