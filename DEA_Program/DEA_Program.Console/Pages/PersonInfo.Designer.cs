
namespace DEA_Program.Console.Pages
{
    partial class PersonInfo
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
            this.personIDGroupBox = new System.Windows.Forms.GroupBox();
            this.goBackButton = new System.Windows.Forms.Button();
            this.personFoundLabel = new System.Windows.Forms.Label();
            this.findPersonButton = new System.Windows.Forms.Button();
            this.enteredPersonIdTextBox = new System.Windows.Forms.TextBox();
            this.enteredPersonId = new System.Windows.Forms.Label();
            this.infoPersonGroupBox = new System.Windows.Forms.GroupBox();
            this.customsControlComboBox = new System.Windows.Forms.ComboBox();
            this.customsControlLabel = new System.Windows.Forms.Label();
            this.additionalInfoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.countryNationalityTextBox = new System.Windows.Forms.TextBox();
            this.birthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.personIDGroupBox.SuspendLayout();
            this.infoPersonGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // personIDGroupBox
            // 
            this.personIDGroupBox.BackColor = System.Drawing.Color.LightBlue;
            this.personIDGroupBox.Controls.Add(this.goBackButton);
            this.personIDGroupBox.Controls.Add(this.personFoundLabel);
            this.personIDGroupBox.Controls.Add(this.findPersonButton);
            this.personIDGroupBox.Controls.Add(this.enteredPersonIdTextBox);
            this.personIDGroupBox.Controls.Add(this.enteredPersonId);
            this.personIDGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.personIDGroupBox.Location = new System.Drawing.Point(87, 36);
            this.personIDGroupBox.Name = "personIDGroupBox";
            this.personIDGroupBox.Size = new System.Drawing.Size(838, 203);
            this.personIDGroupBox.TabIndex = 10;
            this.personIDGroupBox.TabStop = false;
            this.personIDGroupBox.Text = "Person Info";
            // 
            // goBackButton
            // 
            this.goBackButton.BackColor = System.Drawing.Color.AliceBlue;
            this.goBackButton.Location = new System.Drawing.Point(687, 29);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(128, 32);
            this.goBackButton.TabIndex = 9;
            this.goBackButton.Text = "Go Back";
            this.goBackButton.UseVisualStyleBackColor = false;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // personFoundLabel
            // 
            this.personFoundLabel.AutoSize = true;
            this.personFoundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.personFoundLabel.Location = new System.Drawing.Point(14, 151);
            this.personFoundLabel.Name = "personFoundLabel";
            this.personFoundLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.personFoundLabel.Size = new System.Drawing.Size(0, 31);
            this.personFoundLabel.TabIndex = 23;
            // 
            // findPersonButton
            // 
            this.findPersonButton.BackColor = System.Drawing.Color.AliceBlue;
            this.findPersonButton.Location = new System.Drawing.Point(472, 88);
            this.findPersonButton.Name = "findPersonButton";
            this.findPersonButton.Size = new System.Drawing.Size(230, 32);
            this.findPersonButton.TabIndex = 2;
            this.findPersonButton.Text = "Find Person";
            this.findPersonButton.UseVisualStyleBackColor = false;
            this.findPersonButton.Click += new System.EventHandler(this.findPersonButton_Click);
            // 
            // enteredPersonIdTextBox
            // 
            this.enteredPersonIdTextBox.Location = new System.Drawing.Point(201, 91);
            this.enteredPersonIdTextBox.Name = "enteredPersonIdTextBox";
            this.enteredPersonIdTextBox.Size = new System.Drawing.Size(201, 30);
            this.enteredPersonIdTextBox.TabIndex = 1;
            // 
            // enteredPersonId
            // 
            this.enteredPersonId.AutoSize = true;
            this.enteredPersonId.Location = new System.Drawing.Point(46, 91);
            this.enteredPersonId.Name = "enteredPersonId";
            this.enteredPersonId.Size = new System.Drawing.Size(149, 25);
            this.enteredPersonId.TabIndex = 0;
            this.enteredPersonId.Text = "Enter Person ID";
            // 
            // infoPersonGroupBox
            // 
            this.infoPersonGroupBox.BackColor = System.Drawing.Color.LightBlue;
            this.infoPersonGroupBox.Controls.Add(this.customsControlComboBox);
            this.infoPersonGroupBox.Controls.Add(this.customsControlLabel);
            this.infoPersonGroupBox.Controls.Add(this.additionalInfoTextBox);
            this.infoPersonGroupBox.Controls.Add(this.label3);
            this.infoPersonGroupBox.Controls.Add(this.countryNationalityTextBox);
            this.infoPersonGroupBox.Controls.Add(this.birthDateTimePicker);
            this.infoPersonGroupBox.Controls.Add(this.lastNameTextBox);
            this.infoPersonGroupBox.Controls.Add(this.firstNameTextBox);
            this.infoPersonGroupBox.Controls.Add(this.label4);
            this.infoPersonGroupBox.Controls.Add(this.label5);
            this.infoPersonGroupBox.Controls.Add(this.label6);
            this.infoPersonGroupBox.Controls.Add(this.label7);
            this.infoPersonGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoPersonGroupBox.Location = new System.Drawing.Point(87, 256);
            this.infoPersonGroupBox.Name = "infoPersonGroupBox";
            this.infoPersonGroupBox.Size = new System.Drawing.Size(838, 375);
            this.infoPersonGroupBox.TabIndex = 11;
            this.infoPersonGroupBox.TabStop = false;
            this.infoPersonGroupBox.Text = "Person Full Information";
            this.infoPersonGroupBox.Visible = false;
            // 
            // customsControlComboBox
            // 
            this.customsControlComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customsControlComboBox.FormattingEnabled = true;
            this.customsControlComboBox.Location = new System.Drawing.Point(253, 287);
            this.customsControlComboBox.Name = "customsControlComboBox";
            this.customsControlComboBox.Size = new System.Drawing.Size(156, 28);
            this.customsControlComboBox.TabIndex = 7;
            this.customsControlComboBox.Text = "List of Dates";
            // 
            // customsControlLabel
            // 
            this.customsControlLabel.AutoSize = true;
            this.customsControlLabel.Location = new System.Drawing.Point(89, 290);
            this.customsControlLabel.Name = "customsControlLabel";
            this.customsControlLabel.Size = new System.Drawing.Size(158, 25);
            this.customsControlLabel.TabIndex = 22;
            this.customsControlLabel.Text = "Customs Control";
            // 
            // additionalInfoTextBox
            // 
            this.additionalInfoTextBox.Location = new System.Drawing.Point(463, 90);
            this.additionalInfoTextBox.Multiline = true;
            this.additionalInfoTextBox.Name = "additionalInfoTextBox";
            this.additionalInfoTextBox.Size = new System.Drawing.Size(284, 225);
            this.additionalInfoTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(503, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Additional Information";
            // 
            // countryNationalityTextBox
            // 
            this.countryNationalityTextBox.Location = new System.Drawing.Point(291, 246);
            this.countryNationalityTextBox.Name = "countryNationalityTextBox";
            this.countryNationalityTextBox.Size = new System.Drawing.Size(117, 30);
            this.countryNationalityTextBox.TabIndex = 6;
            // 
            // birthDateTimePicker
            // 
            this.birthDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.birthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthDateTimePicker.Location = new System.Drawing.Point(210, 200);
            this.birthDateTimePicker.Name = "birthDateTimePicker";
            this.birthDateTimePicker.Size = new System.Drawing.Size(198, 30);
            this.birthDateTimePicker.TabIndex = 5;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(210, 148);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(198, 30);
            this.lastNameTextBox.TabIndex = 4;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(210, 90);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(198, 30);
            this.firstNameTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "County Of Nationality";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Date of Birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Last Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "First Name";
            // 
            // PersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 661);
            this.Controls.Add(this.infoPersonGroupBox);
            this.Controls.Add(this.personIDGroupBox);
            this.Name = "PersonInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonInfo";
            this.personIDGroupBox.ResumeLayout(false);
            this.personIDGroupBox.PerformLayout();
            this.infoPersonGroupBox.ResumeLayout(false);
            this.infoPersonGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox personIDGroupBox;
        private System.Windows.Forms.Button findPersonButton;
        private System.Windows.Forms.TextBox enteredPersonIdTextBox;
        private System.Windows.Forms.Label enteredPersonId;
        private System.Windows.Forms.GroupBox infoPersonGroupBox;
        private System.Windows.Forms.TextBox additionalInfoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox countryNationalityTextBox;
        private System.Windows.Forms.DateTimePicker birthDateTimePicker;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Label personFoundLabel;
        private System.Windows.Forms.ComboBox customsControlComboBox;
        private System.Windows.Forms.Label customsControlLabel;
    }
}