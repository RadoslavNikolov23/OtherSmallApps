namespace DEA_Program.Console.Pages
{
    using DEA_Program.Common.Helper;
    using DEA_Program.Data;
    using DEA_Program.Data.Model;
    using DEA_Program.Data.Repository;
    using System;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class PersonInfo : Form
    {
        private readonly Form previousForm;

        private readonly DEADatabaseContext context;

        private readonly DbPersonRepository dbPersonRepo;

        private DbUser loggedUser;

        public PersonInfo(DEADatabaseContext context, Form previous, DbUser loggedUser)
        {
            InitializeComponent();
            this.context = context;
            this.previousForm = previous;
            this.loggedUser = loggedUser;

            this.dbPersonRepo = new DbPersonRepository(this.context);
        }

        private async void findPersonButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            await HandlePersonId(sender, e);

            Cursor.Current = Cursors.Default;
        }

        private async Task HandlePersonId(object sender, EventArgs e)
        {
            this.infoPersonGroupBox.Visible = false;

            if (this.enteredPersonIdTextBox.Text == null
                || this.enteredPersonIdTextBox.Text.Length > 10)
            {
                Cursor.Current = Cursors.Default;
                await MessageBoxOutput("Person ID is incorrected, try again!", "Error");
                return;
            }

            try
            {
                DbPerson person = await this.dbPersonRepo.GetPersonByPersonalId(this.enteredPersonIdTextBox.Text);

                if (person != null)
                {
                    this.personFoundLabel.Text = $"Person found!";
                    this.infoPersonGroupBox.Visible = true;

                    await ShowPersonInfo(sender, e, person);
                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    Cursor.Current = Cursors.Default;
                    this.personFoundLabel.Text = $"Person not found! Try diffrent ID!";
                    this.infoPersonGroupBox.Visible = false;
                }
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                Logger.Log(ex, "Error in the HandlePersonId/PersonInfo.cs");
                await MessageBoxOutput("Something went work, try again!", "Error");
            }
        }

        private Task ShowPersonInfo(object sender, EventArgs e, DbPerson person)
        {
            if (person != null)
            {
                this.firstNameTextBox.Text = person.FirstName;
                this.lastNameTextBox.Text = person.LastName;
                this.birthDateTimePicker.Value = person.DayofBirth;
                this.countryNationalityTextBox.Text = person.CountryCode.ToString();
                this.additionalInfoTextBox.Text = person.AdditionInformation != null ? person.AdditionInformation : null;

                if (person.CustomControls != null)
                {
                    foreach (var customDate in person.CustomControls)
                    {
                        this.customsControlComboBox.Items.Add(customDate.DayOfVerification);
                    }
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
