using System;
using System.Windows.Forms;
using DeadHash.Forms;
using Syncfusion.Windows.Forms;

namespace DeadHash
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                MetroStyleColorTable metroColorTable = new MetroStyleColorTable
                {
                    BorderColor = Properties.Settings.Default.MetroColor,
                    NoButtonBackColor = Properties.Settings.Default.MetroColor,
                    YesButtonBackColor = Properties.Settings.Default.MetroColor,
                    OKButtonBackColor = Properties.Settings.Default.MetroColor
                };
                MessageBoxAdv.MetroColorTable = metroColorTable;
            }
            catch (Exception ex)
            {
                MessageBoxAdv.Show(ex.Message, "DeadHash", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
            Application.Run(new FrmMain(args));
        }
    }
}
