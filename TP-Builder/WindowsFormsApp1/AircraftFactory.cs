using System.Xml.Serialization;

namespace TPBuilder
{
    public sealed class AircraftFactory
    {
        private static AircraftFactory aircraftFactory;
        private AircraftFactory() { }

        public static AircraftFactory GetAircraftFactory()
        {
            if (aircraftFactory == null)
                aircraftFactory = new AircraftFactory();
            return aircraftFactory;
        }

        public static Aircraft CreateCargoPlane(string name, int speed, int maintenance, int loadingTime, int unLoadingTime, int weight)
        {
            return new CargoPlane(name, speed, maintenance, loadingTime, unLoadingTime, weight);
        }

        public static Aircraft CreatePassengerPlane(string name, int speed, int maintenance, int loadingTime, int unLoadingTime , int capacity)
        {
            return new CargoPlane(name, speed, maintenance, loadingTime, unLoadingTime, capacity);
        }

        public static Aircraft CreateWaterBomber(string name, int speed, int maintenance, int droppingTime, int waterCapacity)
        {
            return new WaterBomber(name, speed, maintenance, droppingTime, waterCapacity);
        }

        public static Aircraft CreateObserverPlane(string name,  int speed, int maintenance)
        {
            return new ObserverPlane(name, speed, maintenance);
        }

        public static Aircraft CreateRescueHelicopter(string name,  int speed, int maintenance)
        {
            return new RescueHelicopter(name, speed, maintenance);
        }

    }
}
