using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aika
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new InO());
        }

        public static DataTable TimeLogger = new DataTable();
        public static List<KeyValuePair<DateTime, DateTime>> TimeLog = new List<KeyValuePair<DateTime, DateTime>>();
    }
}
