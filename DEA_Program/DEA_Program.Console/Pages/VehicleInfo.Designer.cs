
namespace DEA_Program.Console.Pages
{
    partial class VehicleInfo
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
            this.infoVehicleGroupBox = new System.Windows.Forms.GroupBox();
            this.ownerNameTextBox = new System.Windows.Forms.TextBox();
            this.ownerNameLabel = new System.Windows.Forms.Label();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.vehicleModellabel = new System.Windows.Forms.Label();
            this.customCheckLabel = new System.Windows.Forms.Label();
            this.additionalInfoTextBox = new System.Windows.Forms.TextBox();
            this.additionInfoLabel = new System.Windows.Forms.Label();
            this.countryNationalityTextBox = new System.Windows.Forms.TextBox();
            this.countyOfNationalityLabel = new System.Windows.Forms.Label();
            this.ownerIDLabel = new System.Windows.Forms.Label();
            this.vehicleRegistrationNumberGroupBox = new System.Windows.Forms.GroupBox();
            this.goBackButton = new System.Windows.Forms.Button();
            this.vehicleFoundLabel = new System.Windows.Forms.Label();
            this.findVehicleButton = new System.Windows.Forms.Button();
            this.enteredRegistrationNumberTextBox = new System.Windows.Forms.TextBox();
            this.enteredRegistrationNumber = new System.Windows.Forms.Label();
            this.customsControlComboBox = new System.Windows.Forms.ComboBox();
            this.infoVehicleGroupBox.SuspendLayout();
            this.vehicleRegistrationNumberGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoVehicleGroupBox
            // 
            this.infoVehicleGroupBox.BackColor = System.Drawing.Color.LightBlue;
            this.infoVehicleGroupBox.Controls.Add(this.customsControlComboBox);
            this.infoVehicleGroupBox.Controls.Add(this.ownerNameTextBox);
            this.infoVehicleGroupBox.Controls.Add(this.ownerNameLabel);
            this.infoVehicleGroupBox.Controls.Add(this.modelTextBox);
            this.infoVehicleGroupBox.Controls.Add(this.vehicleModellabel);
            this.infoVehicleGroupBox.Controls.Add(this.customCheckLabel);
            this.infoVehicleGroupBox.Controls.Add(this.additionalInfoTextBox);
            this.infoVehicleGroupBox.Controls.Add(this.additionInfoLabel);
            this.infoVehicleGroupBox.Controls.Add(this.countryNationalityTextBox);
            this.infoVehicleGroupBox.Controls.Add(this.countyOfNationalityLabel);
            this.infoVehicleGroupBox.Controls.Add(this.ownerIDLabel);
            this.infoVehicleGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoVehicleGroupBox.Location = new System.Drawing.Point(77, 270);
            this.infoVehicleGroupBox.Name = "infoVehicleGroupBox";
            this.infoVehicleGroupBox.Size = new System.Drawing.Size(838, 340);
            this.infoVehicleGroupBox.TabIndex = 25;
            this.infoVehicleGroupBox.TabStop = false;
            this.infoVehicleGroupBox.Text = "Vehicle Full Information";
            this.infoVehicleGroupBox.Visible = false;
            // 
            // ownerNameTextBox
            // 
            this.ownerNameTextBox.Location = new System.Drawing.Point(251, 208);
            this.ownerNameTextBox.Name = "ownerNameTextBox";
            this.ownerNameTextBox.Size = new System.Drawing.Size(198, 30);
            this.ownerNameTextBox.TabIndex = 5;
            // 
            // ownerNameLabel
            // 
            this.ownerNameLabel.AutoSize = true;
            this.ownerNameLabel.Location = new System.Drawing.Point(46, 208);
            this.ownerNameLabel.Name = "ownerNameLabel";
            this.ownerNameLabel.Size = new System.Drawing.Size(121, 25);
            this.ownerNameLabel.TabIndex = 31;
            this.ownerNameLabel.Text = "Owen Name";
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(251, 88);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(198, 30);
            this.modelTextBox.TabIndex = 3;
            // 
            // vehicleModellabel
            // 
            this.vehicleModellabel.AutoSize = true;
            this.vehicleModellabel.Location = new System.Drawing.Point(46, 93);
            this.vehicleModellabel.Name = "vehicleModellabel";
            this.vehicleModellabel.Size = new System.Drawing.Size(128, 25);
            this.vehicleModellabel.TabIndex = 29;
            this.vehicleModellabel.Text = "Model, Brand";
            // 
            // customCheckLabel
            // 
            this.customCheckLabel.AutoSize = true;
            this.customCheckLabel.Location = new System.Drawing.Point(46, 261);
            this.customCheckLabel.Name = "customCheckLabel";
            this.customCheckLabel.Size = new System.Drawing.Size(158, 25);
            this.customCheckLabel.TabIndex = 27;
            this.customCheckLabel.Text = "Custom Controls";
            // 
            // additionalInfoTextBox
            // 
            this.additionalInfoTextBox.Location = new System.Drawing.Point(489, 108);
            this.additionalInfoTextBox.Multiline = true;
            this.additionalInfoTextBox.Name = "additionalInfoTextBox";
            this.additionalInfoTextBox.Size = new System.Drawing.Size(284, 180);
            this.additionalInfoTextBox.TabIndex = 7;
            // 
            // additionInfoLabel
            // 
            this.additionInfoLabel.AutoSize = true;
            this.additionInfoLabel.Location = new System.Drawing.Point(522, 71);
            this.additionInfoLabel.Name = "additionInfoLabel";
            this.additionInfoLabel.Size = new System.Drawing.Size(199, 25);
            this.additionInfoLabel.TabIndex = 24;
            this.additionInfoLabel.Text = "Additional Information";
            // 
            // countryNationalityTextBox
            // 
            this.countryNationalityTextBox.Location = new System.Drawing.Point(252, 148);
            this.countryNationalityTextBox.Name = "countryNationalityTextBox";
            this.countryNationalityTextBox.Size = new System.Drawing.Size(198, 30);
            this.countryNationalityTextBox.TabIndex = 4;
            // 
            // countyOfNationalityLabel
            // 
            this.countyOfNationalityLabel.AutoSize = true;
            this.countyOfNationalityLabel.Location = new System.Drawing.Point(46, 148);
            this.countyOfNationalityLabel.Name = "countyOfNationalityLabel";
            this.countyOfNationalityLabel.Size = new System.Drawing.Size(196, 25);
            this.countyOfNationalityLabel.TabIndex = 20;
            this.countyOfNationalityLabel.Text = "County Of Nationality";
            // 
            // ownerIDLabel
            // 
            this.ownerIDLabel.AutoSize = true;
            this.ownerIDLabel.Location = new System.Drawing.Point(46, 177);
            this.ownerIDLabel.Name = "ownerIDLabel";
            this.ownerIDLabel.Size = new System.Drawing.Size(0, 25);
            this.ownerIDLabel.TabIndex = 19;
            // 
            // vehicleRegistrationNumberGroupBox
            // 
            this.vehicleRegistrationNumberGroupBox.BackColor = System.Drawing.Color.LightBlue;
            this.vehicleRegistrationNumberGroupBox.Controls.Add(this.goBackButton);
            this.vehicleRegistrationNumberGroupBox.Controls.Add(this.vehicleFoundLabel);
            this.vehicleRegistrationNumberGroupBox.Controls.Add(this.findVehicleButton);
            this.vehicleRegistrationNumberGroupBox.Controls.Add(this.enteredRegistrationNumberTextBox);
            this.vehicleRegistrationNumberGroupBox.Controls.Add(this.enteredRegistrationNumber);
            this.vehicleRegistrationNumberGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vehicleRegistrationNumberGroupBox.Location = new System.Drawing.Point(77, 61);
            this.vehicleRegistrationNumberGroupBox.Name = "vehicleRegistrationNumberGroupBox";
            this.vehicleRegistrationNumberGroupBox.Size = new System.Drawing.Size(838, 203);
            this.vehicleRegistrationNumberGroupBox.TabIndex = 24;
            this.vehicleRegistrationNumberGroupBox.TabStop = false;
            this.vehicleRegistrationNumberGroupBox.Text = "Vehicle Info";
            // 
            // goBackButton
            // 
            this.goBackButton.BackColor = System.Drawing.Color.AliceBlue;
            this.goBackButton.Location = new System.Drawing.Point(687, 29);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(128, 32);
            this.goBackButton.TabIndex = 24;
            this.goBackButton.Text = "Go Back";
            this.goBackButton.UseVisualStyleBackColor = false;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // vehicleFoundLabel
            // 
            this.vehicleFoundLabel.AutoSize = true;
            this.vehicleFoundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vehicleFoundLabel.Location = new System.Drawing.Point(14, 151);
            this.vehicleFoundLabel.Name = "vehicleFoundLabel";
            this.vehicleFoundLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.vehicleFoundLabel.Size = new System.Drawing.Size(0, 31);
            this.vehicleFoundLabel.TabIndex = 23;
            // 
            // findVehicleButton
            // 
            this.findVehicleButton.BackColor = System.Drawing.Color.AliceBlue;
            this.findVehicleButton.Location = new System.Drawing.Point(560, 92);
            this.findVehicleButton.Name = "findVehicleButton";
            this.findVehicleButton.Size = new System.Drawing.Size(230, 32);
            this.findVehicleButton.TabIndex = 2;
            this.findVehicleButton.Text = "Find Vehicle";
            this.findVehicleButton.UseVisualStyleBackColor = false;
            this.findVehicleButton.Click += new System.EventHandler(this.findVehicleButton_Click);
            // 
            // enteredRegistrationNumberTextBox
            // 
            this.enteredRegistrationNumberTextBox.Location = new System.Drawing.Point(306, 92);
            this.enteredRegistrationNumberTextBox.Name = "enteredRegistrationNumberTextBox";
            this.enteredRegistrationNumberTextBox.Size = new System.Drawing.Size(215, 30);
            this.enteredRegistrationNumberTextBox.TabIndex = 1;
            // 
            // enteredRegistrationNumber
            // 
            this.enteredRegistrationNumber.AutoSize = true;
            this.enteredRegistrationNumber.Location = new System.Drawing.Point(46, 91);
            this.enteredRegistrationNumber.Name = "enteredRegistrationNumber";
            this.enteredRegistrationNumber.Size = new System.Drawing.Size(239, 25);
            this.enteredRegistrationNumber.TabIndex = 0;
            this.enteredRegistrationNumber.Text = "Enter Registration Number";
            // 
            // customsControlComboBox
            // 
            this.customsControlComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customsControlComboBox.FormattingEnabled = true;
            this.customsControlComboBox.Location = new System.Drawing.Point(251, 260);
            this.customsControlComboBox.Name = "customsControlComboBox";
            this.customsControlComboBox.Size = new System.Drawing.Size(198, 28);
            this.customsControlComboBox.TabIndex = 35;
            this.customsControlComboBox.Text = "List of Dates";
            // 
            // VehicleInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 661);
            this.Controls.Add(this.infoVehicleGroupBox);
            this.Controls.Add(this.vehicleRegistrationNumberGroupBox);
            this.Name = "VehicleInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VehicleInfo";
            this.infoVehicleGroupBox.ResumeLayout(false);
            this.infoVehicleGroupBox.PerformLayout();
            this.vehicleRegistrationNumberGroupBox.ResumeLayout(false);
            this.vehicleRegistrationNumberGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox infoVehicleGroupBox;
        private System.Windows.Forms.GroupBox vehicleRegistrationNumberGroupBox;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Label vehicleFoundLabel;
        private System.Windows.Forms.Button findVehicleButton;
        private System.Windows.Forms.TextBox enteredRegistrationNumberTextBox;
        private System.Windows.Forms.Label enteredRegistrationNumber;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.Label vehicleModellabel;
        private System.Windows.Forms.Label customCheckLabel;
        private System.Windows.Forms.TextBox additionalInfoTextBox;
        private System.Windows.Forms.Label additionInfoLabel;
        private System.Windows.Forms.TextBox countryNationalityTextBox;
        private System.Windows.Forms.Label countyOfNationalityLabel;
        private System.Windows.Forms.Label ownerIDLabel;
        private System.Windows.Forms.TextBox ownerNameTextBox;
        private System.Windows.Forms.Label ownerNameLabel;
        private System.Windows.Forms.ComboBox customsControlComboBox;
    }
}