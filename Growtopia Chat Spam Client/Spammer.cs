using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Growtopia_Chat_Spam_Client
{
    public class Spammer
    {
        public bool isSpamming;

        private NSButton spamButton;
        private NSTextBox textToSpamTextBox;
        private NSTrackBar spamIntervalTrackBar;

        private const string GROWTOPIA_PROCESS_NAME = "Growtopia";

        public Spammer(NSButton spamButton, NSTextBox textToSpamTextBox, NSTrackBar spamIntervalTrackBar)
        {
            this.spamButton = spamButton;
            this.textToSpamTextBox = textToSpamTextBox;
            this.spamIntervalTrackBar = spamIntervalTrackBar;
        }

        public void ToggleSpam()
        {
            if (isSpamming) { StopSpam(); return; }
            StartSpam();
        }

        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        private async void StartSpam()
        {
            isSpamming = true;
            spamButton.Text = "Stop spamming!";

            if (GrowtopiaIsOpen())
            {
                IntPtr growtopiaHandle = Process.GetProcessesByName(GROWTOPIA_PROCESS_NAME)[0].MainWindowHandle;

                while (isSpamming)
                {
                    try
                    {
                        SetForegroundWindow(growtopiaHandle);

                        SendKeys.SendWait("{ENTER}");
                        SendKeys.SendWait(textToSpamTextBox.Text);
                        SendKeys.SendWait("{ENTER}");

                        await Task.Delay((int)spamIntervalTrackBar.Value);
                    }
                    catch
                    {
                        StopSpam();
                        Generics.MessageBox.ShowError("Failed to send instructions to Growtopia!");
                    }
                }
            }
            else
            {
                StopSpam();
                Generics.MessageBox.ShowError("Growtopia is not open!");
            }
        }

        private void StopSpam()
        {
            isSpamming = false;
            spamButton.Text = "Start spamming!";
        }

        private bool GrowtopiaIsOpen()
        {
            return Process.GetProcessesByName(GROWTOPIA_PROCESS_NAME).Length > 0;
        }
    }
}
