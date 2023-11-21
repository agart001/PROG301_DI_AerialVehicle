using PROG301_DI_AerialVehicle.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PROG301_DI_AerialVehicle.Models
{
    public class Engine : IEngine
    {
        public bool IsStarted { get; set; }

        public Engine()
        {
            IsStarted = false;
        }

        public virtual void Start()
        {
            IsStarted =  true;
        }

        public virtual void Stop()
        {
            IsStarted = false;
        }

        public string About()
        {
            string engineString = ToString() + " is not started.";
            if (IsStarted)
            {
                engineString = engineString.Replace("not ", "");
            }
            return engineString;
        }
    }
}
