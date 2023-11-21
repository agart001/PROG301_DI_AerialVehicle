using PROG301_DI_AerialVehicle.Interfaces;
using PROG301_DI_AerialVehicle.Models;
using PROG301_DI_AerialVehicle.Models.AerialVehicles;
using PROG301_DI_AerialVehicle.Models.Engines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Injection;

namespace PROG301_DI_AerialVehicle.Containers
{
    public static class UnityBootstrap
    {
        public static void RegisterType(IUnityContainer container)
        {
            container.RegisterType<IEngine, BaseEngine>();

            container.RegisterType<Airplane>(new InjectionConstructor(new JetEngine()));
            container.RegisterType<Drone>(new InjectionConstructor(new UAVEngine()));
            container.RegisterType<Helicopter>(new InjectionConstructor(new ReciprocatingEngine()));
            container.RegisterType<ToyPlane>(new InjectionConstructor(new RubberBandEngine()));
        }
    }
}
