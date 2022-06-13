using Microsoft.VisualStudio.TestTools.UnitTesting;
using DriveLicence;
using System;

namespace TestCar
{
 // TOUJOURS utiliser implementation de l'interface    

    public class FakeCarTemplate : CarTemplate, IVehicule, ICar, IRoadVehicule
    {
        public int count = 0;

        // toujours initialier le FakeTemplate avec les mêmes paramètres que le template initial ici CarTemple (string, float, int)
        public FakeCarTemplate() : base("plate", 130f, 5)
        {
        }

        string IVehicule.LicencePlate() 
        {
            count += 1;
            return "FUSEE3000";
        }

        float IRoadVehicule.MaxLegalSpeed()
        {
            return 250;
        }

        int ICar.MaxPassengerCount()
        {   
            return 4;
        }

        
    }

    public class NissanMicra : ICar
    {

        public NissanMicra(CarTemplate car)
        {
            carTemplate = car;
        }

        CarTemplate carTemplate;

        public float MaxLegalSpeed()
        {
            return ((IRoadVehicule)carTemplate).MaxLegalSpeed();
        }

        public int MaxPassengerCount()
        {
            return ((ICar)carTemplate).MaxPassengerCount();
        }

        public string LicencePlate()
        {
            return ((IVehicule)carTemplate).LicencePlate();
        }

    }

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var iface = new FakeCarTemplate();
            var fefe = new NissanMicra(iface);

            Assert.AreEqual("FUSEE3000", fefe.LicencePlate());
            Assert.AreEqual(250, fefe.MaxLegalSpeed());
            Assert.AreEqual(4, fefe.MaxPassengerCount());
        }
    }
}
