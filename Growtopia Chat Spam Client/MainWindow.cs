using System;
using System.Windows.Forms;

namespace Growtopia_Chat_Spam_Client
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        #region UI

        #region Event Handlers

        private void clearTextBoxButton_Click(object sender, EventArgs e) => textToSpamTextBox.Text = "";

        private void spamIntervalTrackBar_Scroll(object sender) => selectedSpamIntervalLabel.Text = $"Selected spam interval: {spamIntervalTrackBar.Value}ms.";

        #endregion

        #endregion
    }
}
