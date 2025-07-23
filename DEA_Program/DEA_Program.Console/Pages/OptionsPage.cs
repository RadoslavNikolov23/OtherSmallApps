namespace DEA_Program.Console.Pages
{
    using DEA_Program.Common.Helper;
    using DEA_Program.Data;
    using DEA_Program.Data.Model;
    using System;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class OptionsPage : Form
    {
        private readonly Form previousForm;

        private readonly DEADatabaseContext context;

        private DbUser loggedUser;
        public OptionsPage(DEADatabaseContext context, Form previous, DbUser loggedUser)
        {
            InitializeComponent();
            this.context = context;
            this.previousForm = previous;
            this.loggedUser = loggedUser;
        }
        private void reportBugButton_Click(object sender, EventArgs e)
        {
            this.sendReportGroupBox.Visible = true;
        }

        private async void sendButton_Click(object sender, EventArgs e)
        {
            try
            {
                string userMessage = $"From {this.fromWhoTextBox.Text} \n {this.userTextMessageTextBox.Text}";
                string logFilePath = Logger.GetLogFilePath();

                BugReporter.SendBugReport(userMessage == null ? "" : userMessage, logFilePath);
                await MessageBoxOutput("Bug report has been sent. Thank you!", "Success");
                this.sendReportGroupBox.Visible = false;

            }
            catch (Exception ex)
            {
                Logger.Log(ex, "Error in the SendButtonReport/OptionsPage.cs");
                await MessageBoxOutput("Something went work, try again!", "Error");
                this.userTextMessageTextBox.Clear();
            }
        }

        private void goMenuPageButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            var menuPage = new MenuPage(context, this, this.loggedUser);
            Navigation.GoBackTo(this, menuPage);

            Cursor.Current = Cursors.Default;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            this.context.Dispose();
            Application.Exit();
        }

        private Task MessageBoxOutput(string text, string title)
        {
            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return Task.CompletedTask;
        }

    }
}
