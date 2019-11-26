using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TPBuilder
{
    public partial class BuilderGUI : Form
    {
        private ScenarioFacade scenarioFacade;
        private PositionGUI positionGUI;

        public BuilderGUI()
        {
            InitializeComponent();
            scenarioFacade = ScenarioFacade.Instance;

            lsvAirport.Columns.Add("Airport Name");
            lsvAirport.Columns.Add("Positions");
            lsvAirport.View = View.Details;

            lsvAircraft.Columns.Add("Aircraft Name");
            lsvAircraft.Columns.Add("Aircraft Type");
            lsvAircraft.View = View.Details;

        }

        private void BuilderGUI_Load(object sender, EventArgs e)
        {
            string[] aircraftTypes = new string[] { "Cargo Plane", "Observer Plane", "Passenger Plane", "Rescue Helicopter", "Water Bomber" };
            cmbAircraftType.Items.AddRange(aircraftTypes);
            cmbAircraftType.SelectedIndex = 0;
        }

        private void BtnAddAirport_Click(object sender, EventArgs e)
        {
            if (ValidateAirportInput())
            {
                scenarioFacade.CreateAiport(tbAirportName.Text, 1 ,1);
                lsvAirport.Items.Add(new ListViewItem(new string[] { tbAirportName.Text, tbPositions.Text}));
                Console.WriteLine($"Airport: {tbAirportName.Text} at Position: ({tbPositions.Text}) added");
                ResetAirportControls();
            }
        }

        private void BtnAddAircraft_Click(object sender, EventArgs e)
        {
            if (ValidateAircraftInput())
            { 
                scenarioFacade.AddAircraft(tbAircraftName.Text, cmbAircraftType.SelectedItem.ToString());
                lsvAircraft.Items.Add(new ListViewItem(new string[] { tbAircraftName.Text, cmbAircraftType.SelectedItem.ToString() }));
                Console.WriteLine($"Aircraft: {tbAircraftName.Text} Type: ({cmbAircraftType.SelectedItem.ToString()}) added");
                ResetAircraftControls();
            }
        }

        private bool ValidateAirportInput()
        {
         
            if (tbAirportName.Text == "")
            {
                Console.WriteLine("Validation Error: Airport name input value cannot be empty");
                return false;
            }

            if (tbAirportName.Text.Length < 3 || tbAirportName.Text.Length > 50)
            {
                Console.WriteLine("Validation Error: Airport name must be between 3 and 50 in length");
                return false;
            }

            if (Regex.IsMatch(tbAirportName.Text, @"\d"))
            {
                Console.WriteLine("Validation Error: Airport name cannot contain numeric value");
                return false;
            }

            if (tbPositions.Text == "")
            {
                Console.WriteLine("Validation Error: Airport position(s) (X or Y) input(s) cannot be empty");
                return false;
            }
            
            return true;
        }

        private bool ValidateAircraftInput()
        {
            if (tbAircraftName.Text == "")
            {
                Console.WriteLine("Validation Error: Aircraft name input value cannot be empty");
                return false;
            }

            if (tbAircraftName.Text.Length < 3 || tbAircraftName.Text.Length > 50)
            {
                Console.WriteLine("Validation Error: Aircraft name must be between 3 and 50 in length");
                return false;
            }

            if (Regex.IsMatch(tbAircraftName.Text, @"\d"))
            {
                Console.WriteLine("Validation Error: Aircraft name cannot contain numeric value");
                return false;
            }

            if(tbSpeed.Text == "")
            {
                Console.WriteLine("Validation Error: Aircraft speed input value cannot be empty");
                return false;
            }

            if (!(Regex.IsMatch(tbSpeed.Text, @"\d")))
            {
                Console.WriteLine("Validation Error: Aircraft speed value must be numerical");
                return false;
            }

            if(tbMaintenance.Text == "")
            {
                Console.WriteLine("Validation Error: Aircraft maintenance time input value cannot be empty");
                return false;
            }

            if(!(Regex.IsMatch(tbMaintenance.Text, @"\d")))
            {
                Console.WriteLine("Validation Error: Aircraft maintenance time value must be numerical");
                return false;
            }

            return true;
        }

        private void ResetAircraftControls()
        {
            tbAircraftName.Clear();
            cmbAircraftType.SelectedIndex = 0;
        }

        private void ResetAirportControls()
        {
            tbAirportName.Clear();
            tbPositions.Clear();
        }

        private void BtnMap_Click(object sender, EventArgs e)
        {
            positionGUI = new PositionGUI();
            positionGUI.Show();
        }
    }
}
