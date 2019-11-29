using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TPBuilder
{
    public partial class BuilderGUI : Form
    {
        private Scenario scenarioFacade;
        private PositionGUI positionGUI;

        public BuilderGUI()
        {
            InitializeComponent();
            scenarioFacade = Scenario.Instance;

            lsvAirport.Columns.Add("Airport Name");
            lsvAirport.Columns.Add("Positions");
            lsvAirport.Columns.Add("Min. Passenger");
            lsvAirport.Columns.Add("Max. Passenger");
            lsvAirport.Columns.Add("Min. Marchandise");
            lsvAirport.Columns.Add("Max. Marchandise");
            lsvAirport.View = View.Details;

            for (int i = 0; i < lsvAirport.Columns.Count; i++)
                lsvAirport.Columns[i].Width = 100;

            lsvAircraft.Columns.Add("Aircraft Name");
            lsvAircraft.Columns.Add("Aircraft Type");
            lsvAircraft.View = View.Details;

            cmbAircraftType.DropDownStyle = ComboBoxStyle.DropDownList;

            tbFilename.Enabled = false;
            btnGenerate.Enabled = false;
        }

        private void BuilderGUI_Load(object sender, EventArgs e)
        {
            string[] aircraftTypes = new string[] { "Cargo Plane", "Passenger Plane", "Observer Plane", "Rescue Helicopter", "Water Bomber" };
            cmbAircraftType.Items.AddRange(aircraftTypes);
            cmbAircraftType.SelectedIndex = 0;
            CheckAircraftInputType();
        }

        private void BtnAddAirport_Click(object sender, EventArgs e)
        {
            if (ValidateAirportInput())
            {
                scenarioFacade.CreateAiport(tbAirportName.Text, tbPositions.Text, Convert.ToInt32(tbMinPassenger.Text), Convert.ToInt32(tbMaxPassenger.Text), Convert.ToInt32(tbMinMarchandise.Text), Convert.ToInt32(tbMaxMarchandise.Text));
                lsvAirport.Items.Add(new ListViewItem(new string[] { tbAirportName.Text, tbPositions.Text, tbMinPassenger.Text, tbMaxPassenger.Text, tbMinMarchandise.Text, tbMaxMarchandise.Text }));
                Console.WriteLine($"Airport: {tbAirportName.Text} at Position: ({tbPositions.Text}) added");
                ResetAirportControls();
            }
        }

        private void BtnAddAircraft_Click(object sender, EventArgs e)
        {
            Console.WriteLine($"TEST : {lsvAirport­.SelectedItems}");
            if (ValidateAircraftInput())
            {
                switch (cmbAircraftType.SelectedIndex)
                {
                    case 0:
                        scenarioFacade.AddCargoPlane(lsvAirport.FocusedItem.Index,tbAircraftName.Text, Convert.ToInt32(tbSpeed.Text), Convert.ToInt32(tbMaintenance.Text), Convert.ToInt32(tbLoad.Text), Convert.ToInt32(tbUnload.Text), Convert.ToInt32(tbWeight.Text));
                        break;
                    case 1:
                        scenarioFacade.AddPassengerPlane(lsvAirport.FocusedItem.Index,tbAircraftName.Text, Convert.ToInt32(tbSpeed.Text), Convert.ToInt32(tbMaintenance.Text), Convert.ToInt32(tbLoad.Text), Convert.ToInt32(tbUnload.Text), Convert.ToInt32(tbCapacity.Text));
                        break;
                    case 2:
                        scenarioFacade.AddObserverPlane(lsvAirport.FocusedItem.Index,tbAircraftName.Text, Convert.ToInt32(tbSpeed.Text), Convert.ToInt32(tbMaintenance.Text));
                        break;
                    case 3:
                        scenarioFacade.AddRescueHelicopter(lsvAirport.FocusedItem.Index,tbAircraftName.Text, Convert.ToInt32(tbSpeed.Text), Convert.ToInt32(tbMaintenance.Text));
                        break;
                    case 4:
                        scenarioFacade.AddWaterBomber(lsvAirport.FocusedItem.Index,tbAircraftName.Text, Convert.ToInt32(tbSpeed.Text), Convert.ToInt32(tbMaintenance.Text), 0, 0);
                        break;
                }
                lsvAircraft.Items.Add(new ListViewItem(new string[] { tbAircraftName.Text, cmbAircraftType.SelectedItem.ToString() }));
                Console.WriteLine($"Aircraft: {tbAircraftName.Text} Type: ({cmbAircraftType.SelectedItem.ToString()}) added to Airport ID : {lsvAirport.FocusedItem.Index}");
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
                tbWeight.Enabled = true;
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
                tbWeight.Enabled = false;
                tbLoad.Enabled = true;
                tbUnload.Enabled = true;
            }

            //@Aircraft Type: WaterBomber
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
                tbWeight.Enabled = false;
                tbDropTime.Enabled = false;
                tbWaterCapacity.Enabled = false;
            }
        }

        private void ResetAircraftControls()
        {
            cmbAircraftType.SelectedIndex = 0;
            tbAircraftName.Clear();
            tbMaintenance.Clear();
            tbSpeed.Clear();
            tbLoad.Clear();
            tbUnload.Clear();
            tbCapacity.Clear();
            tbWaterCapacity.Clear();
            tbWeight.Clear();
            tbDropTime.Clear();
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
            if (tbFilename.Text != "")
                ScenarioController.Serialize(tbFilename.Text);
        }

        private void BtnSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML Files | *.xml";
            saveFileDialog.Title = "Save a XML File";
            saveFileDialog.ShowDialog();

            if(saveFileDialog.FileName != "")
            {
                FileStream fileStream = (FileStream)saveFileDialog.OpenFile();
                FileInfo fileInfo = new FileInfo(saveFileDialog.FileName);
                tbFilename.Text = fileInfo.Name;
                fileStream.Close();
                btnGenerate.Enabled = true;
            }
        }
    }
}