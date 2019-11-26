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

        public static Aircraft CreateCargoPlane(string name, int loadingTime, int unLoadingTime, int weigth)
        {
            return new CargoPlane(name, loadingTime, unLoadingTime, weigth);
        }

        public static Aircraft CreatePassengerPlane(string name, int loadingTime, int unLoadingTime , int capacity)
        {
            return new CargoPlane(name, loadingTime, unLoadingTime, capacity);
        }

        public static Aircraft CreateWaterBomber(string name, int droppingTime, int waterCapacity)
        {
            return new WaterBomber(name, droppingTime, waterCapacity);
        }

        public static Aircraft CreateObserverPlane(string name)
        {
            return new ObserverPlane(name);
        }

        public static Aircraft CreateRescueHelicopter(string name)
        {
            return new RescueHelicopter(name);
        }

    }
}
