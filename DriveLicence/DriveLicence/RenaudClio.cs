using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLicence
{
   public  class RenaudClio : ICar
    {
        CarTemplate implementation;

        public RenaudClio(string licencePlate, float maxLegalSpeed, int maxPassengerCount) {

            implementation = new CarTemplate(licencePlate, maxLegalSpeed, maxPassengerCount);
        }

        public string LicencePlate()
        {
            return ((IVehicule)implementation).LicencePlate();
        }

        public float MaxLegalSpeed()
        {
            return ((IRoadVehicule)implementation).MaxLegalSpeed();
        }

        public int MaxPassengerCount()
        {
            return ((ICar)implementation).MaxPassengerCount();
        }
    }
}
