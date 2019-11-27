namespace TPBuilder
{
    public class PassengerPlane : PassengerAircraft
    {
        public int Capacity { get; set; }

        public PassengerPlane() { }
        public PassengerPlane(string name, int speed, int maintenance, int loadingTime, int unloadingTime , int capacity) : base(name, speed, maintenance, loadingTime, unloadingTime)
        {
            Capacity = capacity;
        }
    }
}
