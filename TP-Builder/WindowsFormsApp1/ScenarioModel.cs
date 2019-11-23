using System.Collections.Generic;

namespace TPBuilder
{
    public sealed class ScenarioModel
    {
        private static ScenarioModel instance = null;
        private AircraftFactory aircraftFactory;

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
        // TODO : Aircraft Type ?
        public void AddAircraft()
        {
           aircraftFactory =  AircraftFactory.GetAircraftFactory();
           Aircraft aircraft = aircraftFactory.CreateAircraft();
           Aircrafts.Add(aircraft);
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

        public void CreateAircraft()
        {

        }

        public void UpdateAircraft()
        {
   
        }

        public void DeleteAircraft()
        {

        }
    }
}
