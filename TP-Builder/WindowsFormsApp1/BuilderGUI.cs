using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPBuilder
{
    public partial class BuilderGUI : Form
    {
        ScenarioModel scenarioModel;
        public BuilderGUI()
        {
            InitializeComponent();
            scenarioModel = ScenarioModel.Instance;
        }

        private void BuilderGUI_Load(object sender, EventArgs e)
        {

        }
    }
}
