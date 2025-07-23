namespace DEA_Program.Console.Pages
{
    using DEA_Program.Data;
    using DEA_Program.Data.Model;
    using DEA_Program.Common.Enums;
    using DEA_Program.Data.Repository;
    using System;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class RegisterPerson : Form
    {
        private readonly Form previousForm;
        private readonly DEADatabaseContext context;
        private readonly DbPersonRepository dbPersonRepo;

        private DbUser loggedUser;

        public RegisterPerson(DEADatabaseContext context, Form previous, DbUser loggedUser)
        {
            InitializeComponent();
            this.context = context;
            this.previousForm = previous;
            this.loggedUser = loggedUser;

            this.dbPersonRepo = new DbPersonRepository(this.context);

            this.countryCodeListBox.DataSource = Enum.GetValues(typeof(CountryCode));
            this.countryCodeListBox.SelectionMode = SelectionMode.One;
        }

        private void addPersonButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            _ = HandleAddPerson(sender, e);

            Cursor.Current = Cursors.Default;
        }

        private async Task HandleAddPerson(object sender, EventArgs e)
        {
            if (this.firstNameTextBox.Text == null
                || this.firstNameTextBox.Text.Length > 120
                || this.lastNameTextBox.Text == null
                || this.lastNameTextBox.Text.Length > 120)
            {
                Cursor.Current = Cursors.Default;
                await MessageBoxOutput("Person First or Last name is incorrected, try again!", "Error");
                return;
            }

            if (this.personIDTextBox.Text == null
               || this.personIDTextBox.Text.Length > 10)
            {
                Cursor.Current = Cursors.Default;
                await MessageBoxOutput("Person ID is incorrected, try again!", "Error");
                return;
            }

            if (this.birthDateTimePicker.Value == null)
            {
                Cursor.Current = Cursors.Default;
                await MessageBoxOutput("Person birthday is incorrected, try again!", "Error");
                return;
            }

            if (!(this.countryCodeListBox.SelectedItem is CountryCode selectedCountryCode))
            {
                Cursor.Current = Cursors.Default;
                await MessageBoxOutput("Person Country of Code is incorrected, try again!", "Error");
                return;
            }

            if (await this.dbPersonRepo.PersonExist(personIDTextBox.Text))
            {
                Cursor.Current = Cursors.Default;
                await MessageBoxOutput($"Person with {personIDTextBox.Text} alredy exist, try again!", "Error");
                return;
            }


            if (this.customCheckDateTimePicker.Value == null)
            {
                Cursor.Current = Cursors.Default;
                await MessageBoxOutput("Custom Control date is incorrected, try again!", "Error");
                return;
            }

            DbPerson person = new DbPerson
            {
                FirstName = this.firstNameTextBox.Text,
                LastName = this.lastNameTextBox.Text,
                PersonalId = this.personIDTextBox.Text,
                DayofBirth = this.birthDateTimePicker.Value,
                CountryCode = selectedCountryCode,
                AdditionInformation = this.additionalInfoTextBox.Text != null ? this.additionalInfoTextBox.Text : null
            };

            person.CustomControls.Add(new DbCustomControl
            {
                DayOfVerification = this.customCheckDateTimePicker.Value,
                AdditionalInformationAboutTheControl = this.additionalInfoTextBox.Text != null ? this.additionalInfoTextBox.Text : null
            });

            int number = await dbPersonRepo.AddPerson(person);

            if (number > 0)
            {
                Cursor.Current = Cursors.Default;
                await MessageBoxOutput("Person saved successufly", "Info");
                this.firstNameTextBox.Text = "";
                this.lastNameTextBox.Text = "";
                this.personIDTextBox.Text = "";
                this.birthDateTimePicker.Value = default;
                this.customCheckDateTimePicker.Value = default;
                this.additionalInfoTextBox.Text = "";
            }
            else
            {
                Cursor.Current = Cursors.Default;
                await MessageBoxOutput("Person wasn't saved, try again!", "Error");

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
