using System;
using System.Windows.Forms;

namespace TPBuilder
{
    public partial class PositionGUI : Form
    {
        public MouseEventArgs Me { get; private set; }
        public PositionGUI()
        {
            InitializeComponent();
            pbMap.Image = Properties.Resources.map1;
        }

        private void PositionGUI_Load(object sender, EventArgs e) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbMap_Click(object sender, EventArgs e)
        {
             Me = (MouseEventArgs)e;
            double X = (double)(Me.X * 180) / pbMap.Width - 90;
            double Y = (double)(Me.X * 180) / pbMap.Height - 90;

            GeoPosition.ConvertToDMS(X, Y);
        }
    }
}
