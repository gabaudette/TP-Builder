using System;
using System.Windows.Forms;

namespace TPBuilder
{
    //TODO : Faire un delegate qui check quand le form se ferme y faut avoir le x pis le y 
    // pour l'autre form
    //public delegate void onPositionSet(int x, int y);
    public partial class PositionGUI : Form
    {
        public MouseEventArgs Me { get; private set; }
        public double X { get; private set; }
        public double Y { get; private set; }

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
            X = (double)(Me.X * 180) / pbMap.Width - 90;
            Y = (double)(Me.X * 180) / pbMap.Height - 90;
            GeoPosition.ConvertToDMS(X, Y);
            this.Close();
        }
    }
}
