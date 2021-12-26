using System;
using System.Threading;
using System.Linq;
using System.Windows.Forms;

namespace BatteryReminder
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static int Main(string[] Arguments)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (Arguments.Contains("-debug"))
            {
                PowerStatus ps = SystemInformation.PowerStatus;

                MessageBox.Show("Battery level: " + ps.BatteryLifePercent +
                    "\nPowerStatus.PowerLineStatus == PowerLineStatus.Online: " + (ps.PowerLineStatus == PowerLineStatus.Online).ToString() +
                    "\nOffline: " + (ps.PowerLineStatus == PowerLineStatus.Offline).ToString() +
                    "\nUnknown: " + (ps.PowerLineStatus == PowerLineStatus.Unknown).ToString(),
                    "Debug (BatteryReminder)",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return 0;
            }

            //Application.Run(new ChargedForm());

            if (!Arguments.Contains("-start"))
            {
                MessageBox.Show("Pour commencer à utiliser BatteryReminder, " +
                    "installez-le sur un appareil équipé d'une batterie.", "Ryanhtech BatteryReminder",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                return 0;
            }

            // Start the monitoring
            Thread MonitorThread = new Thread(StartMonitorThread);
            MonitorThread.Start();

            return 0;
        }

        private static void StartMonitorThread()
        {
            // This should be in a thread.
            ChargedForm ChargedFormInst = new ChargedForm();

            while (true)
            {
                PowerStatus ps = SystemInformation.PowerStatus;

                // 1 = 100%
                if (ps.BatteryLifePercent == 1 && ps.PowerLineStatus == PowerLineStatus.Online)
                {
                    ChargedFormInst.ShowDialog();

                    // The dialog has been closed
                    while (true)
                    {
                        PowerStatus LocalPs = SystemInformation.PowerStatus;

                        // Wait until the battery level has dropped of 1%
                        if (LocalPs.BatteryLifePercent < 1) break;

                        Thread.Sleep(60 * 1000);  // Wait 1 minute
                    }
                }

                // Sleep 1 minute to verify again
                Thread.Sleep(60 * 1000);
            }
        }
    }
}
