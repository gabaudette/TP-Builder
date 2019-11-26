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

        public static Aircraft CreateAircraft(string name, string type)
        {
            Aircraft aircraft = null;
            switch (type)
            {
                case "Cargo Plane":
                    aircraft = new CargoPlane(name);
                    break;
                case "Observer Plane":
                    aircraft = new ObserverPlane(name);
                    break;
                case "Passenger Plane":
                    aircraft = new PassengerPlane(name);
                    break;
                case "Rescue Helicopter":
                    aircraft = new RescueHelicopter(name);
                    break;
                case "Water Bomber":
                    aircraft = new WaterBomber(name);
                    break;
            }
            return aircraft;
        }
    }
}
