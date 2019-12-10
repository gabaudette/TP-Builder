using System;
using System.Drawing;
using System.Windows.Forms;

namespace TPBuilder
{
    //TODO : Faire un delegate qui check quand le form se ferme y faut avoir le x pis le y 
    // pour l'autre form
    public partial class PositionGUI : Form
    {
        private MouseEventArgs me;
        private int y;
        private int x;
        private string dms;

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
        /// 
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

        private void PbMap_Paint(object sender, PaintEventArgs e)
        {
            Bitmap map = new Bitmap(Properties.Resources.map1);
            e.Graphics.DrawImage(map, 0, 0, 1026, 592);

        }
    }
}
