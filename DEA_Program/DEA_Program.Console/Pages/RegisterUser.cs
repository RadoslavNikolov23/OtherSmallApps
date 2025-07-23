namespace DEA_Program.Console.Pages
{
    using DEA_Program.Data;
    using DEA_Program.Data.Model;
    using DEA_Program.Common.Enums;
    using DEA_Program.Data.Repository;
    using System;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using DEA_Program.Common.Helper;
    using System.Text;

    public partial class RegisterUser : Form
    {
        private readonly DEADatabaseContext context;
        private readonly Form previousForm;
        private readonly DbUserRepository dbLoginRepo;

        private DbUser loggedUser;

        public RegisterUser(DEADatabaseContext context, Form previous, DbUser loggedUser)
        {
            InitializeComponent();
            this.context = context;
            this.previousForm = previous;
            this.loggedUser = loggedUser;

            this.dbLoginRepo = new DbUserRepository(this.context);
        }

        private async void addUserButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            await HandleAddUser(sender, e);
             Cursor.Current = Cursors.Default;
        }

        private async Task HandleAddUser(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(this.userNameTextBox.Text)
                || this.userNameTextBox.Text.Length > 120)
            {
                Cursor.Current = Cursors.Default;
                await MessageBoxOutput("User name is incorrected, try again!", "Error");
                return;
            }

            if(String.IsNullOrWhiteSpace(this.passwordTextBox.Text))
            {
                Cursor.Current = Cursors.Default;
                await MessageBoxOutput("Password is incorrected, try again!", "Error");
                return;
            }

            if(this.passwordTextBox.Text.Length<4)
            {
                Cursor.Current = Cursors.Default;
                await MessageBoxOutput("Password is too short, try again!", "Error");
                return;
            }
            

            if(this.passwordTextBox.Text.Length > 8)
            {
                Cursor.Current = Cursors.Default;
                await MessageBoxOutput("Password is too long, try again!", "Error");
                return;
            }

            if (await this.dbLoginRepo.UserExist(userNameTextBox.Text))
            {
                Cursor.Current = Cursors.Default;
                await MessageBoxOutput($"User with {userNameTextBox.Text} alredy exist, try again!", "Error");
                return;
            }

            try
            {
                DbUser user = new DbUser
                {
                    Username = this.userNameTextBox.Text,
                    Password = this.passwordTextBox.Text,
                    Role = (Role)this.roleComboBox.SelectedItem
                };

                int number = await this.dbLoginRepo.AddUser(user);

                if (number > 0)
                {
                    Cursor.Current = Cursors.Default;
                    await MessageBoxOutput("User registered successufly", "Info");
                }
                else
                {
                    Cursor.Current = Cursors.Default;
                    await MessageBoxOutput("User wasn't register, try again!", "Error");

                    this.userNameTextBox.Text = "";
                    this.passwordTextBox.Text = "";
                }
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                Logger.Log(ex, "Error in the HandleAddUser/RegisterUser.cs");
                await MessageBoxOutput("Something went work, try again!", "Error");
            }
        }
        private async void allUsersButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            await HandleAllUser(sender, e);
            Cursor.Current = Cursors.Default;
        }

        private async Task HandleAllUser(object sender, EventArgs e)
        {
            try
            {
                var allUsers = await this.dbLoginRepo.GetAllUser();

                StringBuilder sb = new StringBuilder();

                if (allUsers != null && allUsers.Count > 0)
                {
                    foreach (var user in allUsers)
                    {
                        sb.AppendLine($"{user.Username} - Password: {user.Password}, Role {user.Role.ToString()}");
                    }

                    Cursor.Current = Cursors.Default;
                    await MessageBoxOutput($"{sb.ToString().Trim()}", "Information of all registerd users");
                    return;
                }
                else
                {
                    Cursor.Current = Cursors.Default;
                    await MessageBoxOutput($"No users are registered", "Error");
                    return;
                }
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                Logger.Log(ex, "Error in the HandleAllUser/RegisterUser.cs");
                await MessageBoxOutput("Something went work, try again!", "Error");
            }
        }


        private void goBackButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            var menuPage = new MenuPage(context, this, this.loggedUser);
            Navigation.GoBackTo(this, menuPage);

            Cursor.Current = Cursors.Default;
        }

        private Task MessageBoxOutput(string text, string title)
        {
            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return Task.CompletedTask;
        }

       
    }
}
