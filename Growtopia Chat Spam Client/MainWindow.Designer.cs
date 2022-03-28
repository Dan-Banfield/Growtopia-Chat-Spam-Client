
namespace Growtopia_Chat_Spam_Client
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.netSealTheme = new NSTheme();
            this.closeButton = new NSControlButton();
            this.minimizeButton = new NSControlButton();
            this.optionsGroupBox = new NSGroupBox();
            this.titleLabel = new NSLabel();
            this.textToSpamTextBox = new NSTextBox();
            this.startSpamButton = new NSButton();
            this.clearTextBoxButton = new NSButton();
            this.topMostCheckBox = new NSCheckBox();
            this.spamIntervalTrackBar = new NSTrackBar();
            this.titleLabel2 = new NSLabel();
            this.selectedSpamIntervalLabel = new System.Windows.Forms.Label();
            this.netSealTheme.SuspendLayout();
            this.optionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // netSealTheme
            // 
            this.netSealTheme.AccentOffset = 0;
            this.netSealTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.netSealTheme.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.netSealTheme.Colors = new Bloom[0];
            this.netSealTheme.Controls.Add(this.optionsGroupBox);
            this.netSealTheme.Controls.Add(this.minimizeButton);
            this.netSealTheme.Controls.Add(this.closeButton);
            this.netSealTheme.Customization = "";
            this.netSealTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.netSealTheme.Font = new System.Drawing.Font("Verdana", 8F);
            this.netSealTheme.Image = null;
            this.netSealTheme.Location = new System.Drawing.Point(0, 0);
            this.netSealTheme.MaximumSize = new System.Drawing.Size(800, 450);
            this.netSealTheme.MinimumSize = new System.Drawing.Size(600, 350);
            this.netSealTheme.Movable = true;
            this.netSealTheme.Name = "netSealTheme";
            this.netSealTheme.NoRounding = false;
            this.netSealTheme.Sizable = true;
            this.netSealTheme.Size = new System.Drawing.Size(600, 350);
            this.netSealTheme.SmartBounds = true;
            this.netSealTheme.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.netSealTheme.TabIndex = 0;
            this.netSealTheme.Text = "Growtopia Chat Spam Client";
            this.netSealTheme.TransparencyKey = System.Drawing.Color.Empty;
            this.netSealTheme.Transparent = false;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.ControlButton = NSControlButton.Button.Close;
            this.closeButton.Location = new System.Drawing.Point(575, 4);
            this.closeButton.Margin = new System.Windows.Forms.Padding(0);
            this.closeButton.MaximumSize = new System.Drawing.Size(18, 20);
            this.closeButton.MinimumSize = new System.Drawing.Size(18, 20);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(18, 20);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Close";
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.ControlButton = NSControlButton.Button.Minimize;
            this.minimizeButton.Location = new System.Drawing.Point(548, 4);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(0);
            this.minimizeButton.MaximumSize = new System.Drawing.Size(18, 20);
            this.minimizeButton.MinimumSize = new System.Drawing.Size(18, 20);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(18, 20);
            this.minimizeButton.TabIndex = 1;
            this.minimizeButton.Text = "Minimize";
            // 
            // optionsGroupBox
            // 
            this.optionsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optionsGroupBox.Controls.Add(this.selectedSpamIntervalLabel);
            this.optionsGroupBox.Controls.Add(this.titleLabel2);
            this.optionsGroupBox.Controls.Add(this.spamIntervalTrackBar);
            this.optionsGroupBox.Controls.Add(this.topMostCheckBox);
            this.optionsGroupBox.Controls.Add(this.clearTextBoxButton);
            this.optionsGroupBox.Controls.Add(this.startSpamButton);
            this.optionsGroupBox.Controls.Add(this.textToSpamTextBox);
            this.optionsGroupBox.Controls.Add(this.titleLabel);
            this.optionsGroupBox.DrawSeperator = false;
            this.optionsGroupBox.Location = new System.Drawing.Point(23, 47);
            this.optionsGroupBox.Name = "optionsGroupBox";
            this.optionsGroupBox.Size = new System.Drawing.Size(554, 283);
            this.optionsGroupBox.SubTitle = "Select the options to consider when spamming.";
            this.optionsGroupBox.TabIndex = 2;
            this.optionsGroupBox.Text = "nsGroupBox1";
            this.optionsGroupBox.Title = "Options";
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Location = new System.Drawing.Point(17, 48);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(112, 23);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "nsLabel1";
            this.titleLabel.Value1 = "TEXT";
            this.titleLabel.Value2 = " TO SPAM";
            // 
            // textToSpamTextBox
            // 
            this.textToSpamTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textToSpamTextBox.AutoScroll = false;
            this.textToSpamTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textToSpamTextBox.Location = new System.Drawing.Point(17, 73);
            this.textToSpamTextBox.MaxLength = 32767;
            this.textToSpamTextBox.Multiline = false;
            this.textToSpamTextBox.Name = "textToSpamTextBox";
            this.textToSpamTextBox.NumberBounds = new System.Drawing.Point(0, 0);
            this.textToSpamTextBox.NumbersOnly = false;
            this.textToSpamTextBox.ReadOnly = false;
            this.textToSpamTextBox.Size = new System.Drawing.Size(263, 193);
            this.textToSpamTextBox.TabIndex = 1;
            this.textToSpamTextBox.Text = "Your text to spam here.";
            this.textToSpamTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textToSpamTextBox.UseSystemPasswordChar = false;
            // 
            // startSpamButton
            // 
            this.startSpamButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startSpamButton.Location = new System.Drawing.Point(305, 200);
            this.startSpamButton.Name = "startSpamButton";
            this.startSpamButton.Size = new System.Drawing.Size(225, 32);
            this.startSpamButton.TabIndex = 2;
            this.startSpamButton.Text = "Start spamming!";
            // 
            // clearTextBoxButton
            // 
            this.clearTextBoxButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearTextBoxButton.Location = new System.Drawing.Point(305, 162);
            this.clearTextBoxButton.Name = "clearTextBoxButton";
            this.clearTextBoxButton.Size = new System.Drawing.Size(225, 32);
            this.clearTextBoxButton.TabIndex = 3;
            this.clearTextBoxButton.Text = "Clear text box";
            // 
            // topMostCheckBox
            // 
            this.topMostCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.topMostCheckBox.Checked = false;
            this.topMostCheckBox.Location = new System.Drawing.Point(449, 243);
            this.topMostCheckBox.Name = "topMostCheckBox";
            this.topMostCheckBox.Size = new System.Drawing.Size(81, 23);
            this.topMostCheckBox.TabIndex = 4;
            this.topMostCheckBox.Text = "Top most";
            // 
            // spamIntervalTrackBar
            // 
            this.spamIntervalTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.spamIntervalTrackBar.Location = new System.Drawing.Point(305, 122);
            this.spamIntervalTrackBar.Maximum = 10000;
            this.spamIntervalTrackBar.Minimum = 100;
            this.spamIntervalTrackBar.Name = "spamIntervalTrackBar";
            this.spamIntervalTrackBar.Size = new System.Drawing.Size(225, 23);
            this.spamIntervalTrackBar.TabIndex = 5;
            this.spamIntervalTrackBar.Text = "Spam Interval";
            this.spamIntervalTrackBar.Value = 100;
            // 
            // titleLabel2
            // 
            this.titleLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.titleLabel2.Location = new System.Drawing.Point(305, 71);
            this.titleLabel2.Name = "titleLabel2";
            this.titleLabel2.Size = new System.Drawing.Size(127, 23);
            this.titleLabel2.TabIndex = 6;
            this.titleLabel2.Text = "nsLabel1";
            this.titleLabel2.Value1 = "SPAM";
            this.titleLabel2.Value2 = " INTERVAL";
            // 
            // selectedSpamIntervalLabel
            // 
            this.selectedSpamIntervalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedSpamIntervalLabel.AutoSize = true;
            this.selectedSpamIntervalLabel.ForeColor = System.Drawing.Color.White;
            this.selectedSpamIntervalLabel.Location = new System.Drawing.Point(302, 97);
            this.selectedSpamIntervalLabel.Name = "selectedSpamIntervalLabel";
            this.selectedSpamIntervalLabel.Size = new System.Drawing.Size(189, 13);
            this.selectedSpamIntervalLabel.TabIndex = 7;
            this.selectedSpamIntervalLabel.Text = "Selected spam interval: 100ms.";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.netSealTheme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 450);
            this.MinimumSize = new System.Drawing.Size(600, 350);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Growtopia Chat Spam Client";
            this.netSealTheme.ResumeLayout(false);
            this.optionsGroupBox.ResumeLayout(false);
            this.optionsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private NSTheme netSealTheme;
        private NSControlButton closeButton;
        private NSControlButton minimizeButton;
        private NSGroupBox optionsGroupBox;
        private NSLabel titleLabel;
        private NSTextBox textToSpamTextBox;
        private NSButton startSpamButton;
        private NSButton clearTextBoxButton;
        private NSCheckBox topMostCheckBox;
        private NSTrackBar spamIntervalTrackBar;
        private NSLabel titleLabel2;
        private System.Windows.Forms.Label selectedSpamIntervalLabel;
    }
}

