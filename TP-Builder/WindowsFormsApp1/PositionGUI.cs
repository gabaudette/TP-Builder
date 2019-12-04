using System;
using System.Windows.Forms;

namespace TPBuilder
{
    public partial class PositionGUI : Form
    {
        public PositionGUI()
        {
            InitializeComponent();
            pbMap.Image = Properties.Resources.map1;
        }

        private void PbMap_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            GeoPosition.ConvertToDMS(me.X, me.Y, pbMap.Width, pbMap.Height);
        }

        private void PositionGUI_Load(object sender, EventArgs e)
        {

        }
    }
}
