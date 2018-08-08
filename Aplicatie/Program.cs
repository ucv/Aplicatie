using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatie
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

            Forms.Client FormClient = new Forms.Client();
            FormClient.data.setDataFromValues(1, "Ungureanu", "Andrei");
            FormClient.InitializeComponent();
            FormClient.Show();

            Application.Run(new Forms.Main());
        }
    }
}
