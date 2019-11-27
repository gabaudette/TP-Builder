﻿namespace TPBuilder
{
    public class CargoPlane : PassengerAircraft
    {
        public int Weight { get; private set; }

        public CargoPlane(string name,  int speed, int maintenance,  int loadingTime, int unloadingTime, int weigth) : base(name, speed, maintenance, loadingTime, unloadingTime)
        {
            Weight = weigth;
        }
    }
}
