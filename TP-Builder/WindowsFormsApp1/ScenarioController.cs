using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

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

        static public void Serialize(string filename)
        {
            XmlSerializer xs = new XmlSerializer(typeof(ScenarioFacade));
            using (StreamWriter wr = new StreamWriter(filename))
                xs.Serialize(wr, ScenarioFacade.Instance);
        }
    }
}
