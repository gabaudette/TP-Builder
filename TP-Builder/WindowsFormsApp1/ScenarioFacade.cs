using System.Collections.Generic;

namespace TPBuilder
{
    public sealed class ScenarioFacade
    {
        private static ScenarioFacade instance = null;
        private AircraftFactory aircraftFactory;

        public List<Aircraft> Aircrafts { get; private set; }
        public List<Airport> Airports { get; private set; }


        private ScenarioFacade()
        {
            Airports = new List<Airport>();
            Aircrafts = new List<Aircraft>();
        }

        public static ScenarioFacade Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ScenarioFacade();
                }
                return instance;
            }
        }

        public void CreateAiport(string name, int x, int y)
        {

            if (ValidAirport(name))
            {
                if (ValidAirportPostion(x, y))
                {
                    Airports.Add(new Airport(name));
                    System.Console.WriteLine($"Airport <{name}> added at {x}, {y} Aiports List {Airports.Count}");
                }
                else
                {
                    System.Console.WriteLine($"Error : {x}, {y} are not valid positions ");
                }
            }
            else
            {
                System.Console.WriteLine($"Error : Airport : {name} already exist!");
            }
        }
    
        public void DeleteAirport(int index)
        {
            try
            {
                Airports.RemoveAt(index);
            }
            catch (System.ArgumentOutOfRangeException outOfRange)
            {
                System.Console.WriteLine($"Error: {index} is out of range {outOfRange.Message}");      
            }
        }

        public bool ValidAirport(string name)
        {
            if (Airports.Count > 0)
            {
                foreach (Airport airport in Airports)
                    if (airport.Name == name)
                        return false;
            }
            return true;
        }

        public bool ValidAirportPostion(int x, int y)
        {
            return true;
        }

        public void AddCargoPlane(string name, int speed, int maintenance, int loadingTime, int unLoadingTime, int weigth)
        {
            aircraftFactory = AircraftFactory.GetAircraftFactory();
            Aircraft aircraft = AircraftFactory.CreateCargoPlane(name, speed, maintenance, loadingTime, unLoadingTime, weigth);
            Aircrafts.Add(aircraft);
            //!For testing only REMOVE
            foreach (Aircraft air in Aircrafts)
            {
                System.Console.WriteLine($"Name : {air.Name}, Type: {air.GetType()}");
            }
        }

        public void AddPassengerPlane(string name, int speed, int maintenance, int loadingTime, int unLoadingTime, int capacity)
        {
            aircraftFactory = AircraftFactory.GetAircraftFactory();
            Aircraft aircraft = AircraftFactory.CreatePassengerPlane(name, speed, maintenance, loadingTime, unLoadingTime, capacity);
            Aircrafts.Add(aircraft);
            //!For testing only REMOVE
            foreach (Aircraft air in Aircrafts)
            {
                System.Console.WriteLine($"Name : {air.Name}, Type: {air.GetType()}");
            }
        }

        public void AddWaterBomber(string name, int speed, int maintenance, int droppingTime, int waterCapacity)
        {
            aircraftFactory = AircraftFactory.GetAircraftFactory();
            Aircraft aircraft = AircraftFactory.CreateWaterBomber(name, speed, maintenance, droppingTime, waterCapacity);
            Aircrafts.Add(aircraft);
            //!For testing only REMOVE
            foreach (Aircraft air in Aircrafts)
            {
                System.Console.WriteLine($"Name : {air.Name}, Type: {air.GetType()}");
            }
        }

        public void AddObserverPlane(string name , int speed, int maintenance)
        {
            aircraftFactory = AircraftFactory.GetAircraftFactory();
            Aircraft aircraft = AircraftFactory.CreateObserverPlane(name, speed, maintenance);
            Aircrafts.Add(aircraft);
            //!For testing only REMOVE
            foreach (Aircraft air in Aircrafts)
            {
                System.Console.WriteLine($"Name : {air.Name}, Type: {air.GetType()}");
            }
        }

        public void AddRescueHelicopter(string name, int speed, int maintenance)
        {
            aircraftFactory = AircraftFactory.GetAircraftFactory();
            Aircraft aircraft = AircraftFactory.CreateRescueHelicopter(name, speed , maintenance);
            Aircrafts.Add(aircraft);
            //!For testing only REMOVE
            foreach (Aircraft air in Aircrafts)
            {
                System.Console.WriteLine($"Name : {air.Name}, Type: {air.GetType()}");
            }
        }

        public void DeleteAircraft(int index)
        {
            try
            {
                Aircrafts.RemoveAt(index);
            }
            catch (System.ArgumentOutOfRangeException outOfRange)
            {
                System.Console.WriteLine("Error: " + index + "is out of range", outOfRange.Message);
            }
        }
    }
}
