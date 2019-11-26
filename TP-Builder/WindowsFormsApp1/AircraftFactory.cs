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
        //type?
        public static Aircraft CreateAircraft(string name, string type)
        {
            Aircraft aircraft = null;
            switch (type)
            {
                case "CargoPlane":
                    aircraft = new CargoPlane(name);
                    break;
                case "ObserverPlane":
                    aircraft = new ObserverPlane(name);
                    break;
                case "PassengerPlane":
                    aircraft = new PassengerPlane(name);
                    break;
                case "RescueHelicopter":
                    aircraft = new RescueHelicopter(name);
                    break;
                case "WaterBomber":
                    aircraft = new WaterBomber(name);
                    break;
            }
            return aircraft;
        }
    }
}
