using System;
using System.Windows.Forms;

namespace Lab04
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new fMain());
        }
    }
}