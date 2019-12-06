namespace TPBuilder
{
    public sealed class AircraftFactory
    {
        private static AircraftFactory aircraftFactory;// Aircraft factory instance

        private AircraftFactory() { }

        /// <summary>
        /// Singleton get instance
        /// </summary>
        /// <returns>AircraftFactory's instance</returns>
        public static AircraftFactory GetAircraftFactory()
        {
            if (aircraftFactory == null)
                aircraftFactory = new AircraftFactory();
            return aircraftFactory;
        }
        /// <summary>
        /// Create a cargo plane
        /// </summary>
        /// <param name="name"></param>
        /// <param name="speed"></param>
        /// <param name="maintenance"></param>
        /// <param name="loadingTime"></param>
        /// <param name="unLoadingTime"></param>
        /// <param name="weight"></param>
        /// <returns></returns>
        public static Aircraft CreateCargoPlane(string name, int speed, int maintenance, int loadingTime, int unLoadingTime, int weight)
        {
            return new CargoPlane(name, speed, maintenance, loadingTime, unLoadingTime, weight);
        }
        /// <summary>
        /// Create a passenger plane
        /// </summary>
        /// <param name="name"></param>
        /// <param name="speed"></param>
        /// <param name="maintenance"></param>
        /// <param name="loadingTime"></param>
        /// <param name="unLoadingTime"></param>
        /// <param name="capacity"></param>
        /// <returns></returns>
        public static Aircraft CreatePassengerPlane(string name, int speed, int maintenance, int loadingTime, int unLoadingTime , int capacity)
        {
            return new CargoPlane(name, speed, maintenance, loadingTime, unLoadingTime, capacity);
        }
        /// <summary>
        /// Create a water bomber
        /// </summary>
        /// <param name="name"></param>
        /// <param name="speed"></param>
        /// <param name="maintenance"></param>
        /// <param name="droppingTime"></param>
        /// <param name="waterCapacity"></param>
        /// <returns></returns>
        public static Aircraft CreateWaterBomber(string name, int speed, int maintenance, int droppingTime, int waterCapacity)
        {
            return new WaterBomber(name, speed, maintenance, droppingTime, waterCapacity);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="speed"></param>
        /// <param name="maintenance"></param>
        /// <returns></returns>
        public static Aircraft CreateObserverPlane(string name,  int speed, int maintenance)
        {
            return new ObserverPlane(name, speed, maintenance);
        }
        /// <summary>
        /// Create a rescue helicopter
        /// </summary>
        /// <param name="name"></param>
        /// <param name="speed"></param>
        /// <param name="maintenance"></param>
        /// <returns></returns>
        public static Aircraft CreateRescueHelicopter(string name,  int speed, int maintenance)
        {
            return new RescueHelicopter(name, speed, maintenance);
        }
    }
}
