using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLicence
{
    public class TruckTemplate : ITruck 
    {
        string licencePlate;
        float maxLegalSpeed;
        float maxFreight;

        public TruckTemplate(string licencePlate, float maxLegalSpeed, float maxFreight)
        {
            this.licencePlate = licencePlate;
            this.maxLegalSpeed = maxLegalSpeed;
            this.maxFreight = maxFreight;
        }

        public string LicencePlate()
        {
            throw new NotImplementedException();
        }


        public float MaxLegalSpeed()
        {
            throw new NotImplementedException();
        }

        public float MaxFreight()
        {
            throw new NotImplementedException();
        }

    }
}
