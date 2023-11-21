using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PROG301_DI_AerialVehicle.Interfaces;
using PROG301_DI_AerialVehicle.Models.Engines;


namespace PROG301_DI_AerialVehicle.Models.AerialVehicles
{
    public class Helicopter : AerialVehicle
    {
        public Helicopter()
        {
            Engine = new ReciprocatingEngine();
            MaxAltitude = 8000;
        }

        public Helicopter(IEngine engine)
        {
            Engine = engine;
            MaxAltitude = 8000;
        }
    }
}
