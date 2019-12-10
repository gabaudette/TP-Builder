using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TPBuilder
{
    static class ScenarioController
    {
        static BuilderGUI GUI; //The builder's view (GUI)
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GUI = new BuilderGUI();
            Scenario scenario = Scenario.Instance;
            scenario.SetView(GUI);
            Application.Run(GUI);
        }

        /// <summary>
        /// Resquest the scenario to create an airport
        /// </summary>
        /// <param name="name"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="minPassenger"></param>
        /// <param name="maxPassenger"></param>
        /// <param name="minMarchandise"></param>
        /// <param name="maxMarchandise"></param>
        public static void CreateAirport(string name, int x, int y, int minPassenger, int maxPassenger, int minMarchandise, int maxMarchandise, string dms)
        {
            Scenario scenario = Scenario.Instance;
            if (scenario.ValidAirport(name))
                scenario.CreateAirport(name, x, y, minPassenger, maxPassenger, minMarchandise, maxMarchandise, dms);
            else
                Console.WriteLine($"Error : Airport : {name} already exist!");
        }
        /// <summary>
        /// Resquest the aircraft factory to create a cargo plane
        /// </summary>
        /// <param name="airportID"></param>
        /// <param name="name"></param>
        /// <param name="speed"></param>
        /// <param name="maintenance"></param>
        /// <param name="loadingTime"></param>
        /// <param name="unLoadingTime"></param>
        /// <param name="weight"></param>
        public static void AddCargoPlane(int airportID, string name, int speed, int maintenance, int loadingTime, int unLoadingTime, int weight)
        {
            Scenario scenario = Scenario.Instance;
            scenario.AddCargoPlane(airportID, name, speed, maintenance, loadingTime, unLoadingTime, weight);
        }
        /// <summary>
        /// Resquest the aircraft factory to create a passenger plane
        /// </summary>
        /// <param name="airportID"></param>
        /// <param name="name"></param>
        /// <param name="speed"></param>
        /// <param name="maintenance"></param>
        /// <param name="loadingTime"></param>
        /// <param name="unLoadingTime"></param>
        /// <param name="capacity"></param>
        public static void AddPassengerPlane(int airportID, string name, int speed, int maintenance, int loadingTime, int unLoadingTime, int capacity)
        {
            Scenario scenario = Scenario.Instance;
            scenario.AddPassengerPlane(airportID, name, speed, maintenance, loadingTime, unLoadingTime, capacity);
        }
        /// <summary>
        /// Resquest the aircraft factory to create a water bomber
        /// </summary>
        /// <param name="airportID"></param>
        /// <param name="name"></param>
        /// <param name="speed"></param>
        /// <param name="maintenance"></param>
        /// <param name="droppingTime"></param>
        /// <param name="waterCapacity"></param>
        public static void AddWaterBomber(int airportID, string name, int speed, int maintenance, int droppingTime, int waterCapacity)
        {
            Scenario scenario = Scenario.Instance;
            scenario.AddWaterBomber(airportID, name, speed, maintenance, droppingTime, waterCapacity);
        }
        /// <summary>
        /// Resquest the aircraft factory to create an observer plane
        /// </summary>
        /// <param name="airportID"></param>
        /// <param name="name"></param>
        /// <param name="speed"></param>
        /// <param name="maintenance"></param>
        public static void AddObserverPlane(int airportID, string name, int speed, int maintenance)
        {
            Scenario scenario = Scenario.Instance;
            scenario.AddObserverPlane(airportID, name, speed, maintenance);
        }
        /// <summary>
        /// Resquest the aircraft factory to create a rescue helicopter
        /// </summary>
        /// <param name="airportID"></param>
        /// <param name="name"></param>
        /// <param name="speed"></param>
        /// <param name="maintenance"></param>
        public static void AddRescueHelicopter(int airportID, string name, int speed, int maintenance)
        {
            Scenario scenario = Scenario.Instance;
            scenario.AddRescueHelicopter(airportID, name, speed, maintenance);
        }
        /// <summary>
        /// Request the scenario to serialize itself
        /// </summary>
        /// <param name="filename"></param>
        public static void Serialize(string filename)
        {
            XmlSerializer xs = new XmlSerializer(typeof(Scenario));
            using (StreamWriter wr = new StreamWriter(filename)) {
                xs.Serialize(wr, Scenario.Instance);
                wr.Flush();
            }

        }
        public static void SelectAircraftsAirport(int airportID)
        {
            Scenario scenario = Scenario.Instance;
            scenario.SelectAircraftsAirport(airportID);
        }
    }

}
