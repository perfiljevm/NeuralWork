using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SAI_NeuralNetworks
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа.
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2());
        }
    }
}
