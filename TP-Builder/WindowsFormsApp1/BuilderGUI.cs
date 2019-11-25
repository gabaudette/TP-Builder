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
        }

        private void BuilderGUI_Load(object sender, EventArgs e)
        {

        }

        private void BtnAddAirport_Click(object sender, EventArgs e)
        {
            if (ValidateAirportInput())
            {
                scenarioFacade.CreateAiport(tbAirportName.Text, 1 ,1);
                lsvAirport.Columns.Add("Airport name");
                lsvAirport.Columns.Add("Positions");
                lsvAirport.View = View.Details;
                
                    lsvAirport.Items.Add(new ListViewItem(new string[] { tbAirportName.Text, tbPositions.Text}));
                    Console.WriteLine($"Airport: {tbAirportName.Text} at Position: ({tbPositions.Text}) added");
                
                
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
            if (tbPositions.Text == "")
            {
                Console.WriteLine("Validation Error: Airport position(s) (X or Y) input(s) cannot be empty");
                return false;
            }
            
            return true;
        }
        
        private void ResetAirportControls()
        {
            tbAirportName.Clear();
            tbPositions.Clear();
        }

        private bool ValidateAircraftInput()
        {
            return true;
        }

        private void BtnMap_Click(object sender, EventArgs e)
        {
            positionGUI = new PositionGUI();
            positionGUI.Show();
        }
    }
}
