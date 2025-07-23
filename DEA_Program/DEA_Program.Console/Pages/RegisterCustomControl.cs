namespace DEA_Program.Console.Pages
{
    using DEA_Program.Common.Enums;
    using DEA_Program.Common.Helper;
    using DEA_Program.Data;
    using DEA_Program.Data.Model;
    using DEA_Program.Data.Repository;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class RegisterCustomControl : Form
    {
        private readonly DEADatabaseContext context;
        private readonly Form previousForm;
        private readonly DbVehicleRepository dbVehicleRepo;
        private readonly DbPersonRepository dbPersonRepo;

        private DbUser loggedUser;

        public RegisterCustomControl(DEADatabaseContext context, Form previous, DbUser loggedUser)
        {
            InitializeComponent();
            this.context = context;
            this.previousForm = previous;
            this.loggedUser = loggedUser;

            this.dbVehicleRepo = new DbVehicleRepository(this.context);
            this.dbPersonRepo = new DbPersonRepository(this.context);

            this.countryCodePersonBox.DataSource = Enum.GetValues(typeof(CountryCode));
            this.countryCodePersonBox.SelectionMode = SelectionMode.One;

            this.countryCodeVehicleBox.DataSource = Enum.GetValues(typeof(CountryCode));
            this.countryCodeVehicleBox.SelectionMode = SelectionMode.One;
        }

        private async void addCustomControlButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            await HandleAddCustomControl(sender, e);
            Cursor.Current = Cursors.Default;
        }

        private async Task HandleAddCustomControl(object sender, EventArgs e)
        {
            bool conditionValidations = await CheckAllValidations(sender, e);

            if (conditionValidations)
            {
                bool isCountryCodePerson = Enum.TryParse(this.countryCodePersonBox.SelectedItem.ToString(),
                                                         out CountryCode selectedPersonCountryCode);

                if (!isCountryCodePerson)
                {
                    Cursor.Current = Cursors.Default;
                    await MessageBoxOutput("Person Country of Code is incorrected, try again!", "Error");
                    return;
                }

                bool isCountryCodeVehicle = Enum.TryParse(this.countryCodeVehicleBox.SelectedItem.ToString(),
                                                          out CountryCode selectedVehicleCountryCode);

                if (!isCountryCodeVehicle)
                {
                    Cursor.Current = Cursors.Default;
                    await MessageBoxOutput("Vehicle Country of Code is incorrected, try again!", "Error");
                    return;
                }

                bool isSuccessfullyAdded = false;

                if (await this.dbPersonRepo.PersonExist(personIDTextBox.Text))
                {
                    var personToUpdate = await this.dbPersonRepo.GetPersonByPersonalId(this.personIDTextBox.Text);

                    if (personToUpdate != null)
                    {
                        try
                        {
                            isSuccessfullyAdded = await UpdateExistingPerson(sender, e, personToUpdate, selectedVehicleCountryCode);
                        }
                        catch (Exception ex)
                        {
                            Cursor.Current = Cursors.Default;
                            Logger.Log(ex, "Error in the UpdateExistingPerson/RegisterCustomControl.cs");
                            await MessageBoxOutput("Something went work, try again!", "Error");
                            return;
                        }
                    }
                    else
                    {
                        Cursor.Current = Cursors.Default;
                        await MessageBoxOutput("Something went wrong, try again!", "Error");
                        return;
                    }
                }
                else
                {
                    try
                    {
                        isSuccessfullyAdded = await AddNewPersonAndVehicle(sender, e, selectedPersonCountryCode, selectedVehicleCountryCode);
                    }
                    catch (Exception ex)
                    {
                        Cursor.Current = Cursors.Default;
                        Logger.Log(ex, "Error in the AddNewPersonAndVehicle/RegisterCustomControl.cs");
                        await MessageBoxOutput("Something went work, try again!", "Error");
                        return;
                    }
                }

                if (isSuccessfullyAdded)
                {
                    Cursor.Current = Cursors.Default;
                    await MessageBoxOutput("Person saved successufly", "Info");
                    this.customControlDateTimePicker.Value = DateTime.Now;

                    this.firstNameTextBox.Text = "";
                    this.lastNameTextBox.Text = "";
                    this.personIDTextBox.Text = "";
                    this.birthDateTimePicker.Value =  DateTime.Now;

                    this.registrationNumberTextBox.Text = "";
                    this.modelTextBox.Text = "";

                    this.additionalInfoTextBox.Text = "";
                }
                else
                {
                    Cursor.Current = Cursors.Default;
                    await MessageBoxOutput("Custom control wasn't saved, try again!", "Error");
                }
            }
            else
            {
                Cursor.Current = Cursors.Default;
                return;
            }
        }

        private async Task<bool> CheckAllValidations(object sender, EventArgs e)
        {
            if (this.customControlDateTimePicker.Value == null)
            {
                Cursor.Current = Cursors.Default;
                await MessageBoxOutput("Custom Control date is incorrected, try again!", "Error");
                return false;
            }
            else if (this.firstNameTextBox.Text == null
               || this.firstNameTextBox.Text.Length > 120
               || this.lastNameTextBox.Text == null
               || this.lastNameTextBox.Text.Length > 120)
            {
                Cursor.Current = Cursors.Default;
                await MessageBoxOutput("Person First or Last name is incorrected, try again!", "Error");
                return false;
            }
            else if (this.personIDTextBox.Text == null
               || this.personIDTextBox.Text.Length > 10)
            {
                Cursor.Current = Cursors.Default;
                await MessageBoxOutput("Person ID is incorrected (max length 10 symbols), try again!", "Error");
                return false;
            }
            else if (this.birthDateTimePicker.Value == null)
            {
                Cursor.Current = Cursors.Default;
                await MessageBoxOutput("Person birthday is incorrected, try again!", "Error");
                return false;
            }
            else if (this.registrationNumberTextBox.Text == null
                || this.registrationNumberTextBox.Text.Length > 10)
            {
                Cursor.Current = Cursors.Default;
                await MessageBoxOutput("Vehicle registration number is incorrected, try again!", "Error");
                return false;
            }
            else if (this.modelTextBox.Text == null
               || this.modelTextBox.Text.Length >50)
            {
                Cursor.Current = Cursors.Default;
                await MessageBoxOutput("Vehicle model is incorrected (max length 10 symbols), try again!", "Error");
                return false;
            }
            else
            {
                return true;
            }
        }

        private async Task<bool> UpdateExistingPerson(object sender, EventArgs e, DbPerson personToUpdate, CountryCode selectedVehicleCountryCode)
        {
            DbCustomControl customControl = new DbCustomControl
            {
                DayOfVerification = this.customControlDateTimePicker.Value,
                AdditionalInformationAboutTheControl = this.additionalInfoTextBox.Text != null ? this.additionalInfoTextBox.Text : null
            };

            var vehicle = await this.dbVehicleRepo.GetVehicleByRegistrationNumber(this.registrationNumberTextBox.Text);

            if(vehicle == null)
            {
                vehicle = new DbVehicle
                            {
                                RegistrationNumber = this.registrationNumberTextBox.Text,
                                Model = this.modelTextBox.Text,
                                CountryCode = selectedVehicleCountryCode,
                                AdditionalInformationAboutTheVehicle = this.additionalInfoTextBox.Text != null ? this.additionalInfoTextBox.Text : null
                            };
            }

            personToUpdate.Vehicles.Add(vehicle);
            personToUpdate.CustomControls.Add(customControl);

            int number = await dbPersonRepo.UpdatePerson(personToUpdate);

            return number > 0 ? true : false;

            //if (await this.dbVehicleRepo.VehicleExist(this.registrationNumberTextBox.Text))
            //{
            //    var vehicleToUpdate = await this.dbVehicleRepo.GetVehicleByRegistrationNumber(this.registrationNumberTextBox.Text);

            //    if (vehicleToUpdate == null)
            //    {

            //    if (personToUpdate.Vehicles.Any(v => v.RegistrationNumber == this.registrationNumberTextBox.Text))
            //    {
            //        vehicleToUpdate.CustomControls.Add(customControl);
            //    }
            //    else
            //    {
            //        DbVehicle vehicle = new DbVehicle
            //        {
            //            RegistrationNumber = this.registrationNumberTextBox.Text,
            //            Model = this.modelTextBox.Text,
            //            CountryCode = selectedVehicleCountryCode,
            //            AdditionalInformationAboutTheVehicle = this.additionalInfoTextBox.Text != null ? this.additionalInfoTextBox.Text : null
            //        };

            //        vehicle.CustomControls.Add(customControl); //Check if the first add will catch the second of the vehicle also
            //    }
            //}
            //}
            //else
            //{
            //    DbVehicle vehicle = new DbVehicle
            //    {
            //        RegistrationNumber = this.registrationNumberTextBox.Text,
            //        Model = this.modelTextBox.Text,
            //        CountryCode = selectedVehicleCountryCode,
            //        AdditionalInformationAboutTheVehicle = this.additionalInfoTextBox.Text != null ? this.additionalInfoTextBox.Text : null
            //    };

            //    vehicle.CustomControls.Add(customControl); //Check if the first add will catch the second of the vehicle also
            //    personToUpdate.Vehicles.Add(vehicle);
            //}

            //personToUpdate.CustomControls.Add(customControl);

            //int number = await dbPersonRepo.UpdatePerson(personToUpdate);

            //return number > 0 ? true : false;
        }

        private async Task<bool> AddNewPersonAndVehicle(object sender, EventArgs e, CountryCode selectedPersonCountryCode, CountryCode selectedVehicleCountryCode)
        {
            DbPerson personToAdd = new DbPerson
            {
                FirstName = this.firstNameTextBox.Text,
                LastName = this.lastNameTextBox.Text,
                PersonalId = this.personIDTextBox.Text,
                DayofBirth = this.birthDateTimePicker.Value,
                CountryCode = selectedPersonCountryCode,
                AdditionInformation = this.additionalInfoTextBox.Text != null ? this.additionalInfoTextBox.Text : null
            };

            DbCustomControl customControl = new DbCustomControl
            {
                DayOfVerification = this.customControlDateTimePicker.Value,
                AdditionalInformationAboutTheControl = this.additionalInfoTextBox.Text != null ? this.additionalInfoTextBox.Text : null
            };

            var vehicle = await this.dbVehicleRepo.GetVehicleByRegistrationNumber(this.registrationNumberTextBox.Text);

            if (vehicle == null)
            {
                vehicle = new DbVehicle
                {
                    RegistrationNumber = this.registrationNumberTextBox.Text,
                    Model = this.modelTextBox.Text,
                    CountryCode = selectedVehicleCountryCode,
                    AdditionalInformationAboutTheVehicle = this.additionalInfoTextBox.Text != null ? this.additionalInfoTextBox.Text : null
                };
            }

            personToAdd.Vehicles.Add(vehicle);
            personToAdd.CustomControls.Add(customControl);

            int number = await dbPersonRepo.AddPerson(personToAdd);

            return number > 0 ? true : false;

            //DbVehicle vehicle = null;

            //if (await this.dbVehicleRepo.VehicleExist(this.registrationNumberTextBox.Text))
            //{
            //    vehicle = await this.dbVehicleRepo.GetVehicleByRegistrationNumber(this.registrationNumberTextBox.Text);

            //    if (vehicle == null)
            //    {
            //        Cursor.Current = Cursors.Default;
            //        await MessageBoxOutput($"Something went wrong with the car information, try again!", "Error");
            //        return false;
            //    }

            //}
            //else
            //{
            //    vehicle = new DbVehicle
            //    {
            //        RegistrationNumber = this.registrationNumberTextBox.Text,
            //        Model = this.modelTextBox.Text,
            //        CountryCode = selectedVehicleCountryCode,
            //        AdditionalInformationAboutTheVehicle = this.additionalInfoTextBox.Text != null ? this.additionalInfoTextBox.Text : null
            //    };

            //}

            //DbCustomControl customControl = new DbCustomControl
            //{
            //    DayOfVerification = this.customControlDateTimePicker.Value,
            //    AdditionalInformationAboutTheControl = this.additionalInfoTextBox.Text != null ? this.additionalInfoTextBox.Text : null
            //};

            //person.Vehicles.Add(vehicle);

            //person.CustomControls.Add(customControl);
            ////vehicle.CustomControls.Add(customControl); //Check if the first add will catch the second of the vehicle also

            //int number = await dbPersonRepo.AddPerson(person);

            //return number > 0 ? true : false;
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
