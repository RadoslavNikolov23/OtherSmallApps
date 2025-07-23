namespace DEA_Program.Console.Pages
{
    using DEA_Program.Common.Helper;
    using DEA_Program.Data;
    using DEA_Program.Data.Model;
    using DEA_Program.Data.Repository;
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.Text;

    public partial class CustomControlInfo : Form
    {
        private readonly DEADatabaseContext context;
        private readonly Form previousForm;
        private readonly DbCustomControlRepository dbCustomControlRepo;

        private DbUser loggedUser;

        public CustomControlInfo(DEADatabaseContext context, Form previous, DbUser loggedUser)
        {
            InitializeComponent();
            this.context = context;
            this.previousForm = previous;
            this.loggedUser = loggedUser;

            this.dbCustomControlRepo = new DbCustomControlRepository(this.context);


            //this.foundCustomControlsListView.Columns.AddRange(new ColumnHeader[] 
            //                                                    {
            //                                                        this.columnHeaderDate,
            //                                                        this.columnHeaderPerson,
            //                                                        this.columnHeaderPersonID,
            //                                                        this.columnHeaderVehicle,
            //                                                        this.columnHeaderAdditionInfo
            //                                                    });
            //  this.foundCustomControlsListView.MouseClick += new MouseEventHandler(foundCustomControlsListView_MouseClick);
        }

        private async void findCustomControlsButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            await HandleCustomControlInfo(sender, e);

            Cursor.Current = Cursors.Default;


        }

        private async Task HandleCustomControlInfo(object sender, EventArgs e)
        {
            this.infoallCustomControlsGroupBox.Visible = false;

            if (this.customCheckDateTimePicker.Value == null)
            {
                Cursor.Current = Cursors.Default;
                await MessageBoxOutput("Person ID is incorrected, try again!", "Error");
                return;
            }

            try
            {
                var customControlsList = await this.dbCustomControlRepo.GetAllCustomControlWithSpecificDate(this.customCheckDateTimePicker.Value);

                if (customControlsList == null && customControlsList.Count == 0)
                {
                    Cursor.Current = Cursors.Default;
                    this.foundTextLabel.Text = $"No Custom Controls found on this date! Try diffrent date!";
                    this.infoallCustomControlsGroupBox.Visible = false;
                }
                else
                {
                    this.foundTextLabel.Text = $"Found {customControlsList.Count} Custom Controls!";
                    this.infoallCustomControlsGroupBox.Visible = true;

                    await ShowAlLCustomControlInfo(sender, e, customControlsList);
                    Cursor.Current = Cursors.Default;
                }
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                Logger.Log(ex, "Error in the CustomControlInfo.cs");
                await MessageBoxOutput("Something went work, try again!", "Error");

            }
        }

        private async Task ShowAlLCustomControlInfo(object sender, EventArgs e, IList<DbCustomControl> customControlsList)
        {
            await Task.Delay(10);
            foundCustomControlsListView.Clear();
            foundCustomControlsListView.View = View.Details;

            foundCustomControlsListView.Columns.Add("Date");
            foundCustomControlsListView.Columns.Add("Person");
            foundCustomControlsListView.Columns.Add("Person ID");
            foundCustomControlsListView.Columns.Add("Vehicle");
            foundCustomControlsListView.Columns.Add("Addition information");

            foreach (var customControl in customControlsList)
            {
                var listItemCC = new ListViewItem(customControl.DayOfVerification.ToShortDateString());

                if(customControl.Person != null)
                {
                    listItemCC.SubItems.Add($"{customControl.Person.FirstName} {customControl.Person.LastName}");
                    listItemCC.SubItems.Add(customControl.Person.PersonalId);
                }
                else
                {
                    listItemCC.SubItems.Add("");
                    listItemCC.SubItems.Add("");
                }


                if (customControl.Person.Vehicles.Count > 0 || customControl.Person.Vehicles!= null)
                {
                   // StringBuilder sb = new StringBuilder();

                    //var vehicle = customControl.Vehicle;


                    var vehicleToPerson = customControl.Person.Vehicles.FirstOrDefault(v => v.RegistrationNumber == customControl.Vehicle.RegistrationNumber);

                    if(vehicleToPerson!=null)
                        listItemCC.SubItems.Add($"{ vehicleToPerson.RegistrationNumber} { vehicleToPerson.Model}");
                    else 
                        listItemCC.SubItems.Add("");
                    //foreach (var vehicle in customControl.Person.Vehicles.Select(v=>v.CustomControls.Where(cc=>cc.DayOfVerification== customControl.DayOfVerification))
                    //{
                    //    sb.AppendLine($"{vehicle.RegistrationNumber} {vehicle.Model} \n");
                    //}

                    listItemCC.SubItems.Add(sb.ToString().TrimEnd());
                }
                else
                 {
                    listItemCC.SubItems.Add("");
                }

                string additionInfo = string.IsNullOrEmpty(customControl.AdditionalInformationAboutTheControl) ? "" : customControl.AdditionalInformationAboutTheControl;
                listItemCC.SubItems.Add(additionInfo);

                foundCustomControlsListView.Items.Add(listItemCC);

                //-----------Mouse clicked does not work try something else!!!!-------
                //Original code for the mouse click
                //string additionInfo = string.IsNullOrEmpty(customControl.AdditionalInformationAboutTheControl) ? "" : "Info View";
                //listItemCC.SubItems.Add(additionInfo);
                //listItemCC.Tag = customControl.AdditionalInformationAboutTheControl;

                //foundCustomControlsListView.Items.Add(listItemCC);

                foreach (ColumnHeader column in foundCustomControlsListView.Columns)
                {
                    column.Width = -2; // -2 means auto size to content
                }
            }
        }

        private async void foundCustomControlsListView_MouseClick(object sender, MouseEventArgs e)
        {
            // Get the clicked item and subitem
            ListViewHitTestInfo hit = foundCustomControlsListView.HitTest(e.Location);
            ListViewItem item = hit.Item;
            ListViewItem.ListViewSubItem subItem = hit.SubItem;

            // Make sure something was clicked
            if (item != null && subItem != null)
            {
                int infoColumnIndex = 6; // Change this to your actual "Info" column index

                // Check if the clicked subitem is in the "Info" column
                if (item.SubItems.IndexOf(subItem) == infoColumnIndex)
                {
                    // Get the additional info from Tag
                    string additionalInfo = item.Tag.ToString();

                    if (!string.IsNullOrEmpty(additionalInfo))
                    {
                        Cursor.Current = Cursors.Default;
                        await MessageBoxOutput(additionalInfo, "Additional Info");
                    }
                    else
                    {
                        Cursor.Current = Cursors.Default;
                       await MessageBoxOutput("No additional information available.", "Additional Info");
                    }
                }
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
