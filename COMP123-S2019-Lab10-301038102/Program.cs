using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lab10_301038102
{
    static class Program
    {
        public static StartForm startForm;
        public static EndForm endForm;
        public static MainForm mainForm;

        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            startForm = new StartForm();
            endForm = new EndForm();
            mainForm = new MainForm();

            Application.Run(new StartForm());
        }
    }
}
