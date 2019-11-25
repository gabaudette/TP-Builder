using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TPBuilder
{
    public partial class BuilderGUI : Form
    {
        ScenarioFacade scenarioFacade;
        public BuilderGUI()
        {
            InitializeComponent();
            scenarioFacade = ScenarioFacade.Instance;
        }

        private void BuilderGUI_Load(object sender, EventArgs e)
        {

        }

        private void BtnAddAirport_Click(object sender, EventArgs e)
        {
            if (ValidateAirportInput())
            {
                scenarioFacade.CreateAiport(tbAirportName.Text, Convert.ToInt32(tbAirportPositionX.Text), Convert.ToInt32(tbAirportPositionY.Text));
                Console.WriteLine($"Airport: {tbAirportName.Text} at Position: (X: {tbAirportPositionX.Text}, Y: {tbAirportPositionY.Text}) added");
                ResetAirportControls();
            }
        }

        private bool ValidateAirportInput()
        {
            // Airport Name
            if (tbAirportName.Text == "")
            {
                Console.WriteLine("Validation Error: Airport name input cannot be empty");
                return false;
            }

            if (tbAirportName.Text.Length < 3 || tbAirportName.Text.Length > 50)
            {
                Console.WriteLine("Validation Error: Airport name must be between 5 and 50");
                return false;
            }

            if (Regex.IsMatch(tbAirportName.Text, @"\d"))
            {
                Console.WriteLine("Validation Error: Airport name cannot contain numeric value");
                return false;
            }

            //Airport X and Y
            if (tbAirportPositionX.Text == "" || tbAirportPositionY.Text == "")
            {
                Console.WriteLine("Validation Error: Airport position(s) (X or Y) input(s) cannot be empty");
                return false;
            }
            if (tbAirportPositionX.Text.Length > 4 || tbAirportPositionY.Text.Length > 4)
            {
                Console.WriteLine("Validation Error: Airport position(s) (X or Y) input(s) must be between 1 and 4 in length");
                return false;
            }
            if (!Regex.IsMatch(tbAirportPositionX.Text, @"\d") || !Regex.IsMatch(tbAirportPositionY.Text, @"\d"))
            {
                Console.WriteLine("Validation Error: Airport position(s) (X or Y) input(s) must be numerical");
                return false;
            }
            if(Convert.ToInt32(tbAirportPositionX.Text) < 0 || Convert.ToInt32(tbAirportPositionY.Text) < 0)
            {
                Console.WriteLine("Validation Error: Airport position(s) (X or Y) input(s) must be positive number");
                return false;
            }
            return true;
        }
        
        private void ResetAirportControls()
        {
            tbAirportName.Clear();
            tbAirportPositionX.Clear();
            tbAirportPositionY.Clear();
        }

        private bool ValidateAircraftInput()
        {
            return true;
        }
    }
}
