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

            double x = (double)(me.X * 180) / pbMap.Width - 90;
            double y = (double)(me.Y * 180) / (pbMap.Height) - 90;

            double degX = Math.Floor(x);
            double degY = Math.Floor(y);

            double tempX = x - degX;
            double tempY = y - degY;

            double minX = Math.Abs(tempX * 60);
            double minY = Math.Abs(tempY * 60);
          
            Console.WriteLine($"'minX: {minX}, minY:{minY} X: {x}, Y: {y}");
            
        }

        private void PositionGUI_Load(object sender, EventArgs e)
        {

        }
    }
}
