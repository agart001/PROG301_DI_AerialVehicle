using PROG301_DI_AerialVehicle.Models;

namespace PROG301_DI_AerialVehicle.Interfaces
{
    
    public interface IEngine : IAboutable
    {
        public bool IsStarted { get; protected set;}

        public void Start();
        public void Stop();
    }

}