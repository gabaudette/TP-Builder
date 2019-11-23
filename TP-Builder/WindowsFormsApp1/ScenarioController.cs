using System;
using System.Windows.Forms;

namespace TPBuilder
{
    static class ScenarioController
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BuilderGUI());
        }
    }
}
