using System;
using System.Windows.Forms;

namespace Growtopia_Chat_Spam_Client
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            Properties.Settings.Default.PropertyChanged += (o, e) => Properties.Settings.Default.Save();
        }

        #region UI

        #region Event Handlers

        private void clearTextBoxButton_Click(object sender, EventArgs e) => textToSpamTextBox.Text = "";

        private void spamIntervalTrackBar_Scroll(object sender) => selectedSpamIntervalLabel.Text = $"Selected spam interval: {spamIntervalTrackBar.Value}ms.";

        private void topMostCheckBox_CheckedChanged(object sender)
        {
            switch (topMostCheckBox.Checked)
            {
                case true:
                    this.TopMost = true;
                    break;
                case false:
                    this.TopMost = false;
                    break;
            }
        }

        #endregion

        #endregion
    }
}
