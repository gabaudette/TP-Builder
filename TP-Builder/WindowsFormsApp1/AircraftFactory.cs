﻿namespace TPBuilder
{
    public sealed class AircraftFactory
    {
        private static AircraftFactory aircraftFactory;

        private AircraftFactory(){}

        public static AircraftFactory GetAircraftFactory()
        {
            if (aircraftFactory == null)
                aircraftFactory = new AircraftFactory();
            return aircraftFactory;
        }

        public Aircraft CreateAircraft(//type?)
        {

            return null;
        }
    }
}
