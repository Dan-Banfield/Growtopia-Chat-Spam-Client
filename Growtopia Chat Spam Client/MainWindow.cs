using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Growtopia_Chat_Spam_Client
{
    public partial class MainWindow : Form
    {
        private Spammer spammer;

        public MainWindow()
        {
            InitializeComponent();
            InitializeSettings();

            Properties.Settings.Default.PropertyChanged += (o, e) => Properties.Settings.Default.Save();
        }

        #region UI

        #region Event Handlers

        private void clearTextBoxButton_Click(object sender, EventArgs e) => textToSpamTextBox.Text = "";

        private void githubLogoPictureBox_Click(object sender, EventArgs e) => Process.Start("https://github.com/Dan-Banfield/Growtopia-Chat-Spam-Client");

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

        private void saveConfigButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.savedText = textToSpamTextBox.Text;
            Properties.Settings.Default.spamInterval = spamIntervalTrackBar.Value;
            Properties.Settings.Default.topMost = topMostCheckBox.Checked;

            Generics.MessageBox.ShowInformation("Your config has been saved successfully.");
        }

        private void toggleSpamButton_Click(object sender, EventArgs e)
        {
            if (spammer is null) spammer = new Spammer(toggleSpamButton, textToSpamTextBox, spamIntervalTrackBar);

            spammer.ToggleSpam();
        }

        #endregion

        #endregion

        #region Methods

        private void InitializeSettings()
        {
            textToSpamTextBox.Text = Properties.Settings.Default.savedText != string.Empty ? Properties.Settings.Default.savedText : "Your text to spam here.";
            spamIntervalTrackBar.Value = Properties.Settings.Default.spamInterval;

            switch (Properties.Settings.Default.topMost)
            {
                case true:
                    topMostCheckBox.Checked = true;
                    break;
                case false:
                    topMostCheckBox.Checked = false;
                    break;
            }
        }

        #endregion
    }
}
