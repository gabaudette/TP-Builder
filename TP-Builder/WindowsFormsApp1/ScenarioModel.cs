using System.Collections.Generic;

namespace TPBuilder
{
    public sealed class ScenarioModel
    {
        private static ScenarioModel instance = null;
        private AircraftFactory aircraftFactory;
        private Airport airport;

        public List<Aircraft> Aircrafts { get; private set; }
        public List<Airport> Airports { get; private set; }
       

        private ScenarioModel(){}

        public static ScenarioModel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ScenarioModel();
                }
                return instance;
            }
        }
    
        public void CreateAiport(string name)
        {
            if (ValidAirport(name))
            {
                Airports.Add(new Airport(name));
            }
        }
      
        public void UpdateAirport(int index)
        {
           
        }

        public void DeleteAirport(int index)
        {
            try
            {
                Airports.RemoveAt(index);
            }
            catch (System.ArgumentOutOfRangeException outOfRange)
            {
                System.Console.WriteLine("Error: " + index + "is out of range", outOfRange.Message);      
            }
        }

        public bool ValidAirport(string name)
        {
            foreach (Airport airport in Airports)
                if (airport.Name == name)
                    return false;
            return true;
        }

        // TODO : Aircraft Type ?
        public void AddAircraft()
        {
            aircraftFactory = AircraftFactory.GetAircraftFactory();
            Aircraft aircraft = aircraftFactory.CreateAircraft();
            Aircrafts.Add(aircraft);
        }

        public void UpdateAircraft()
        {
   
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
