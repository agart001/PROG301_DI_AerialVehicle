﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PROG301_DI_AerialVehicle.Models.Engines;


namespace PROG301_DI_AerialVehicle.Models.AerialVehicles
{
    public class Airplane : AerialVehicle
    {
        public Airplane()
        {
            Engine = new JetEngine();
            MaxAltitude = 41000;
        }
    }
}
