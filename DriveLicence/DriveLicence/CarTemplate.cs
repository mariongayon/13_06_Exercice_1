using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLicence
{
    public class CarTemplate : ICar
    {
        string licencePlate;
        float maxLegalSpeed;
        int maxPassengerCount;

        public CarTemplate(string licencePlate, float maxLegalSpeed, int maxPassengerCount)
        {
            this.licencePlate = licencePlate;
            this.maxLegalSpeed = maxLegalSpeed;
            this.maxPassengerCount = maxPassengerCount;
        }

        public string LicencePlate()
        {
            throw new NotImplementedException();
        }

        public float MaxLegalSpeed()
        {
            throw new NotImplementedException();
        }

        public int MaxPassengerCount()
        {
            throw new NotImplementedException();
        }
    }
}
