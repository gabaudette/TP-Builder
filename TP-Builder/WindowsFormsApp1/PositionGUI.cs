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
       

            double x = (me.X * 360) / (pbMap.Width * 1.5) - 180;
            double y = (me.Y * 180) / (pbMap.Height * 1.5) - 90;

            double degX = Math.Floor(x);

            double tempX = x - degX;
            //double degY = Math.Floor(y);

            double min = Math.Abs(tempX * 60);
          

            Console.WriteLine($"'MIN: {min}, Deg X: {degX}");
            
        }

        private void PositionGUI_Load(object sender, EventArgs e)
        {

        }
    }
}
