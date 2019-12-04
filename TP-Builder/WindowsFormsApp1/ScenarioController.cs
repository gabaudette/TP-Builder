using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TPBuilder
{
    static class ScenarioController
    {
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BuilderGUI());
        }

        public static void CreateAirport(string name, int x, int y, int minPassenger, int maxPassenger, int minMarchandise, int maxMarchandise)
        {
            Scenario scenario = Scenario.Instance;
            if (scenario.ValidAirport(name))
                scenario.CreateAirport(name, x, y, minPassenger, maxPassenger, minMarchandise, maxMarchandise);
            else
                Console.WriteLine($"Error : Airport : {name} already exist!");
        }

        public static void AddCargoPlane(int airportID, string name, int speed, int maintenance, int loadingTime, int unLoadingTime, int weight)
        {
            Scenario scenario = Scenario.Instance;
            scenario.AddCargoPlane(airportID, name, speed, maintenance, loadingTime, unLoadingTime, weight);
        }

        public static void AddPassengerPlane(int airportID, string name, int speed, int maintenance, int loadingTime, int unLoadingTime, int capacity)
        {
            Scenario scenario = Scenario.Instance;
            scenario.AddPassengerPlane(airportID, name, speed, maintenance, loadingTime, unLoadingTime, capacity);
        }

        public static void AddWaterBomber(int airportID, string name, int speed, int maintenance, int droppingTime, int waterCapacity)
        {
            Scenario scenario = Scenario.Instance;
            scenario.AddWaterBomber(airportID, name, speed, maintenance, droppingTime, waterCapacity);
        }

        public static void AddObserverPlane(int airportID, string name, int speed, int maintenance)
        {
            Scenario scenario = Scenario.Instance;
            scenario.AddObserverPlane(airportID, name, speed, maintenance);
        }

        public static void AddRescueHelicopter(int airportID, string name, int speed, int maintenance)
        {
            Scenario scenario = Scenario.Instance;
            scenario.AddRescueHelicopter(airportID, name, speed, maintenance);
        }

        public static void Serialize(string filename)
        {
            XmlSerializer xs = new XmlSerializer(typeof(Scenario));
            using (StreamWriter wr = new StreamWriter(filename)) {
                xs.Serialize(wr, Scenario.Instance);
                wr.Flush();
            }

        }
    }

}
