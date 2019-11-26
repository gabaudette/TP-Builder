namespace TPBuilder
{
    public class PassengerPlane : PassengerAircraft
    {
        public int Capacity { get; private set; }
        public PassengerPlane(string name, int loadingTime, int unloadingTime , int capacity) : base(name, loadingTime, unloadingTime)
        {
            Capacity = capacity;
        }
    }
}
