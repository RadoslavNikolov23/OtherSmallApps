namespace DEA_Program.Console.Pages
{
    using DEA_Program.Data;
    using DEA_Program.Data.Model;
    using DEA_Program.Common.Enums;
    using DEA_Program.Data.Repository;
    using System;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class RegisterVehicle : Form
    {
        private readonly DEADatabaseContext context;
        private readonly Form previousForm;
        private readonly DbVehicleRepository dbVehicleRepo;
        private readonly DbPersonRepository dbPersonRepo;

        private DbUser loggedUser;


        public RegisterVehicle(DEADatabaseContext context, Form previous, DbUser loggedUser)
        {
            InitializeComponent();
            this.context = context;
            this.previousForm = previous;
            this.loggedUser = loggedUser;

            this.dbVehicleRepo = new DbVehicleRepository(this.context);
            this.dbPersonRepo = new DbPersonRepository(this.context);

            this.countryCodeListBox.DataSource = Enum.GetValues(typeof(CountryCode));
            this.countryCodeListBox.SelectionMode = SelectionMode.One;

        }

        private void addVehicleButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            _ = HandleAddVehicle(sender, e);

            Cursor.Current = Cursors.Default;
        }

        private async Task HandleAddVehicle(object sender, EventArgs e)
        {
            if (this.registrationNumberTextBox.Text == null
                || this.registrationNumberTextBox.Text.Length > 10)
            {
                Cursor.Current = Cursors.Default;
                await MessageBoxOutput("Vehicle registration number is incorrected, try again!", "Error");
                return;
            }
            if (this.modelTextBox.Text == null
               || this.modelTextBox.Text.Length > 10)
            {
                Cursor.Current = Cursors.Default;
                await MessageBoxOutput("Vehicle model is incorrected, try again!", "Error");
                return;
            }


            if (!(this.countryCodeListBox.SelectedItem is CountryCode selectedCountryCode))
            {
                Cursor.Current = Cursors.Default;
                await MessageBoxOutput("Vehicle Country of Code is incorrected, try again!", "Error");
                return;
            }

            if (this.ownerIDTextBox.Text == null
                || this.ownerIDTextBox.Text.Length > 10)
            {
                Cursor.Current = Cursors.Default;
                await MessageBoxOutput("Person Id is incorrected, try again!", "Error");
                return;
            }

            if (this.customCheckDateTimePicker.Value == null)
            {
                Cursor.Current = Cursors.Default;
                await MessageBoxOutput("Custom Control date is incorrected, try again!", "Error");
                return;
            }

            if (! await this.dbPersonRepo.PersonExist(this.ownerIDTextBox.Text))
            {
                Cursor.Current = Cursors.Default;
                await MessageBoxOutput($"Person with this Id {this.ownerIDTextBox.Text} does not exist, try again!", "Error");
                return;
            }

            if (await this.dbVehicleRepo.VehicleExist(this.registrationNumberTextBox.Text))
            {
                Cursor.Current = Cursors.Default;
                await MessageBoxOutput($"Vehicle with number {this.registrationNumberTextBox.Text} alredy exist, try again!", "Error");
                return;
            }

            //------------------------
            DbVehicle vehicle = new DbVehicle
            {
                RegistrationNumber = this.registrationNumberTextBox.Text,
                Model=this.modelTextBox.Text,
                CountryCode = selectedCountryCode,
                AdditionalInformationAboutTheVehicle = this.additionalInfoTextBox.Text != null ? this.additionalInfoTextBox.Text : null
            };

            vehicle.CustomControls.Add(new DbCustomControl
            {
                DayOfVerification = this.customCheckDateTimePicker.Value,
                AdditionalInformationAboutTheControl = this.additionalInfoTextBox.Text != null ? this.additionalInfoTextBox.Text : null
            });

            vehicle.Person = await dbPersonRepo.GetPersonByPersonalId(this.ownerIDTextBox.Text);
            vehicle.Person.CustomControls.Add(new DbCustomControl
            {
                DayOfVerification = this.customCheckDateTimePicker.Value,
                AdditionalInformationAboutTheControl = this.additionalInfoTextBox.Text != null ? this.additionalInfoTextBox.Text : null
            });

            //Check if there is a defefaoult value fot the Cutstom check datepickerc# ????

            int number = await dbVehicleRepo.AddVehicle(vehicle);

            if (number > 0)
            {
                Cursor.Current = Cursors.Default;
                await MessageBoxOutput("Vehicle saved successufly", "Info");

                this.registrationNumberTextBox.Text = "";
                this.modelTextBox.Text = "";
                this.ownerIDTextBox.Text = "";
                this.customCheckDateTimePicker.Value = default;
            }
            else
            {
                Cursor.Current = Cursors.Default;
                await MessageBoxOutput("Vehicle wasn't saved, try again!", "Error");
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
