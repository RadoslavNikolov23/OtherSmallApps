namespace DEA_Program.Console
{
    using DEA_Program.Console.Pages;
    using DEA_Program.Data;
    using DEA_Program.Data.Model;
    using DEA_Program.Common.Enums;
    using DEA_Program.Data.Repository;
    using System;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using DEA_Program.Common.Helper;

    public partial class MenuPage : Form
    {
        private readonly Form previousForm;

        private readonly DEADatabaseContext context;

        private readonly DbVehicleRepository dbVehicleRepo;
        private readonly DbPersonRepository dbPersonRepo;
        private readonly DbCustomControlRepository dbCustomControlRepo;

        private DbUser loggedUser;

        public MenuPage(DEADatabaseContext context, Form previous, DbUser loggedUser)
        {
            InitializeComponent();
            this.context = context;
            this.previousForm = previous;
             this.loggedUser = loggedUser;

            this.welcomeLabel.Text = $"Welcome, {loggedUser.Username}";

            if (this.loggedUser.Role == Role.Admin)
            {
                this.adminMenuGroupBox.Visible = true;
            }

            this.dbVehicleRepo = new DbVehicleRepository(this.context);
            this.dbPersonRepo = new DbPersonRepository(this.context);
            this.dbCustomControlRepo = new DbCustomControlRepository(this.context);
        }

        private void toChechPersonbutton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            var personInfoPage = new PersonInfo(context, this, this.loggedUser);
            Navigation.NavigateTo(this, personInfoPage);

            Cursor.Current = Cursors.Default;
        }
        private void toCheckVehicleButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            var vehicleInfoPage = new VehicleInfo(context, this, this.loggedUser);
            Navigation.NavigateTo(this, vehicleInfoPage);

            Cursor.Current = Cursors.Default;
        }

        private void addCustomCotrolButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            var registerCustomControl = new RegisterCustomControl(context, this, this.loggedUser);
            Navigation.NavigateTo(this, registerCustomControl);

            Cursor.Current = Cursors.Default;
        }

        private void toCheckCustomControlButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            var customControlInfo = new CustomControlInfo(context, this, this.loggedUser);
            Navigation.NavigateTo(this, customControlInfo);

            Cursor.Current = Cursors.Default;
        }

        private void toLoginMainPageButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            var mainPage = new MainPage();
            Navigation.NavigateTo(this, mainPage);

            Cursor.Current = Cursors.Default;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            this.Dispose();
            Application.Exit();
        }

        private void registerUserButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            var registerUserPage = new RegisterUser(context, this, this.loggedUser);
            Navigation.NavigateTo(this, registerUserPage);

            Cursor.Current = Cursors.Default;
        }

        private async void allPersonsButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            await HandleAllPerson(sender, e);

            Cursor.Current = Cursors.Default;
        }

        private async Task HandleAllPerson(object sender, EventArgs e)
        {
            try
            {
                var allPersons = await this.dbPersonRepo.GetAllPersonIdAndNameRecords();

                StringBuilder sb = new StringBuilder();

                if (allPersons != null && allPersons.Count > 0)
                {
                    foreach (var person in allPersons)
                    {
                        sb.AppendLine($"{person.FirstName + " " + person.LastName} - {person.PersonalId}");
                    }

                    Cursor.Current = Cursors.Default;
                    await MessageBoxOutput($"{sb.ToString().Trim()}", "Information of all registerd persons");
                    return;
                }
                else
                {
                    Cursor.Current = Cursors.Default;
                    await MessageBoxOutput($"No persons are registered", "Error");
                    return;
                }
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                Logger.Log(ex, "Error in the HandleAllPerson/MenuPage.cs");
                await MessageBoxOutput("Something went work, try again!", "Error");
            }
        }

        private async void allVehiclesButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            await HandleAllVechiles(sender, e);

            Cursor.Current = Cursors.Default;
        }

        private async Task HandleAllVechiles(object sender, EventArgs e)
        {
            try
            {
                var allVehicles = await this.dbVehicleRepo.GetAllVechileRecords();

                StringBuilder sb = new StringBuilder();
                if (allVehicles != null && allVehicles.Count > 0)
                {
                    foreach (var vehicle in allVehicles)
                    {
                        sb.AppendLine($"{vehicle.Model} {vehicle.RegistrationNumber} ");
                          
                        if(vehicle.Person != null)
                        {
                            sb.Append($"/ Owner {vehicle.Person.FirstName} {vehicle.Person.LastName}");
                        }
                    }

                    Cursor.Current = Cursors.Default;
                    await MessageBoxOutput($"{sb.ToString().Trim()}", "Information of all registerd vehicles");
                    return;
                }
                else
                {
                    Cursor.Current = Cursors.Default;
                    await MessageBoxOutput($"No vehicles are registered", "Error");
                    return;
                }
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                Logger.Log(ex, "Error in the HandleAllVehicle/MenuPage.cs");
                await MessageBoxOutput("Something went work, try again!", "Error");
            }

        }

        private async void ShowAllCustomControlbutton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            await HandleAllCustomsControls(sender, e);
             Cursor.Current = Cursors.Default;
        }

        private async Task HandleAllCustomsControls(object sender, EventArgs e)
        {
            try
            {
                var allCustomCtrols = await this.dbCustomControlRepo.GetAllCustomControl();

                StringBuilder sb = new StringBuilder();

                if (allCustomCtrols != null && allCustomCtrols.Count > 0)
                {
                    foreach (var customControl in allCustomCtrols)
                    {
                        sb.AppendLine($"{customControl.DayOfVerification.ToString("dd/MM/yyyy")}");
                        if(customControl.Person != null)
                        {
                            sb.Append($" - Person {customControl.Person.FirstName} {customControl.Person.LastName}");
                        }

                        if(customControl.Vehicle != null)
                        {
                            sb.Append($" - Vehicle {customControl.Vehicle.Model} {customControl.Vehicle.RegistrationNumber}");
                        }
                    }

                    Cursor.Current = Cursors.Default;
                    await MessageBoxOutput($"{sb.ToString().Trim()}", "Information of all customs controls");
                    return;
                }
                else
                {
                    Cursor.Current = Cursors.Default;
                    await MessageBoxOutput($"No custom controls are registered", "Error");
                    return;
                }
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                Logger.Log(ex, "Error in the HandleAllCustomsControl/Menupage.cs");
                await MessageBoxOutput("Something went work, try again!", "Error");
            }
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            var optionPage = new OptionsPage(context, this, this.loggedUser);
            Navigation.NavigateTo(this, optionPage);

            Cursor.Current = Cursors.Default;
        }

        private Task MessageBoxOutput(string text, string title)
        {
            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return Task.CompletedTask;
        }

       
    }
}
