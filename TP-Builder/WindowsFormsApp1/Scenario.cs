using System.Collections.Generic;
using System.Xml.Serialization;

namespace TPBuilder
{

    [XmlRoot("Scenario")]
    public class Scenario
    {
        public List<Airport> Airports { get; set; } // List of all the airport(s) currently in the scenario
        private static Scenario instance = null; //Scenario's intance
        private AircraftFactory aircraftFactory; //Aircraft's factory
        [XmlIgnore]
        public AirportNotifier airportNotifier { get; set; } // Airport delegate
        [XmlIgnore]
        public AircraftNotifier aircraftNotifier { get; set; } //Aircraft delegate

        private Scenario()
        {
            Airports = new List<Airport>();
        }
        /// <summary>
        /// Get scenario instance
        /// </summary>
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
        /// Set scenario GUI instance
        /// </summary>
        /// <param name="view"></param>
        ///   /// <summary>
        /// Get scenario instance
        /// </summary>
        public void SetView(BuilderGUI view)
        {
            airportNotifier = new AirportNotifier(view.OnAirportCreated);
            aircraftNotifier = new AircraftNotifier(view.OnAircraftCreated);
        }

        /// <summary>
        /// Create an airport
        /// </summary>
        /// <param name="name"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="minPassenger"></param>
        /// <param name="maxPassenger"></param>
        /// <param name="minMarchandise"></param>
        /// <param name="maxMarchandise"></param>
        public void CreateAirport(string name, int x, int y, int minPassenger, int maxPassenger, int minMarchandise, int maxMarchandise)
        {
            Airport airport = new Airport(name, x, y, minPassenger, maxPassenger, minMarchandise, maxMarchandise);
            Airports.Add(airport);
            airportNotifier(airport.ToString());

        }
        /// <summary>
        /// Delete an airport and all aircraft that it contains
        /// </summary>
        /// <param name="index"></param>
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
        /// <summary>
        /// Validate if the airport name is not equal to another airport of the current scenario
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Ask the aircraft factory to create a cargo plane
        /// </summary>
        /// <param name="airportID"></param>
        /// <param name="name"></param>
        /// <param name="speed"></param>
        /// <param name="maintenance"></param>
        /// <param name="loadingTime"></param>
        /// <param name="unLoadingTime"></param>
        /// <param name="weight"></param>
        public void AddCargoPlane(int airportID, string name, int speed, int maintenance, int loadingTime, int unLoadingTime, int weight)
        {
            aircraftFactory = AircraftFactory.GetAircraftFactory();
            Aircraft aircraft = AircraftFactory.CreateCargoPlane(name, speed, maintenance, loadingTime, unLoadingTime, weight);
            aircraftNotifier(aircraft.ToString());
            Airports[airportID].AddAircraft(aircraft);
        }
        /// <summary>
        /// Ask the aircraft factory to create a passenger plane
        /// </summary>
        /// <param name="airportID"></param>
        /// <param name="name"></param>
        /// <param name="speed"></param>
        /// <param name="maintenance"></param>
        /// <param name="loadingTime"></param>
        /// <param name="unLoadingTime"></param>
        /// <param name="capacity"></param>
        public void AddPassengerPlane(int airportID, string name, int speed, int maintenance, int loadingTime, int unLoadingTime, int capacity)
        {
            aircraftFactory = AircraftFactory.GetAircraftFactory();
            Aircraft aircraft = AircraftFactory.CreatePassengerPlane(name, speed, maintenance, loadingTime, unLoadingTime, capacity);
            aircraftNotifier(aircraft.ToString());
            Airports[airportID].AddAircraft(aircraft);
        }
        /// <summary>
        /// Ask the aircraft factory to create a water bomber
        /// </summary>
        /// <param name="airportID"></param>
        /// <param name="name"></param>
        /// <param name="speed"></param>
        /// <param name="maintenance"></param>
        /// <param name="droppingTime"></param>
        /// <param name="waterCapacity"></param>
        public void AddWaterBomber(int airportID, string name, int speed, int maintenance, int droppingTime, int waterCapacity)
        {
            aircraftFactory = AircraftFactory.GetAircraftFactory();
            Aircraft aircraft = AircraftFactory.CreateWaterBomber(name, speed, maintenance, droppingTime, waterCapacity);
            aircraftNotifier(aircraft.ToString());
            Airports[airportID].AddAircraft(aircraft);
        }
        /// <summary>
        /// Ask the aircraft factory to create a observer plane
        /// </summary>
        /// <param name="airportID"></param>
        /// <param name="name"></param>
        /// <param name="speed"></param>
        /// <param name="maintenance"></param>
        public void AddObserverPlane(int airportID, string name, int speed, int maintenance)
        {
            aircraftFactory = AircraftFactory.GetAircraftFactory();
            Aircraft aircraft = AircraftFactory.CreateObserverPlane(name, speed, maintenance);
            aircraftNotifier(aircraft.ToString());
            Airports[airportID].AddAircraft(aircraft);
        }
        /// <summary>
        /// Ask the aircraft factory to create a rescue helicopter
        /// </summary>
        /// <param name="airportID"></param>
        /// <param name="name"></param>
        /// <param name="speed"></param>
        /// <param name="maintenance"></param>
        public void AddRescueHelicopter(int airportID, string name, int speed, int maintenance)
        {
            aircraftFactory = AircraftFactory.GetAircraftFactory();
            Aircraft aircraft = AircraftFactory.CreateRescueHelicopter(name, speed, maintenance);
            aircraftNotifier(aircraft.ToString());
            Airports[airportID].AddAircraft(aircraft);
        }
    }
}
