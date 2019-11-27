using System;
using System.Drawing;
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
            MouseEventArgs me = (MouseEventArgs) e;
            Point point = me.Location;
            Console.WriteLine($"X: {point.X}, Y: {point.Y}");
            
        }

        private void PositionGUI_Load(object sender, EventArgs e)
        {

        }
    }
}
