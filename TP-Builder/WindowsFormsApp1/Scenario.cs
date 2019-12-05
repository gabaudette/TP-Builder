using System.Collections.Generic;
using System.Xml.Serialization;

namespace TPBuilder
{

    [XmlRoot("Scenario")]
    public class Scenario
    {
        public List<Airport> Airports { get; set; }

        private static Scenario instance = null;

        private AircraftFactory aircraftFactory;

        public AirportNotifier airportNotifier { get; set; }

        private Scenario()
        {
            Airports = new List<Airport>();
        }

        public void SetView(BuilderGUI view)
        {
            airportNotifier = new AirportNotifier(view.onAirportCreated);
        }

        public static Scenario Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Scenario();
                }
                return instance;
            }
        }

        public void CreateAirport(string name, int x, int y, int minPassenger, int maxPassenger, int minMarchandise, int maxMarchandise)
        {
            Airport airport = new Airport(name, x, y, minPassenger, maxPassenger, minMarchandise, maxMarchandise);
            Airports.Add(airport);
            airportNotifier(airport.ToString());
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

        public void AddCargoPlane(int airportID, string name, int speed, int maintenance, int loadingTime, int unLoadingTime, int weight)
        {
            aircraftFactory = AircraftFactory.GetAircraftFactory();
            Aircraft aircraft = AircraftFactory.CreateCargoPlane(name, speed, maintenance, loadingTime, unLoadingTime, weight);
            Airports[airportID].AddAircraft(aircraft);
        }

        public void AddPassengerPlane(int airportID, string name, int speed, int maintenance, int loadingTime, int unLoadingTime, int capacity)
        {
            aircraftFactory = AircraftFactory.GetAircraftFactory();
            Aircraft aircraft = AircraftFactory.CreatePassengerPlane(name, speed, maintenance, loadingTime, unLoadingTime, capacity);
            Airports[airportID].AddAircraft(aircraft);
        }

        public void AddWaterBomber(int airportID, string name, int speed, int maintenance, int droppingTime, int waterCapacity)
        {
            aircraftFactory = AircraftFactory.GetAircraftFactory();
            Aircraft aircraft = AircraftFactory.CreateWaterBomber(name, speed, maintenance, droppingTime, waterCapacity);
            Airports[airportID].AddAircraft(aircraft);
        }

        public void AddObserverPlane(int airportID, string name, int speed, int maintenance)
        {
            aircraftFactory = AircraftFactory.GetAircraftFactory();
            Aircraft aircraft = AircraftFactory.CreateObserverPlane(name, speed, maintenance);
            Airports[airportID].AddAircraft(aircraft);
        }

        public void AddRescueHelicopter(int airportID, string name, int speed, int maintenance)
        {
            aircraftFactory = AircraftFactory.GetAircraftFactory();
            Aircraft aircraft = AircraftFactory.CreateRescueHelicopter(name, speed, maintenance);
            Airports[airportID].AddAircraft(aircraft);
        }
    }
}
