using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLicence
{
    public interface IRoadVehicule : IVehicule
    {
       public float MaxLegalSpeed();
    }
}
