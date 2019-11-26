namespace TPBuilder
{
    public class CargoPlane : PassengerAircraft
    {
        public int Weight { get; private set; }
        public CargoPlane(string name, int loadingTime, int unloadingTime, int weigth) : base(name, loadingTime, unloadingTime)
        {
            Weight = weigth;
        }
    }
}
