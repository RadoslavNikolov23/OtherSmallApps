
namespace DEA_Program.Console.Pages
{
    partial class RegisterCustomControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.registerCustomControlGroupBox = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.additionalInfoTextBox = new System.Windows.Forms.TextBox();
            this.additionInfoLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.countryCodeVehicleBox = new System.Windows.Forms.ListBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.vehicleModellabel = new System.Windows.Forms.Label();
            this.registrationNumberTextBox = new System.Windows.Forms.TextBox();
            this.countyCodeVechileLabel = new System.Windows.Forms.Label();
            this.registratinNumberLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.countryCodePersonBox = new System.Windows.Forms.ListBox();
            this.birthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.personIDTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.countyCodePersonLabel = new System.Windows.Forms.Label();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.personIDLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.customControlDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.customControlLabel = new System.Windows.Forms.Label();
            this.addCustomControlButton = new System.Windows.Forms.Button();
            this.goBackButton = new System.Windows.Forms.Button();
            this.registerCustomControlGroupBox.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // registerCustomControlGroupBox
            // 
            this.registerCustomControlGroupBox.BackColor = System.Drawing.Color.LightBlue;
            this.registerCustomControlGroupBox.Controls.Add(this.panel3);
            this.registerCustomControlGroupBox.Controls.Add(this.panel2);
            this.registerCustomControlGroupBox.Controls.Add(this.panel1);
            this.registerCustomControlGroupBox.Controls.Add(this.customControlDateTimePicker);
            this.registerCustomControlGroupBox.Controls.Add(this.customControlLabel);
            this.registerCustomControlGroupBox.Controls.Add(this.addCustomControlButton);
            this.registerCustomControlGroupBox.Controls.Add(this.goBackButton);
            this.registerCustomControlGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerCustomControlGroupBox.Location = new System.Drawing.Point(29, 33);
            this.registerCustomControlGroupBox.Name = "registerCustomControlGroupBox";
            this.registerCustomControlGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.registerCustomControlGroupBox.Size = new System.Drawing.Size(933, 600);
            this.registerCustomControlGroupBox.TabIndex = 13;
            this.registerCustomControlGroupBox.TabStop = false;
            this.registerCustomControlGroupBox.Text = "Register a Custom Control";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.additionalInfoTextBox);
            this.panel3.Controls.Add(this.additionInfoLabel);
            this.panel3.Location = new System.Drawing.Point(453, 365);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(452, 219);
            this.panel3.TabIndex = 48;
            // 
            // additionalInfoTextBox
            // 
            this.additionalInfoTextBox.Location = new System.Drawing.Point(17, 49);
            this.additionalInfoTextBox.Multiline = true;
            this.additionalInfoTextBox.Name = "additionalInfoTextBox";
            this.additionalInfoTextBox.Size = new System.Drawing.Size(415, 155);
            this.additionalInfoTextBox.TabIndex = 10;
            // 
            // additionInfoLabel
            // 
            this.additionInfoLabel.AutoSize = true;
            this.additionInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.additionInfoLabel.Location = new System.Drawing.Point(83, 17);
            this.additionInfoLabel.Name = "additionInfoLabel";
            this.additionInfoLabel.Size = new System.Drawing.Size(267, 29);
            this.additionInfoLabel.TabIndex = 26;
            this.additionInfoLabel.Text = "Additional Information";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.countryCodeVehicleBox);
            this.panel2.Controls.Add(this.modelTextBox);
            this.panel2.Controls.Add(this.vehicleModellabel);
            this.panel2.Controls.Add(this.registrationNumberTextBox);
            this.panel2.Controls.Add(this.countyCodeVechileLabel);
            this.panel2.Controls.Add(this.registratinNumberLabel);
            this.panel2.Location = new System.Drawing.Point(453, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(453, 235);
            this.panel2.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 29);
            this.label2.TabIndex = 45;
            this.label2.Text = "Add a Vehicle";
            // 
            // countryCodeVehicleBox
            // 
            this.countryCodeVehicleBox.AllowDrop = true;
            this.countryCodeVehicleBox.FormattingEnabled = true;
            this.countryCodeVehicleBox.ItemHeight = 25;
            this.countryCodeVehicleBox.Location = new System.Drawing.Point(241, 173);
            this.countryCodeVehicleBox.Name = "countryCodeVehicleBox";
            this.countryCodeVehicleBox.Size = new System.Drawing.Size(178, 29);
            this.countryCodeVehicleBox.TabIndex = 9;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(221, 116);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(198, 30);
            this.modelTextBox.TabIndex = 8;
            // 
            // vehicleModellabel
            // 
            this.vehicleModellabel.AutoSize = true;
            this.vehicleModellabel.Location = new System.Drawing.Point(16, 121);
            this.vehicleModellabel.Name = "vehicleModellabel";
            this.vehicleModellabel.Size = new System.Drawing.Size(132, 25);
            this.vehicleModellabel.TabIndex = 42;
            this.vehicleModellabel.Text = "Model vehicle";
            // 
            // registrationNumberTextBox
            // 
            this.registrationNumberTextBox.Location = new System.Drawing.Point(221, 59);
            this.registrationNumberTextBox.Name = "registrationNumberTextBox";
            this.registrationNumberTextBox.Size = new System.Drawing.Size(198, 30);
            this.registrationNumberTextBox.TabIndex = 7;
            // 
            // countyCodeVechileLabel
            // 
            this.countyCodeVechileLabel.AutoSize = true;
            this.countyCodeVechileLabel.Location = new System.Drawing.Point(16, 177);
            this.countyCodeVechileLabel.Name = "countyCodeVechileLabel";
            this.countyCodeVechileLabel.Size = new System.Drawing.Size(219, 25);
            this.countyCodeVechileLabel.TabIndex = 35;
            this.countyCodeVechileLabel.Text = "County Code of Vehicle";
            // 
            // registratinNumberLabel
            // 
            this.registratinNumberLabel.AutoSize = true;
            this.registratinNumberLabel.Location = new System.Drawing.Point(16, 62);
            this.registratinNumberLabel.Name = "registratinNumberLabel";
            this.registratinNumberLabel.Size = new System.Drawing.Size(188, 25);
            this.registratinNumberLabel.TabIndex = 33;
            this.registratinNumberLabel.Text = "Registration Number";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.countryCodePersonBox);
            this.panel1.Controls.Add(this.birthDateTimePicker);
            this.panel1.Controls.Add(this.personIDTextBox);
            this.panel1.Controls.Add(this.lastNameTextBox);
            this.panel1.Controls.Add(this.firstNameTextBox);
            this.panel1.Controls.Add(this.countyCodePersonLabel);
            this.panel1.Controls.Add(this.dateOfBirthLabel);
            this.panel1.Controls.Add(this.personIDLabel);
            this.panel1.Controls.Add(this.lastNameLabel);
            this.panel1.Controls.Add(this.firstNameLabel);
            this.panel1.Location = new System.Drawing.Point(13, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 356);
            this.panel1.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "Add a Person";
            // 
            // countryCodePersonBox
            // 
            this.countryCodePersonBox.AllowDrop = true;
            this.countryCodePersonBox.FormattingEnabled = true;
            this.countryCodePersonBox.ItemHeight = 25;
            this.countryCodePersonBox.Location = new System.Drawing.Point(242, 291);
            this.countryCodePersonBox.Name = "countryCodePersonBox";
            this.countryCodePersonBox.Size = new System.Drawing.Size(128, 29);
            this.countryCodePersonBox.TabIndex = 6;
            // 
            // birthDateTimePicker
            // 
            this.birthDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.birthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthDateTimePicker.Location = new System.Drawing.Point(157, 234);
            this.birthDateTimePicker.Name = "birthDateTimePicker";
            this.birthDateTimePicker.Size = new System.Drawing.Size(213, 30);
            this.birthDateTimePicker.TabIndex = 5;
            // 
            // personIDTextBox
            // 
            this.personIDTextBox.Location = new System.Drawing.Point(157, 175);
            this.personIDTextBox.Name = "personIDTextBox";
            this.personIDTextBox.Size = new System.Drawing.Size(213, 30);
            this.personIDTextBox.TabIndex = 4;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(157, 120);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(213, 30);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(157, 62);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(213, 30);
            this.firstNameTextBox.TabIndex = 2;
            // 
            // countyCodePersonLabel
            // 
            this.countyCodePersonLabel.AutoSize = true;
            this.countyCodePersonLabel.Location = new System.Drawing.Point(20, 291);
            this.countyCodePersonLabel.Name = "countyCodePersonLabel";
            this.countyCodePersonLabel.Size = new System.Drawing.Size(216, 25);
            this.countyCodePersonLabel.TabIndex = 21;
            this.countyCodePersonLabel.Text = "County Code of Person";
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Location = new System.Drawing.Point(20, 234);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(118, 25);
            this.dateOfBirthLabel.TabIndex = 20;
            this.dateOfBirthLabel.Text = "Date of Birth";
            // 
            // personIDLabel
            // 
            this.personIDLabel.AutoSize = true;
            this.personIDLabel.Location = new System.Drawing.Point(20, 178);
            this.personIDLabel.Name = "personIDLabel";
            this.personIDLabel.Size = new System.Drawing.Size(98, 25);
            this.personIDLabel.TabIndex = 19;
            this.personIDLabel.Text = "Person ID";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(20, 120);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(106, 25);
            this.lastNameLabel.TabIndex = 18;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(20, 65);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(106, 25);
            this.firstNameLabel.TabIndex = 17;
            this.firstNameLabel.Text = "First Name";
            // 
            // customControlDateTimePicker
            // 
            this.customControlDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customControlDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.customControlDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.customControlDateTimePicker.Location = new System.Drawing.Point(236, 56);
            this.customControlDateTimePicker.Name = "customControlDateTimePicker";
            this.customControlDateTimePicker.Size = new System.Drawing.Size(177, 30);
            this.customControlDateTimePicker.TabIndex = 1;
            // 
            // customControlLabel
            // 
            this.customControlLabel.AutoSize = true;
            this.customControlLabel.Location = new System.Drawing.Point(10, 61);
            this.customControlLabel.Name = "customControlLabel";
            this.customControlLabel.Size = new System.Drawing.Size(194, 25);
            this.customControlLabel.TabIndex = 29;
            this.customControlLabel.Text = "Custom Control Date";
            // 
            // addCustomControlButton
            // 
            this.addCustomControlButton.BackColor = System.Drawing.Color.AliceBlue;
            this.addCustomControlButton.Location = new System.Drawing.Point(39, 505);
            this.addCustomControlButton.Name = "addCustomControlButton";
            this.addCustomControlButton.Size = new System.Drawing.Size(304, 65);
            this.addCustomControlButton.TabIndex = 11;
            this.addCustomControlButton.Text = "Add Custom Control";
            this.addCustomControlButton.UseVisualStyleBackColor = false;
            this.addCustomControlButton.Click += new System.EventHandler(this.addCustomControlButton_Click);
            // 
            // goBackButton
            // 
            this.goBackButton.BackColor = System.Drawing.Color.AliceBlue;
            this.goBackButton.Location = new System.Drawing.Point(743, 29);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(143, 40);
            this.goBackButton.TabIndex = 12;
            this.goBackButton.Text = "Go Back";
            this.goBackButton.UseVisualStyleBackColor = false;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // RegisterCustomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 661);
            this.Controls.Add(this.registerCustomControlGroupBox);
            this.Name = "RegisterCustomControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterCustomCheck";
            this.registerCustomControlGroupBox.ResumeLayout(false);
            this.registerCustomControlGroupBox.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox registerCustomControlGroupBox;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.ListBox countryCodePersonBox;
        private System.Windows.Forms.DateTimePicker customControlDateTimePicker;
        private System.Windows.Forms.Label customControlLabel;
        private System.Windows.Forms.Button addCustomControlButton;
        private System.Windows.Forms.TextBox additionalInfoTextBox;
        private System.Windows.Forms.Label additionInfoLabel;
        private System.Windows.Forms.DateTimePicker birthDateTimePicker;
        private System.Windows.Forms.TextBox personIDTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label countyCodePersonLabel;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.Label personIDLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox countryCodeVehicleBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.Label vehicleModellabel;
        private System.Windows.Forms.TextBox registrationNumberTextBox;
        private System.Windows.Forms.Label countyCodeVechileLabel;
        private System.Windows.Forms.Label registratinNumberLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}