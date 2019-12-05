using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TPBuilder
{
    public delegate void AirportNotifier(string airport);
    public partial class BuilderGUI : Form
    {
        private Scenario scenario; // Scenario
        private PositionGUI positionGUI; // Positions pop-up form

        public BuilderGUI()
        {
            InitializeComponent();
            scenario = Scenario.Instance;

            //Airport's listview column setter
            lsvAirport.Columns.Add("Airport Name");
            lsvAirport.Columns.Add("Positions");
            lsvAirport.Columns.Add("Min. Passenger");
            lsvAirport.Columns.Add("Max. Passenger");
            lsvAirport.Columns.Add("Min. Marchandise");
            lsvAirport.Columns.Add("Max. Marchandise");
            lsvAirport.View = View.Details;

            //Resize the airport's listview columns
            for (int i = 0; i < lsvAirport.Columns.Count; i++)
                lsvAirport.Columns[i].Width = 100;

            //Aircraft's listview column setter
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

        /// <summary>
        /// Add airport button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddAirport_Click(object sender, EventArgs e)
        {
            if (ValidateAirportInput())
            {
                ScenarioController.CreateAirport(tbAirportName.Text, 1, 1, Convert.ToInt32(tbMinPassenger.Text), Convert.ToInt32(tbMaxPassenger.Text), Convert.ToInt32(tbMinMarchandise.Text), Convert.ToInt32(tbMaxMarchandise.Text));
                //lsvAirport.Items.Add(new ListViewItem(new string[] { tbAirportName.Text, tbPositions.Text, tbMinPassenger.Text, tbMaxPassenger.Text, tbMinMarchandise.Text, tbMaxMarchandise.Text }));
           
                //Console.WriteLine($"Airport: {tbAirportName.Text} at Position: ({tbPositions.Text}) added");
                ResetAirportControls();
            }
        }
        /// <summary>
        /// Add aircraft button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddAircraft_Click(object sender, EventArgs e)
        {
            Console.WriteLine($"TEST : {lsvAirport­.SelectedItems}");
            if (ValidateAircraftInput())
            {
                switch (cmbAircraftType.SelectedIndex)
                {
                    case 0:
                        ScenarioController.AddCargoPlane(lsvAirport.FocusedItem.Index, tbAircraftName.Text, Convert.ToInt32(tbSpeed.Text), Convert.ToInt32(tbMaintenance.Text), Convert.ToInt32(tbLoad.Text), Convert.ToInt32(tbUnload.Text), Convert.ToInt32(tbWeight.Text));
                        break;
                    case 1:
                        ScenarioController.AddPassengerPlane(lsvAirport.FocusedItem.Index, tbAircraftName.Text, Convert.ToInt32(tbSpeed.Text), Convert.ToInt32(tbMaintenance.Text), Convert.ToInt32(tbLoad.Text), Convert.ToInt32(tbUnload.Text), Convert.ToInt32(tbCapacity.Text));
                        break;
                    case 2:
                        ScenarioController.AddObserverPlane(lsvAirport.FocusedItem.Index, tbAircraftName.Text, Convert.ToInt32(tbSpeed.Text), Convert.ToInt32(tbMaintenance.Text));
                        break;
                    case 3:
                        ScenarioController.AddRescueHelicopter(lsvAirport.FocusedItem.Index, tbAircraftName.Text, Convert.ToInt32(tbSpeed.Text), Convert.ToInt32(tbMaintenance.Text));
                        break;
                    case 4:
                        ScenarioController.AddWaterBomber(lsvAirport.FocusedItem.Index, tbAircraftName.Text, Convert.ToInt32(tbSpeed.Text), Convert.ToInt32(tbMaintenance.Text), 0, 0);
                        break;
                }
                lsvAircraft.Items.Add(new ListViewItem(new string[] { tbAircraftName.Text, cmbAircraftType.SelectedItem.ToString() }));
                Console.WriteLine($"Aircraft: {tbAircraftName.Text} Type: ({cmbAircraftType.SelectedItem.ToString()}) added to Airport ID : {lsvAirport.FocusedItem.Index}");
                ResetAircraftControls();
            }
        }
        /// <summary>
        /// Front-end validation of all airport's inputs
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Front-end validation of all aircraft's inputs
        /// </summary>
        /// <returns></returns>
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

            if (tbSpeed.Text == "")
            {
                Console.WriteLine("Validation Error: Aircraft speed input value cannot be empty");
                return false;
            }

            if (!(Regex.IsMatch(tbSpeed.Text, @"\d")))
            {
                Console.WriteLine("Validation Error: Aircraft speed value must be numerical");
                return false;
            }

            if (tbMaintenance.Text == "")
            {
                Console.WriteLine("Validation Error: Aircraft maintenance time input value cannot be empty");
                return false;
            }

            if (!(Regex.IsMatch(tbMaintenance.Text, @"\d")))
            {
                Console.WriteLine("Validation Error: Aircraft maintenance time value must be numerical");
                return false;
            }

            return true;
        }
        /// <summary>
        /// Check the aircraft combobox selected item type
        /// </summary>
        private void CheckAircraftInputType()
        {
            switch (cmbAircraftType.SelectedIndex)
            {
                //@Aircraft type : Cargo Plane
                case 0:
                    tbCapacity.Enabled = false;
                    tbDropTime.Enabled = false;
                    tbLoad.Enabled = true;
                    tbUnload.Enabled = true;
                    tbWaterCapacity.Enabled = false;
                    tbWeight.Enabled = true;
                    break;
                //@Aircraft type : Passenger Plane
                case 1:
                    tbCapacity.Enabled = true;
                    tbDropTime.Enabled = false;
                    tbLoad.Enabled = true;
                    tbUnload.Enabled = true;
                    tbWaterCapacity.Enabled = false;
                    tbWeight.Enabled = false;
                    break;
                //@Aircraft type : Observer Plane
                case 2:
                    tbCapacity.Enabled = false;
                    tbDropTime.Enabled = false;
                    tbLoad.Enabled = false;
                    tbUnload.Enabled = false;
                    tbWaterCapacity.Enabled = false;
                    tbWeight.Enabled = false;
                    break;
                //@Aircraft type : Rescue Helicopter
                case 3:
                    tbCapacity.Enabled = false;
                    tbDropTime.Enabled = false;
                    tbLoad.Enabled = false;
                    tbUnload.Enabled = false;
                    tbWaterCapacity.Enabled = false;
                    tbWeight.Enabled = false;
                    break;
                //@Aircraft type : Water Bomber
                case 4:
                    tbCapacity.Enabled = false;
                    tbDropTime.Enabled = true;
                    tbLoad.Enabled = false;
                    tbUnload.Enabled = false;
                    tbWaterCapacity.Enabled = true;
                    tbWeight.Enabled = false;
                    break;
            }
            ResetAircraftControls();
        }
        /// <summary>
        /// Reset all the aircraft's inputs
        /// </summary>
        private void ResetAircraftControls()
        {
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
        /// <summary>
        /// Reset all the airport's inputs
        /// </summary>
        private void ResetAirportControls()
        {
            tbAirportName.Clear();
            tbPositions.Clear();
        }
        /// <summary>
        /// Button that open the map menu to select a position for the airport
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMap_Click(object sender, EventArgs e)
        {
            positionGUI = new PositionGUI();
            positionGUI.Show();
        }
        /// <summary>
        /// Event that check if the combobox aircraft selection changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmbAircraftType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CheckAircraftInputType();
        }
        /// <summary>
        /// Generate scenario button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            if (tbFilename.Text != "")
                ScenarioController.Serialize(tbFilename.Text);
        }
        /// <summary>
        /// Save scenario file button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML Files | *.xml";
            saveFileDialog.Title = "Save a XML File";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                FileStream fileStream = (FileStream)saveFileDialog.OpenFile();
                FileInfo fileInfo = new FileInfo(saveFileDialog.FileName);
                tbFilename.Text = fileInfo.Name;
                fileStream.Close();
                btnGenerate.Enabled = true;
            }
        }
        public void onAirportCreated(string airport)
        {
           
        }
    }
}