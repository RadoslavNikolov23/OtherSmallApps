namespace DEA_Program.Console.Pages
{
    using DEA_Program.Data;
    using DEA_Program.Data.Model;
    using DEA_Program.Data.Repository;
    using System;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using DEA_Program.Common.Helper;

    public partial class VehicleInfo : Form
    {
        private readonly DEADatabaseContext context;
        private readonly Form previousForm;
        private readonly DbVehicleRepository dbVehicleRepo;
        private readonly DbPersonRepository dbPersonRepo;

        private DbUser loggedUser;

        public VehicleInfo(DEADatabaseContext context, Form previous, DbUser loggedUser)
        {
            InitializeComponent();
            this.context = context;
            this.previousForm = previous;
            this.loggedUser = loggedUser;

            this.dbVehicleRepo = new DbVehicleRepository(this.context);
            this.dbPersonRepo = new DbPersonRepository(this.context);
        }

        private async void findVehicleButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            await HandleVehicleInfo(sender, e);
             Cursor.Current = Cursors.Default;
        }

        private async Task HandleVehicleInfo(object sender, EventArgs e)
        {
            this.infoVehicleGroupBox.Visible = false;

            if (this.enteredRegistrationNumberTextBox.Text == null
                || this.enteredRegistrationNumberTextBox.Text.Length > 10)
            {
                Cursor.Current = Cursors.Default;
                await MessageBoxOutput("Vehicle registration number is incorrected, try again!", "Error");
                return;
            }

            try
            {
                DbVehicle vehicle = await this.dbVehicleRepo.GetVehicleByRegistrationNumber(this.enteredRegistrationNumberTextBox.Text);

                if (vehicle != null)
                {
                    DbPerson person = await this.dbPersonRepo.GetPersonByPersonalId(vehicle.Person.PersonalId);

                    this.vehicleFoundLabel.Text = $"Vehicle found!";
                    this.infoVehicleGroupBox.Visible = true;

                    await ShowVehicleInfo(sender, e, vehicle, person);
                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    Cursor.Current = Cursors.Default;
                    this.vehicleFoundLabel.Text = $"Vehicle not found! Try diffrent ID!";
                    this.infoVehicleGroupBox.Visible = false;
                }
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                Logger.Log(ex, "Error in the HandleVehicleInfo/VehicleInfo.cs");
                await MessageBoxOutput("Something went work, try again!", "Error");
            }
        }

        private Task ShowVehicleInfo(object sender, EventArgs e, DbVehicle vehicle, DbPerson person)
        {
            this.modelTextBox.Text = vehicle.Model;
            this.countryNationalityTextBox.Text = vehicle.CountryCode.ToString();
            this.additionalInfoTextBox.Text = vehicle.AdditionalInformationAboutTheVehicle != null ? vehicle.AdditionalInformationAboutTheVehicle : null;

            if (person != null)
            {
                this.ownerNameTextBox.Text = $"{person.FirstName} {person.LastName}";
            }
            else
            {
                this.ownerNameTextBox.Text = $"Car not registered to a Owner.";
            }

            if (vehicle.CustomControls != null)
            {
                foreach (var customDate in vehicle.CustomControls)
                {
                    this.customsControlComboBox.Items.Add(customDate.DayOfVerification);
                }
            }
            return Task.CompletedTask;
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
