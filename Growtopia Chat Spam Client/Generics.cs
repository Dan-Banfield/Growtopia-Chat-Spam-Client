using System.Windows.Forms;

namespace Growtopia_Chat_Spam_Client
{
    public static class Generics
    {
        public static class MessageBox
        {
            public static void ShowInformation(string contents)
            {
                System.Windows.Forms.MessageBox.Show(contents, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            public static void ShowError(string contents)
            {
                System.Windows.Forms.MessageBox.Show(contents, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
