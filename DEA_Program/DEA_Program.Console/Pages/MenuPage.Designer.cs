
namespace DEA_Program.Console
{
    partial class MenuPage
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
            this.menuGroupBox = new System.Windows.Forms.GroupBox();
            this.addCustomCotrolButton = new System.Windows.Forms.Button();
            this.toCheckVehicleButton = new System.Windows.Forms.Button();
            this.toChechPersonbutton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.toCheckCustomControlButton = new System.Windows.Forms.Button();
            this.toLoginMainPageButton = new System.Windows.Forms.Button();
            this.registerUserButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.adminMenuGroupBox = new System.Windows.Forms.GroupBox();
            this.ShowAllCustomControlbutton = new System.Windows.Forms.Button();
            this.allVehiclesButton = new System.Windows.Forms.Button();
            this.allPersonsButton = new System.Windows.Forms.Button();
            this.optionsButton = new System.Windows.Forms.Button();
            this.menuGroupBox.SuspendLayout();
            this.adminMenuGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuGroupBox
            // 
            this.menuGroupBox.BackColor = System.Drawing.Color.LightBlue;
            this.menuGroupBox.Controls.Add(this.optionsButton);
            this.menuGroupBox.Controls.Add(this.addCustomCotrolButton);
            this.menuGroupBox.Controls.Add(this.toCheckVehicleButton);
            this.menuGroupBox.Controls.Add(this.toChechPersonbutton);
            this.menuGroupBox.Controls.Add(this.exitButton);
            this.menuGroupBox.Controls.Add(this.toCheckCustomControlButton);
            this.menuGroupBox.Controls.Add(this.toLoginMainPageButton);
            this.menuGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuGroupBox.Location = new System.Drawing.Point(116, 38);
            this.menuGroupBox.Name = "menuGroupBox";
            this.menuGroupBox.Size = new System.Drawing.Size(778, 393);
            this.menuGroupBox.TabIndex = 11;
            this.menuGroupBox.TabStop = false;
            this.menuGroupBox.Text = "Menu";
            // 
            // addCustomCotrolButton
            // 
            this.addCustomCotrolButton.BackColor = System.Drawing.Color.AliceBlue;
            this.addCustomCotrolButton.Location = new System.Drawing.Point(105, 198);
            this.addCustomCotrolButton.Name = "addCustomCotrolButton";
            this.addCustomCotrolButton.Size = new System.Drawing.Size(237, 65);
            this.addCustomCotrolButton.TabIndex = 3;
            this.addCustomCotrolButton.Text = "Add Custom Contol";
            this.addCustomCotrolButton.UseVisualStyleBackColor = false;
            this.addCustomCotrolButton.Click += new System.EventHandler(this.addCustomCotrolButton_Click);
            // 
            // toCheckVehicleButton
            // 
            this.toCheckVehicleButton.BackColor = System.Drawing.Color.AliceBlue;
            this.toCheckVehicleButton.Location = new System.Drawing.Point(429, 105);
            this.toCheckVehicleButton.Name = "toCheckVehicleButton";
            this.toCheckVehicleButton.Size = new System.Drawing.Size(237, 65);
            this.toCheckVehicleButton.TabIndex = 2;
            this.toCheckVehicleButton.Text = "Check Vehicle";
            this.toCheckVehicleButton.UseVisualStyleBackColor = false;
            this.toCheckVehicleButton.Click += new System.EventHandler(this.toCheckVehicleButton_Click);
            // 
            // toChechPersonbutton
            // 
            this.toChechPersonbutton.BackColor = System.Drawing.Color.AliceBlue;
            this.toChechPersonbutton.Location = new System.Drawing.Point(105, 105);
            this.toChechPersonbutton.Name = "toChechPersonbutton";
            this.toChechPersonbutton.Size = new System.Drawing.Size(237, 65);
            this.toChechPersonbutton.TabIndex = 1;
            this.toChechPersonbutton.Text = "Check Person";
            this.toChechPersonbutton.UseVisualStyleBackColor = false;
            this.toChechPersonbutton.Click += new System.EventHandler(this.toChechPersonbutton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.AliceBlue;
            this.exitButton.Location = new System.Drawing.Point(429, 296);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(237, 65);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // toCheckCustomControlButton
            // 
            this.toCheckCustomControlButton.BackColor = System.Drawing.Color.AliceBlue;
            this.toCheckCustomControlButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toCheckCustomControlButton.Location = new System.Drawing.Point(429, 198);
            this.toCheckCustomControlButton.Name = "toCheckCustomControlButton";
            this.toCheckCustomControlButton.Size = new System.Drawing.Size(237, 65);
            this.toCheckCustomControlButton.TabIndex = 4;
            this.toCheckCustomControlButton.Text = "Check a Custom Control";
            this.toCheckCustomControlButton.UseVisualStyleBackColor = false;
            this.toCheckCustomControlButton.Click += new System.EventHandler(this.toCheckCustomControlButton_Click);
            // 
            // toLoginMainPageButton
            // 
            this.toLoginMainPageButton.BackColor = System.Drawing.Color.AliceBlue;
            this.toLoginMainPageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toLoginMainPageButton.Location = new System.Drawing.Point(105, 296);
            this.toLoginMainPageButton.Name = "toLoginMainPageButton";
            this.toLoginMainPageButton.Size = new System.Drawing.Size(237, 65);
            this.toLoginMainPageButton.TabIndex = 5;
            this.toLoginMainPageButton.Text = "Log with diffrent Username";
            this.toLoginMainPageButton.UseVisualStyleBackColor = false;
            this.toLoginMainPageButton.Click += new System.EventHandler(this.toLoginMainPageButton_Click);
            // 
            // registerUserButton
            // 
            this.registerUserButton.BackColor = System.Drawing.Color.AliceBlue;
            this.registerUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerUserButton.Location = new System.Drawing.Point(40, 61);
            this.registerUserButton.Name = "registerUserButton";
            this.registerUserButton.Size = new System.Drawing.Size(160, 70);
            this.registerUserButton.TabIndex = 8;
            this.registerUserButton.Text = "Register User";
            this.registerUserButton.UseVisualStyleBackColor = false;
            this.registerUserButton.Click += new System.EventHandler(this.registerUserButton_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.welcomeLabel.Location = new System.Drawing.Point(121, 38);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(2, 33);
            this.welcomeLabel.TabIndex = 13;
            // 
            // adminMenuGroupBox
            // 
            this.adminMenuGroupBox.BackColor = System.Drawing.Color.LightBlue;
            this.adminMenuGroupBox.Controls.Add(this.ShowAllCustomControlbutton);
            this.adminMenuGroupBox.Controls.Add(this.allVehiclesButton);
            this.adminMenuGroupBox.Controls.Add(this.allPersonsButton);
            this.adminMenuGroupBox.Controls.Add(this.registerUserButton);
            this.adminMenuGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adminMenuGroupBox.Location = new System.Drawing.Point(121, 447);
            this.adminMenuGroupBox.Name = "adminMenuGroupBox";
            this.adminMenuGroupBox.Size = new System.Drawing.Size(773, 166);
            this.adminMenuGroupBox.TabIndex = 12;
            this.adminMenuGroupBox.TabStop = false;
            this.adminMenuGroupBox.Text = "Admin Menu";
            this.adminMenuGroupBox.Visible = false;
            // 
            // ShowAllCustomControlbutton
            // 
            this.ShowAllCustomControlbutton.BackColor = System.Drawing.Color.AliceBlue;
            this.ShowAllCustomControlbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowAllCustomControlbutton.Location = new System.Drawing.Point(588, 61);
            this.ShowAllCustomControlbutton.Name = "ShowAllCustomControlbutton";
            this.ShowAllCustomControlbutton.Size = new System.Drawing.Size(160, 70);
            this.ShowAllCustomControlbutton.TabIndex = 11;
            this.ShowAllCustomControlbutton.Text = "Show all Custom Controls";
            this.ShowAllCustomControlbutton.UseVisualStyleBackColor = false;
            this.ShowAllCustomControlbutton.Click += new System.EventHandler(this.ShowAllCustomControlbutton_Click);
            // 
            // allVehiclesButton
            // 
            this.allVehiclesButton.BackColor = System.Drawing.Color.AliceBlue;
            this.allVehiclesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allVehiclesButton.Location = new System.Drawing.Point(407, 61);
            this.allVehiclesButton.Name = "allVehiclesButton";
            this.allVehiclesButton.Size = new System.Drawing.Size(160, 70);
            this.allVehiclesButton.TabIndex = 10;
            this.allVehiclesButton.Text = "Show all Vehicles";
            this.allVehiclesButton.UseVisualStyleBackColor = false;
            this.allVehiclesButton.Click += new System.EventHandler(this.allVehiclesButton_Click);
            // 
            // allPersonsButton
            // 
            this.allPersonsButton.BackColor = System.Drawing.Color.AliceBlue;
            this.allPersonsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allPersonsButton.Location = new System.Drawing.Point(219, 61);
            this.allPersonsButton.Name = "allPersonsButton";
            this.allPersonsButton.Size = new System.Drawing.Size(160, 70);
            this.allPersonsButton.TabIndex = 9;
            this.allPersonsButton.Text = "Show all Persons";
            this.allPersonsButton.UseVisualStyleBackColor = false;
            this.allPersonsButton.Click += new System.EventHandler(this.allPersonsButton_Click);
            // 
            // optionsButton
            // 
            this.optionsButton.BackColor = System.Drawing.Color.AliceBlue;
            this.optionsButton.Location = new System.Drawing.Point(593, 25);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(160, 40);
            this.optionsButton.TabIndex = 6;
            this.optionsButton.Text = "Options";
            this.optionsButton.UseVisualStyleBackColor = false;
            this.optionsButton.Click += new System.EventHandler(this.optionsButton_Click);
            // 
            // MenuPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 661);
            this.Controls.Add(this.adminMenuGroupBox);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.menuGroupBox);
            this.Name = "MenuPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPage";
            this.menuGroupBox.ResumeLayout(false);
            this.adminMenuGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox menuGroupBox;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button toChechPersonbutton;
        private System.Windows.Forms.Button toCheckVehicleButton;
        private System.Windows.Forms.Button toCheckCustomControlButton;
        private System.Windows.Forms.Button registerUserButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox adminMenuGroupBox;
        private System.Windows.Forms.Button allVehiclesButton;
        private System.Windows.Forms.Button allPersonsButton;
        private System.Windows.Forms.Button ShowAllCustomControlbutton;
        private System.Windows.Forms.Button addCustomCotrolButton;
        private System.Windows.Forms.Button toLoginMainPageButton;
        private System.Windows.Forms.Button optionsButton;
    }
}