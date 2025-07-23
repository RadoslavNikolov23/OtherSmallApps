
namespace DEA_Program.Console.Pages
{
    partial class RegisterCC
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.additionalInfoVehicleTextBox = new System.Windows.Forms.TextBox();
            this.additionalInfoVehicleLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddToVehicleButton = new System.Windows.Forms.Button();
            this.registrationNumberTextBox = new System.Windows.Forms.TextBox();
            this.registrationNumberLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.additionalInfoPersonTextBox = new System.Windows.Forms.TextBox();
            this.additionInfoPersonLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addToPersonButton = new System.Windows.Forms.Button();
            this.personIDTextBox = new System.Windows.Forms.TextBox();
            this.personIDLabel = new System.Windows.Forms.Label();
            this.goBackButton = new System.Windows.Forms.Button();
            this.customCheckDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.customCheckLabel = new System.Windows.Forms.Label();
            this.registerPersonGroupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // registerPersonGroupBox
            // 
            this.registerPersonGroupBox.BackColor = System.Drawing.Color.LightBlue;
            this.registerPersonGroupBox.Controls.Add(this.panel2);
            this.registerPersonGroupBox.Controls.Add(this.panel1);
            this.registerPersonGroupBox.Controls.Add(this.goBackButton);
            this.registerPersonGroupBox.Controls.Add(this.customCheckDateTimePicker);
            this.registerPersonGroupBox.Controls.Add(this.customCheckLabel);
            this.registerPersonGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerPersonGroupBox.Location = new System.Drawing.Point(78, 87);
            this.registerPersonGroupBox.Name = "registerPersonGroupBox";
            this.registerPersonGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.registerPersonGroupBox.Size = new System.Drawing.Size(890, 528);
            this.registerPersonGroupBox.TabIndex = 5;
            this.registerPersonGroupBox.TabStop = false;
            this.registerPersonGroupBox.Text = "Register a Custom Control";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.additionalInfoVehicleTextBox);
            this.panel2.Controls.Add(this.additionalInfoVehicleLabel);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.AddToVehicleButton);
            this.panel2.Controls.Add(this.registrationNumberTextBox);
            this.panel2.Controls.Add(this.registrationNumberLabel);
            this.panel2.Location = new System.Drawing.Point(467, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 340);
            this.panel2.TabIndex = 22;
            // 
            // additionalInfoVehicleTextBox
            // 
            this.additionalInfoVehicleTextBox.Location = new System.Drawing.Point(22, 156);
            this.additionalInfoVehicleTextBox.Multiline = true;
            this.additionalInfoVehicleTextBox.Name = "additionalInfoVehicleTextBox";
            this.additionalInfoVehicleTextBox.Size = new System.Drawing.Size(320, 111);
            this.additionalInfoVehicleTextBox.TabIndex = 22;
            // 
            // additionalInfoVehicleLabel
            // 
            this.additionalInfoVehicleLabel.AutoSize = true;
            this.additionalInfoVehicleLabel.Location = new System.Drawing.Point(86, 118);
            this.additionalInfoVehicleLabel.Name = "additionalInfoVehicleLabel";
            this.additionalInfoVehicleLabel.Size = new System.Drawing.Size(199, 25);
            this.additionalInfoVehicleLabel.TabIndex = 21;
            this.additionalInfoVehicleLabel.Text = "Additional Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Add a Custom Control to a Vehicle";
            // 
            // AddToVehicleButton
            // 
            this.AddToVehicleButton.BackColor = System.Drawing.Color.AliceBlue;
            this.AddToVehicleButton.Location = new System.Drawing.Point(22, 272);
            this.AddToVehicleButton.Name = "AddToVehicleButton";
            this.AddToVehicleButton.Size = new System.Drawing.Size(320, 42);
            this.AddToVehicleButton.TabIndex = 19;
            this.AddToVehicleButton.Text = "Add Custom Control Vehicle";
            this.AddToVehicleButton.UseVisualStyleBackColor = false;
            this.AddToVehicleButton.Click += new System.EventHandler(this.AddToVehicleButton_Click);
            // 
            // registrationNumberTextBox
            // 
            this.registrationNumberTextBox.Location = new System.Drawing.Point(211, 71);
            this.registrationNumberTextBox.Name = "registrationNumberTextBox";
            this.registrationNumberTextBox.Size = new System.Drawing.Size(131, 30);
            this.registrationNumberTextBox.TabIndex = 18;
            // 
            // registrationNumberLabel
            // 
            this.registrationNumberLabel.AutoSize = true;
            this.registrationNumberLabel.Location = new System.Drawing.Point(3, 71);
            this.registrationNumberLabel.Name = "registrationNumberLabel";
            this.registrationNumberLabel.Size = new System.Drawing.Size(188, 25);
            this.registrationNumberLabel.TabIndex = 17;
            this.registrationNumberLabel.Text = "Registration Number";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.additionalInfoPersonTextBox);
            this.panel1.Controls.Add(this.additionInfoPersonLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.addToPersonButton);
            this.panel1.Controls.Add(this.personIDTextBox);
            this.panel1.Controls.Add(this.personIDLabel);
            this.panel1.Location = new System.Drawing.Point(34, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 342);
            this.panel1.TabIndex = 21;
            // 
            // additionalInfoPersonTextBox
            // 
            this.additionalInfoPersonTextBox.Location = new System.Drawing.Point(22, 158);
            this.additionalInfoPersonTextBox.Multiline = true;
            this.additionalInfoPersonTextBox.Name = "additionalInfoPersonTextBox";
            this.additionalInfoPersonTextBox.Size = new System.Drawing.Size(301, 110);
            this.additionalInfoPersonTextBox.TabIndex = 18;
            // 
            // additionInfoPersonLabel
            // 
            this.additionInfoPersonLabel.AutoSize = true;
            this.additionInfoPersonLabel.Location = new System.Drawing.Point(68, 120);
            this.additionInfoPersonLabel.Name = "additionInfoPersonLabel";
            this.additionInfoPersonLabel.Size = new System.Drawing.Size(199, 25);
            this.additionInfoPersonLabel.TabIndex = 17;
            this.additionInfoPersonLabel.Text = "Additional Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Add a Custom Control to a Person";
            // 
            // addToPersonButton
            // 
            this.addToPersonButton.BackColor = System.Drawing.Color.AliceBlue;
            this.addToPersonButton.Location = new System.Drawing.Point(22, 274);
            this.addToPersonButton.Name = "addToPersonButton";
            this.addToPersonButton.Size = new System.Drawing.Size(304, 42);
            this.addToPersonButton.TabIndex = 12;
            this.addToPersonButton.Text = "Add Custom Control Person";
            this.addToPersonButton.UseVisualStyleBackColor = false;
            this.addToPersonButton.Click += new System.EventHandler(this.addToPersonButton_Click);
            // 
            // personIDTextBox
            // 
            this.personIDTextBox.Location = new System.Drawing.Point(128, 68);
            this.personIDTextBox.Name = "personIDTextBox";
            this.personIDTextBox.Size = new System.Drawing.Size(198, 30);
            this.personIDTextBox.TabIndex = 7;
            // 
            // personIDLabel
            // 
            this.personIDLabel.AutoSize = true;
            this.personIDLabel.Location = new System.Drawing.Point(17, 71);
            this.personIDLabel.Name = "personIDLabel";
            this.personIDLabel.Size = new System.Drawing.Size(98, 25);
            this.personIDLabel.TabIndex = 2;
            this.personIDLabel.Text = "Person ID";
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
            this.customCheckDateTimePicker.Location = new System.Drawing.Point(431, 104);
            this.customCheckDateTimePicker.Name = "customCheckDateTimePicker";
            this.customCheckDateTimePicker.Size = new System.Drawing.Size(194, 30);
            this.customCheckDateTimePicker.TabIndex = 14;
            // 
            // customCheckLabel
            // 
            this.customCheckLabel.AutoSize = true;
            this.customCheckLabel.Location = new System.Drawing.Point(221, 104);
            this.customCheckLabel.Name = "customCheckLabel";
            this.customCheckLabel.Size = new System.Drawing.Size(188, 25);
            this.customCheckLabel.TabIndex = 13;
            this.customCheckLabel.Text = "Custom Check Date";
            // 
            // RegisterCustomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 661);
            this.Controls.Add(this.registerPersonGroupBox);
            this.Name = "RegisterCustomControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterCustomControl";
            this.registerPersonGroupBox.ResumeLayout(false);
            this.registerPersonGroupBox.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox registerPersonGroupBox;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.DateTimePicker customCheckDateTimePicker;
        private System.Windows.Forms.Label customCheckLabel;
        private System.Windows.Forms.Button addToPersonButton;
        private System.Windows.Forms.TextBox personIDTextBox;
        private System.Windows.Forms.Label personIDLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddToVehicleButton;
        private System.Windows.Forms.TextBox registrationNumberTextBox;
        private System.Windows.Forms.Label registrationNumberLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label additionInfoPersonLabel;
        private System.Windows.Forms.TextBox additionalInfoPersonTextBox;
        private System.Windows.Forms.Label additionalInfoVehicleLabel;
        private System.Windows.Forms.TextBox additionalInfoVehicleTextBox;
    }
}