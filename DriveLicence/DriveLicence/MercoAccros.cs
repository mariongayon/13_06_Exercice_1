using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLicence
{
    class MercoAccros : ITruck
    {
        TruckTemplate implementation;

        public MercoAccros(string licencePlate, float maxLegalSpeed, float maxFreight) {

            implementation = new TruckTemplate(licencePlate, maxLegalSpeed, maxFreight);
        }

        public string LicencePlate()
        {
            return implementation.LicencePlate();
        }

        public float MaxLegalSpeed()
        {
            return implementation.MaxLegalSpeed();
        }

        public float MaxFreight()
        {
            return implementation.MaxFreight();
        }
    }
}
