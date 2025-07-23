namespace DEA_Program.Console
{
    using DEA_Program.Common.Helper;
    using DEA_Program.Console.Pages;
    using DEA_Program.Data;
    using DEA_Program.Data.Model;
    using DEA_Program.Data.Repository;
    using System;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class MainPage : Form
    {
        private DEADatabaseContext context;
        private DbUserRepository loginRepo;



        public MainPage()
        {
            InitializeComponent();
            try
            {
                this.context = new DEADatabaseContext();
            }
            catch (Exception ex)
            {
                Logger.Log(ex, "Error in the DBContex connection in the MainPage.cs");
                MessageBoxOutput("Can't connect, try again later!", "Error");
            }
            this.loginRepo = new DbUserRepository(context);
        }

        private async void loginButton_Click(object sender, EventArgs e)
        {
            await LoginAsync(sender, e);
        }

        private async Task LoginAsync(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                DbUser user = await loginRepo.GetUser(this.usernameTextBox.Text);

                if (user != null)
                {
                    if (this.passwordTextBox.Text == user.Password)
                    {
                        var menuPage = new MenuPage(context, this, user);
                        Navigation.NavigateTo(this, menuPage);
                    }
                    else
                    {
                        Cursor.Current = Cursors.Default;
                        await MessageBoxOutput("Password is incorrect", "Error");
                    }
                }
                else
                {
                    Cursor.Current = Cursors.Default;
                    await MessageBoxOutput("Username is not in not register! ", "Error");
                }
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                Logger.Log(ex, "Error in the MainPage.cs");
                await MessageBoxOutput("Can't connect, try again later!", "Error");
            }
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
