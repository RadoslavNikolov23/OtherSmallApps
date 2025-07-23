
namespace DEA_Program.Console.Pages
{
    partial class RegisterVehicle
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
            this.registerVehicleGroupBox = new System.Windows.Forms.GroupBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.vehicleModellabel = new System.Windows.Forms.Label();
            this.goBackButton = new System.Windows.Forms.Button();
            this.customCheckDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.customCheckLabel = new System.Windows.Forms.Label();
            this.addVehicleButton = new System.Windows.Forms.Button();
            this.additionalInfoTextBox = new System.Windows.Forms.TextBox();
            this.additionInfoLabel = new System.Windows.Forms.Label();
            this.ownerIDTextBox = new System.Windows.Forms.TextBox();
            this.registrationNumberTextBox = new System.Windows.Forms.TextBox();
            this.countyOfNationalityLabel = new System.Windows.Forms.Label();
            this.ownerIDLabel = new System.Windows.Forms.Label();
            this.registratinNumberLabel = new System.Windows.Forms.Label();
            this.countryCodeListBox = new System.Windows.Forms.ListBox();
            this.registerVehicleGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // registerVehicleGroupBox
            // 
            this.registerVehicleGroupBox.BackColor = System.Drawing.Color.LightBlue;
            this.registerVehicleGroupBox.Controls.Add(this.countryCodeListBox);
            this.registerVehicleGroupBox.Controls.Add(this.modelTextBox);
            this.registerVehicleGroupBox.Controls.Add(this.vehicleModellabel);
            this.registerVehicleGroupBox.Controls.Add(this.goBackButton);
            this.registerVehicleGroupBox.Controls.Add(this.customCheckDateTimePicker);
            this.registerVehicleGroupBox.Controls.Add(this.customCheckLabel);
            this.registerVehicleGroupBox.Controls.Add(this.addVehicleButton);
            this.registerVehicleGroupBox.Controls.Add(this.additionalInfoTextBox);
            this.registerVehicleGroupBox.Controls.Add(this.additionInfoLabel);
            this.registerVehicleGroupBox.Controls.Add(this.ownerIDTextBox);
            this.registerVehicleGroupBox.Controls.Add(this.registrationNumberTextBox);
            this.registerVehicleGroupBox.Controls.Add(this.countyOfNationalityLabel);
            this.registerVehicleGroupBox.Controls.Add(this.ownerIDLabel);
            this.registerVehicleGroupBox.Controls.Add(this.registratinNumberLabel);
            this.registerVehicleGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerVehicleGroupBox.Location = new System.Drawing.Point(57, 80);
            this.registerVehicleGroupBox.Name = "registerVehicleGroupBox";
            this.registerVehicleGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.registerVehicleGroupBox.Size = new System.Drawing.Size(898, 517);
            this.registerVehicleGroupBox.TabIndex = 5;
            this.registerVehicleGroupBox.TabStop = false;
            this.registerVehicleGroupBox.Text = "Register Vehicle";
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(259, 195);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(198, 30);
            this.modelTextBox.TabIndex = 17;
            // 
            // vehicleModellabel
            // 
            this.vehicleModellabel.AutoSize = true;
            this.vehicleModellabel.Location = new System.Drawing.Point(54, 200);
            this.vehicleModellabel.Name = "vehicleModellabel";
            this.vehicleModellabel.Size = new System.Drawing.Size(128, 25);
            this.vehicleModellabel.TabIndex = 16;
            this.vehicleModellabel.Text = "Model, Brand";
            // 
            // goBackButton
            // 
            this.goBackButton.BackColor = System.Drawing.Color.AliceBlue;
            this.goBackButton.Location = new System.Drawing.Point(714, 14);
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
            this.customCheckDateTimePicker.Location = new System.Drawing.Point(260, 376);
            this.customCheckDateTimePicker.Name = "customCheckDateTimePicker";
            this.customCheckDateTimePicker.Size = new System.Drawing.Size(199, 30);
            this.customCheckDateTimePicker.TabIndex = 14;
            // 
            // customCheckLabel
            // 
            this.customCheckLabel.AutoSize = true;
            this.customCheckLabel.Location = new System.Drawing.Point(54, 376);
            this.customCheckLabel.Name = "customCheckLabel";
            this.customCheckLabel.Size = new System.Drawing.Size(142, 25);
            this.customCheckLabel.TabIndex = 13;
            this.customCheckLabel.Text = "Custom Check";
            // 
            // addVehicleButton
            // 
            this.addVehicleButton.BackColor = System.Drawing.Color.AliceBlue;
            this.addVehicleButton.Location = new System.Drawing.Point(521, 376);
            this.addVehicleButton.Name = "addVehicleButton";
            this.addVehicleButton.Size = new System.Drawing.Size(283, 40);
            this.addVehicleButton.TabIndex = 12;
            this.addVehicleButton.Text = "Add Vehicle";
            this.addVehicleButton.UseVisualStyleBackColor = false;
            this.addVehicleButton.Click += new System.EventHandler(this.addVehicleButton_Click);
            // 
            // additionalInfoTextBox
            // 
            this.additionalInfoTextBox.Location = new System.Drawing.Point(520, 148);
            this.additionalInfoTextBox.Multiline = true;
            this.additionalInfoTextBox.Name = "additionalInfoTextBox";
            this.additionalInfoTextBox.Size = new System.Drawing.Size(284, 196);
            this.additionalInfoTextBox.TabIndex = 11;
            // 
            // additionInfoLabel
            // 
            this.additionInfoLabel.AutoSize = true;
            this.additionInfoLabel.Location = new System.Drawing.Point(551, 103);
            this.additionInfoLabel.Name = "additionInfoLabel";
            this.additionInfoLabel.Size = new System.Drawing.Size(199, 25);
            this.additionInfoLabel.TabIndex = 10;
            this.additionInfoLabel.Text = "Additional Information";
            // 
            // ownerIDTextBox
            // 
            this.ownerIDTextBox.Location = new System.Drawing.Point(261, 314);
            this.ownerIDTextBox.Name = "ownerIDTextBox";
            this.ownerIDTextBox.Size = new System.Drawing.Size(198, 30);
            this.ownerIDTextBox.TabIndex = 7;
            // 
            // registrationNumberTextBox
            // 
            this.registrationNumberTextBox.Location = new System.Drawing.Point(259, 138);
            this.registrationNumberTextBox.Name = "registrationNumberTextBox";
            this.registrationNumberTextBox.Size = new System.Drawing.Size(198, 30);
            this.registrationNumberTextBox.TabIndex = 5;
            // 
            // countyOfNationalityLabel
            // 
            this.countyOfNationalityLabel.AutoSize = true;
            this.countyOfNationalityLabel.Location = new System.Drawing.Point(54, 256);
            this.countyOfNationalityLabel.Name = "countyOfNationalityLabel";
            this.countyOfNationalityLabel.Size = new System.Drawing.Size(196, 25);
            this.countyOfNationalityLabel.TabIndex = 4;
            this.countyOfNationalityLabel.Text = "County Of Nationality";
            // 
            // ownerIDLabel
            // 
            this.ownerIDLabel.AutoSize = true;
            this.ownerIDLabel.Location = new System.Drawing.Point(54, 319);
            this.ownerIDLabel.Name = "ownerIDLabel";
            this.ownerIDLabel.Size = new System.Drawing.Size(94, 25);
            this.ownerIDLabel.TabIndex = 2;
            this.ownerIDLabel.Text = "Owner ID";
            // 
            // registratinNumberLabel
            // 
            this.registratinNumberLabel.AutoSize = true;
            this.registratinNumberLabel.Location = new System.Drawing.Point(54, 141);
            this.registratinNumberLabel.Name = "registratinNumberLabel";
            this.registratinNumberLabel.Size = new System.Drawing.Size(188, 25);
            this.registratinNumberLabel.TabIndex = 0;
            this.registratinNumberLabel.Text = "Registration Number";
            // 
            // countryCodeListBox
            // 
            this.countryCodeListBox.FormattingEnabled = true;
            this.countryCodeListBox.ItemHeight = 25;
            this.countryCodeListBox.Location = new System.Drawing.Point(261, 252);
            this.countryCodeListBox.Name = "countryCodeListBox";
            this.countryCodeListBox.Size = new System.Drawing.Size(196, 29);
            this.countryCodeListBox.TabIndex = 18;
            // 
            // RegisterVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 661);
            this.Controls.Add(this.registerVehicleGroupBox);
            this.Name = "RegisterVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterVihicle";
            this.registerVehicleGroupBox.ResumeLayout(false);
            this.registerVehicleGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox registerVehicleGroupBox;
        private System.Windows.Forms.TextBox registrationNumberTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox ownerIDTextBox;
        private System.Windows.Forms.DateTimePicker customCheckDateTimePicker;
        private System.Windows.Forms.TextBox additionalInfoTextBox;
        private System.Windows.Forms.Label registratinNumberLabel;
        private System.Windows.Forms.Label vehicleModellabel;
        private System.Windows.Forms.Label countyOfNationalityLabel;
        private System.Windows.Forms.Label ownerIDLabel;
        private System.Windows.Forms.Label customCheckLabel;
        private System.Windows.Forms.Label additionInfoLabel;
        private System.Windows.Forms.Button addVehicleButton;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.ListBox countryCodeListBox;
    }
}