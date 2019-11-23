using System.Collections.Generic;

namespace TPBuilder
{
    public sealed class ScenarioModel
    {
        private static ScenarioModel instance = null;
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

        public void CreateAirport()
        {

        }

        public void UpdateAirport()
        {

        }

        public void DeleteAirport()
        {

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
