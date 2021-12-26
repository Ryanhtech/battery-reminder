using System;
using System.Media;
using System.Windows.Forms;
using System.Threading;

namespace BatteryReminder
{
    public partial class ChargedForm : Form
    {
        public ChargedForm()
        {
            InitializeComponent();
        }

        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            // Close the form
            Close();
        }

        private void OpenAboutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void ChargedForm_Load(object sender, EventArgs e)
        {
            SystemSounds.Question.Play();

            // Start the battery listener thread
            Thread BatteryListenerThread = new Thread(BatteryListenerThreadFunc);
            BatteryListenerThread.Start();
        }

        private void BatteryListenerThreadFunc()
        {
            while (true)
            {
                PowerStatus PwrStatus = SystemInformation.PowerStatus;

                if (PwrStatus.PowerLineStatus == PowerLineStatus.Offline)
                {
                    // Close the dialog because the computer is disconnected
                    Close();
                    break;
                }

                Thread.Sleep(1000);  // Sleep 1 second
            }
        }
    }
}
