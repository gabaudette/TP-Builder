using System;
using System.Drawing;
using System.Windows.Forms;

namespace TPBuilder
{
    public partial class PositionGUI : Form
    {
        private MouseEventArgs me; // Mouse event args of the map
        private int y; // Y position of the map
        private int x; // X position of the map
        private string dms; // Degree-minute-second notation of X and Y postions

        public string DMS
        {
            get { return this.dms; }
            set { this.dms = value; }
        }

        public MouseEventArgs Me
        {
            get { return this.me; }
            set { this.me = value; }
        }

        public int Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public int X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public PositionGUI()
        {
            InitializeComponent();
        }
        private void PositionGUI_Load(object sender, EventArgs e) { }

        /// <summary>
        /// Event that fired when you click on the map, 
        /// it called the DMS conversion and close the current form (map)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbMap_Click(object sender, EventArgs e)
        {
            Me = (MouseEventArgs)e;
            X = Me.X;
            Y = Me.Y;
            DMS = GeoPosition.ConvertToDMS(X, Y, pbMap.Width, pbMap.Height);
            this.Close();
        }

        /// <summary>
        /// Render the map image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbMap_Paint(object sender, PaintEventArgs e)
        {
            Bitmap map = new Bitmap(Properties.Resources.map1);
            e.Graphics.DrawImage(map, 0, 0, 1026, 592);
        }
    }
}
