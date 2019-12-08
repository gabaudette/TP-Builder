using System;
using System.Windows.Forms;

namespace TPBuilder
{
    public partial class PositionGUI : Form
    {
        private BuilderGUI BuilderGUI;

        public PositionGUI(BuilderGUI builderGUI)
        {
            InitializeComponent();
            BuilderGUI = builderGUI;
            pbMap.Image = Properties.Resources.map1;
        }

        private void PbMap_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            BuilderGUI.setPos(me.X, me.Y, pbMap.Width, pbMap.Height);
            this.Close();
        }

        private void PositionGUI_Load(object sender, EventArgs e)
        {

        }
    }
}
