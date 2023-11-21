using PROG301_DI_AerialVehicle.Containers;
using PROG301_DI_AerialVehicle.Interfaces;
using PROG301_DI_AerialVehicle.Models;
using PROG301_DI_AerialVehicle.Models.AerialVehicles;
using PROG301_DI_AerialVehicle.Models.Engines;
using Unity;

namespace UnitTests
{
    [TestClass]
    public class DITests
    {
        IUnityContainer Ucontainer { get; set; }

        public DITests() 
        {
            Ucontainer = new UnityContainer();
            UnityBootstrap.RegisterType(Ucontainer);
        }

        [TestMethod]
        public void AirplaneUMod()
        {
            //Arrange
            AerialVehicle av;
            IEngine eng;
            
            //Act
            av = Ucontainer.Resolve<Airplane>();
            eng = av.Engine ?? throw new ArgumentNullException(nameof(av));

            //Assert
            Assert.IsInstanceOfType(av, typeof(AerialVehicle));
            Assert.IsInstanceOfType(av, typeof(Airplane));

            Assert.IsInstanceOfType(eng, typeof(Engine));
            Assert.IsInstanceOfType(eng, typeof(JetEngine));
        }

        [TestMethod]
        public void DroneUMod()
        {
            //Arrange
            AerialVehicle av;
            IEngine eng;

            //Act
            av = Ucontainer.Resolve<Drone>();
            eng = av.Engine ?? throw new ArgumentNullException(nameof(av));

            //Assert
            Assert.IsInstanceOfType(av, typeof(AerialVehicle));
            Assert.IsInstanceOfType(av, typeof(Drone));

            Assert.IsInstanceOfType(eng, typeof(Engine));
            Assert.IsInstanceOfType(eng, typeof(UAVEngine));
        }

        [TestMethod]
        public void HelicopterUMod()
        {
            //Arrange
            AerialVehicle av;
            IEngine eng;

            //Act
            av = Ucontainer.Resolve<Helicopter>();
            eng = av.Engine ?? throw new ArgumentNullException(nameof(av));

            //Assert
            Assert.IsInstanceOfType(av, typeof(AerialVehicle));
            Assert.IsInstanceOfType(av, typeof(Helicopter));

            Assert.IsInstanceOfType(eng, typeof(Engine));
            Assert.IsInstanceOfType(eng, typeof(ReciprocatingEngine));
        }

        [TestMethod]
        public void ToyplaneUMod()
        {
            //Arrange
            AerialVehicle av;
            IEngine eng;

            //Act
            av = Ucontainer.Resolve<ToyPlane>();
            eng = av.Engine ?? throw new ArgumentNullException(nameof(av));

            //Assert
            Assert.IsInstanceOfType(av, typeof(AerialVehicle));
            Assert.IsInstanceOfType(av, typeof(ToyPlane));

            Assert.IsInstanceOfType(eng, typeof(Engine));
            Assert.IsInstanceOfType(eng, typeof(RubberBandEngine));
        }
    }
}