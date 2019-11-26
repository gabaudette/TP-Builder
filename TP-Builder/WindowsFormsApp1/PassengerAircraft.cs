namespace TPBuilder
{
    public class PassengerAircraft : Aircraft
    {
        public int LoadingTime { get; protected set; }
        public int UnloadingTime { get; protected set; }

        public PassengerAircraft(string name, int loadingTime, int unloadingTime) : base(name)
        {
            LoadingTime = loadingTime;
            UnloadingTime = unloadingTime;
        }
    }
}
