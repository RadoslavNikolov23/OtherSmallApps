namespace DEA_Program.Console.Pages
{
    using DEA_Program.Data;
    using DEA_Program.Data.Model;
    using DEA_Program.Data.Repository;
    using System;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class RegisterCC : Form
    {
        private readonly DEADatabaseContext context;
        private readonly Form previousForm;
        private readonly DbVehicleRepository dbVehicleRepo;
        private readonly DbPersonRepository dbPersonRepo;

        private DbUser loggedUser;

        public RegisterCC(DEADatabaseContext context, Form previous, DbUser loggedUser)
        {
            InitializeComponent();
            this.context = context;
            this.previousForm = previous;
            this.loggedUser = loggedUser;

            this.dbVehicleRepo = new DbVehicleRepository(this.context);
            this.dbPersonRepo = new DbPersonRepository(this.context);
        }

        private void addToPersonButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            _ = HandleAddToPerson(sender, e);

            Cursor.Current = Cursors.Default;
        }

        private async Task HandleAddToPerson(object sender, EventArgs e)
        {
            if (await this.dbPersonRepo.PersonExist(this.personIDTextBox.Text))
            {
                Cursor.Current = Cursors.Default;

                await MessageBoxOutput($"Person with {this.personIDTextBox.Text} alredy exist, try again!", "Error");
                return;
            }

            if (this.customCheckDateTimePicker.Value == null)
            {
                Cursor.Current = Cursors.Default;

                await MessageBoxOutput("Custom Control date is incorrected, try again!", "Error");
                return;
            }

            var person = await this.dbPersonRepo.GetPersonByPersonalId(this.personIDTextBox.Text);

           person.CustomControls.Add(new DbCustomControl
           {
               DayOfVerification = this.customCheckDateTimePicker.Value,
               AdditionalInformationAboutTheControl = this.additionalInfoPersonTextBox.Text != null ? this.additionalInfoPersonTextBox.Text : null
           });

            int number = await dbPersonRepo.UpdatePerson(person);

            if (number > 0)
            {
                Cursor.Current = Cursors.Default;
                await MessageBoxOutput("Custom control Added to Person!", "Info");
            }
            else
            {
                Cursor.Current = Cursors.Default;
                await MessageBoxOutput("Somethign went wrong, try again!", "Error");
            }
        }

        private void AddToVehicleButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            _ = HandleAddToVehicle(sender, e);

            Cursor.Current = Cursors.Default;
        }

        private async Task HandleAddToVehicle(object sender, EventArgs e)
        {
            if (await this.dbVehicleRepo.VehicleExist(this.registrationNumberTextBox.Text))
            {
                Cursor.Current = Cursors.Default;
                await MessageBoxOutput($"Vehicle with number {this.registrationNumberTextBox.Text} alredy exist, try again!", "Error");
                return;
            }

            if (this.customCheckDateTimePicker.Value == null)
            {
                Cursor.Current = Cursors.Default;
                await MessageBoxOutput("Custom Control date is incorrected, try again!", "Error");
                return;
            }

            var vehicle = await this.dbVehicleRepo.GetVehicleByRegistrationNumber(this.registrationNumberTextBox.Text);

            vehicle.CustomControls.Add(new DbCustomControl
            {
                DayOfVerification = this.customCheckDateTimePicker.Value,
                AdditionalInformationAboutTheControl = this.additionalInfoVehicleTextBox.Text != null ? this.additionalInfoVehicleTextBox.Text : null
            });

            int number = await dbVehicleRepo.UpdateVehicle(vehicle);

            if (number > 0)
            {
                Cursor.Current = Cursors.Default;
                await MessageBoxOutput("Custom control Added to Vehicle!", "Info");
            }
            else
            {
                Cursor.Current = Cursors.Default;
                await MessageBoxOutput("Somethign went wrong, try again!", "Error");
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
