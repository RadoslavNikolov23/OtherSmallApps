
namespace DEA_Program.Console.Pages
{
    partial class RegisterPerson
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
            this.registerPersonGroupBox = new System.Windows.Forms.GroupBox();
            this.countryCodeListBox = new System.Windows.Forms.ListBox();
            this.goBackButton = new System.Windows.Forms.Button();
            this.customCheckDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.customCheckLabel = new System.Windows.Forms.Label();
            this.addPersonButton = new System.Windows.Forms.Button();
            this.additionalInfoTextBox = new System.Windows.Forms.TextBox();
            this.additionInfoLabel = new System.Windows.Forms.Label();
            this.birthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.personIDTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.countyOfNationalityLabel = new System.Windows.Forms.Label();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.personIDLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.registerPersonGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // registerPersonGroupBox
            // 
            this.registerPersonGroupBox.BackColor = System.Drawing.Color.LightBlue;
            this.registerPersonGroupBox.Controls.Add(this.countryCodeListBox);
            this.registerPersonGroupBox.Controls.Add(this.goBackButton);
            this.registerPersonGroupBox.Controls.Add(this.customCheckDateTimePicker);
            this.registerPersonGroupBox.Controls.Add(this.customCheckLabel);
            this.registerPersonGroupBox.Controls.Add(this.addPersonButton);
            this.registerPersonGroupBox.Controls.Add(this.additionalInfoTextBox);
            this.registerPersonGroupBox.Controls.Add(this.additionInfoLabel);
            this.registerPersonGroupBox.Controls.Add(this.birthDateTimePicker);
            this.registerPersonGroupBox.Controls.Add(this.personIDTextBox);
            this.registerPersonGroupBox.Controls.Add(this.lastNameTextBox);
            this.registerPersonGroupBox.Controls.Add(this.firstNameTextBox);
            this.registerPersonGroupBox.Controls.Add(this.countyOfNationalityLabel);
            this.registerPersonGroupBox.Controls.Add(this.dateOfBirthLabel);
            this.registerPersonGroupBox.Controls.Add(this.personIDLabel);
            this.registerPersonGroupBox.Controls.Add(this.lastNameLabel);
            this.registerPersonGroupBox.Controls.Add(this.firstNameLabel);
            this.registerPersonGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerPersonGroupBox.Location = new System.Drawing.Point(83, 76);
            this.registerPersonGroupBox.Name = "registerPersonGroupBox";
            this.registerPersonGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.registerPersonGroupBox.Size = new System.Drawing.Size(878, 487);
            this.registerPersonGroupBox.TabIndex = 4;
            this.registerPersonGroupBox.TabStop = false;
            this.registerPersonGroupBox.Text = "Register Person";
            // 
            // countryCodeListBox
            // 
            this.countryCodeListBox.FormattingEnabled = true;
            this.countryCodeListBox.ItemHeight = 25;
            this.countryCodeListBox.Location = new System.Drawing.Point(230, 339);
            this.countryCodeListBox.Name = "countryCodeListBox";
            this.countryCodeListBox.Size = new System.Drawing.Size(133, 29);
            this.countryCodeListBox.TabIndex = 16;
            // 
            // goBackButton
            // 
            this.goBackButton.BackColor = System.Drawing.Color.AliceBlue;
            this.goBackButton.Location = new System.Drawing.Point(714, 29);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(143, 40);
            this.goBackButton.TabIndex = 15;
            this.goBackButton.Text = "Go Back";
            this.goBackButton.UseVisualStyleBackColor = false;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // customCheckDateTimePicker
            // 
            this.customCheckDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customCheckDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.customCheckDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.customCheckDateTimePicker.Location = new System.Drawing.Point(187, 402);
            this.customCheckDateTimePicker.Name = "customCheckDateTimePicker";
            this.customCheckDateTimePicker.Size = new System.Drawing.Size(170, 30);
            this.customCheckDateTimePicker.TabIndex = 14;
            // 
            // customCheckLabel
            // 
            this.customCheckLabel.AutoSize = true;
            this.customCheckLabel.Location = new System.Drawing.Point(28, 402);
            this.customCheckLabel.Name = "customCheckLabel";
            this.customCheckLabel.Size = new System.Drawing.Size(142, 25);
            this.customCheckLabel.TabIndex = 13;
            this.customCheckLabel.Text = "Custom Check";
            // 
            // addPersonButton
            // 
            this.addPersonButton.BackColor = System.Drawing.Color.AliceBlue;
            this.addPersonButton.Location = new System.Drawing.Point(455, 393);
            this.addPersonButton.Name = "addPersonButton";
            this.addPersonButton.Size = new System.Drawing.Size(283, 42);
            this.addPersonButton.TabIndex = 12;
            this.addPersonButton.Text = "Add Person";
            this.addPersonButton.UseVisualStyleBackColor = false;
            this.addPersonButton.Click += new System.EventHandler(this.addPersonButton_Click);
            // 
            // additionalInfoTextBox
            // 
            this.additionalInfoTextBox.Location = new System.Drawing.Point(455, 129);
            this.additionalInfoTextBox.Multiline = true;
            this.additionalInfoTextBox.Name = "additionalInfoTextBox";
            this.additionalInfoTextBox.Size = new System.Drawing.Size(284, 239);
            this.additionalInfoTextBox.TabIndex = 11;
            // 
            // additionInfoLabel
            // 
            this.additionInfoLabel.AutoSize = true;
            this.additionInfoLabel.Location = new System.Drawing.Point(485, 94);
            this.additionInfoLabel.Name = "additionInfoLabel";
            this.additionInfoLabel.Size = new System.Drawing.Size(199, 25);
            this.additionInfoLabel.TabIndex = 10;
            this.additionInfoLabel.Text = "Additional Information";
            // 
            // birthDateTimePicker
            // 
            this.birthDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.birthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthDateTimePicker.Location = new System.Drawing.Point(165, 282);
            this.birthDateTimePicker.Name = "birthDateTimePicker";
            this.birthDateTimePicker.Size = new System.Drawing.Size(198, 30);
            this.birthDateTimePicker.TabIndex = 8;
            // 
            // personIDTextBox
            // 
            this.personIDTextBox.Location = new System.Drawing.Point(165, 223);
            this.personIDTextBox.Name = "personIDTextBox";
            this.personIDTextBox.Size = new System.Drawing.Size(198, 30);
            this.personIDTextBox.TabIndex = 7;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(165, 168);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(198, 30);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(165, 110);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(198, 30);
            this.firstNameTextBox.TabIndex = 5;
            // 
            // countyOfNationalityLabel
            // 
            this.countyOfNationalityLabel.AutoSize = true;
            this.countyOfNationalityLabel.Location = new System.Drawing.Point(28, 339);
            this.countyOfNationalityLabel.Name = "countyOfNationalityLabel";
            this.countyOfNationalityLabel.Size = new System.Drawing.Size(196, 25);
            this.countyOfNationalityLabel.TabIndex = 4;
            this.countyOfNationalityLabel.Text = "County Of Nationality";
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Location = new System.Drawing.Point(28, 282);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(118, 25);
            this.dateOfBirthLabel.TabIndex = 3;
            this.dateOfBirthLabel.Text = "Date of Birth";
            // 
            // personIDLabel
            // 
            this.personIDLabel.AutoSize = true;
            this.personIDLabel.Location = new System.Drawing.Point(28, 226);
            this.personIDLabel.Name = "personIDLabel";
            this.personIDLabel.Size = new System.Drawing.Size(98, 25);
            this.personIDLabel.TabIndex = 2;
            this.personIDLabel.Text = "Person ID";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(28, 168);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(106, 25);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(28, 113);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(106, 25);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            // 
            // RegisterPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 661);
            this.Controls.Add(this.registerPersonGroupBox);
            this.Name = "RegisterPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterPerson";
            this.registerPersonGroupBox.ResumeLayout(false);
            this.registerPersonGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox registerPersonGroupBox;
        private System.Windows.Forms.TextBox additionalInfoTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox personIDTextBox;
        private System.Windows.Forms.DateTimePicker birthDateTimePicker;
        private System.Windows.Forms.DateTimePicker customCheckDateTimePicker;
        private System.Windows.Forms.Label countyOfNationalityLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.Label personIDLabel;
        private System.Windows.Forms.Label customCheckLabel;
        private System.Windows.Forms.Label additionInfoLabel;
        private System.Windows.Forms.Button addPersonButton;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.ListBox countryCodeListBox;
    }
}