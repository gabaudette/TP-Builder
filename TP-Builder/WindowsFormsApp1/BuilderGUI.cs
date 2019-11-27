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

            cmbAircraftType.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void BuilderGUI_Load(object sender, EventArgs e)
        {
            string[] aircraftTypes = new string[] { "Cargo Plane", "Passenger Plane", "Observer Plane","Rescue Helicopter", "Water Bomber" };
            cmbAircraftType.Items.AddRange(aircraftTypes);
            cmbAircraftType.SelectedIndex = 0;
            CheckAircraftInputType();
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
                switch (cmbAircraftType.SelectedIndex)
                {
                    case 0:
                        scenarioFacade.AddCargoPlane(tbAircraftName.Text, Convert.ToInt32(tbSpeed.Text), Convert.ToInt32(tbMaintenance.Text), Convert.ToInt32(tbLoad.Text), Convert.ToInt32(tbUnload.Text), Convert.ToInt32(tbWeigth.Text));
                        break;
                    case 1:
                        scenarioFacade.AddPassengerPlane(tbAircraftName.Text, Convert.ToInt32(tbSpeed.Text), Convert.ToInt32(tbMaintenance.Text), Convert.ToInt32(tbLoad.Text), Convert.ToInt32(tbUnload.Text), Convert.ToInt32(tbCapacity.Text));
                        break;
                    case 2:
                        scenarioFacade.AddObserverPlane(tbAircraftName.Text, Convert.ToInt32(tbSpeed.Text), Convert.ToInt32(tbMaintenance.Text));
                        break;
                    case 3:
                        scenarioFacade.AddRescueHelicopter(tbAircraftName.Text, Convert.ToInt32(tbSpeed.Text), Convert.ToInt32(tbMaintenance.Text));
                        break;
                    case 4:
                        scenarioFacade.AddWaterBomber(tbAircraftName.Text, Convert.ToInt32(tbSpeed.Text), Convert.ToInt32(tbMaintenance.Text), 0, 0);
                        break;
                }
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

        private void CheckAircraftInputType()
        {
            //@Aircraft Type: Cargo Plane
            if (cmbAircraftType.SelectedIndex == 0)
            {
                tbWeigth.Enabled = true;
                tbCapacity.Enabled = false;
                tbDropTime.Enabled = false;
                tbWaterCapacity.Enabled = false;
                tbLoad.Enabled = true;
                tbUnload.Enabled = true;
            }

            //@Aircraft Type: Passenger Plane
            else if(cmbAircraftType.SelectedIndex == 1)
            {
                tbCapacity.Enabled = true;
                tbWeigth.Enabled = false;
                tbLoad.Enabled = true;
                tbUnload.Enabled = true;
            }

            else if(cmbAircraftType.SelectedIndex == 4)
            {
                tbDropTime.Enabled = true;
                tbWaterCapacity.Enabled = true;
            }

            else
            {
                tbLoad.Clear();
                tbUnload.Clear();
                tbWaterCapacity.Clear();
                tbDropTime.Clear();
                tbLoad.Enabled = false;
                tbUnload.Enabled = false;
                tbCapacity.Enabled = false;
                tbWeigth.Enabled = false;
                tbDropTime.Enabled = false;
                tbWaterCapacity.Enabled = false;
            }
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

        private void CmbAircraftType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CheckAircraftInputType();
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            ScenarioController.Serialize();
        }
    }
}
