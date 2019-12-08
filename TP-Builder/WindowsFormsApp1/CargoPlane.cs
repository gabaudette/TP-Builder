 namespace TPBuilder
{
    public class CargoPlane : PassengerAircraft
    {
        public CargoPlane() { }

        public CargoPlane(string name,  int speed, int maintenance,  int loadingTime, int unloadingTime, int capacity) : base(name, speed, maintenance, loadingTime, unloadingTime, capacity)
        {
        }
    }
}
