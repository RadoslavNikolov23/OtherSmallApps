
namespace DEA_Program.Console.Pages
{
    using DEA_Program.Common.Enums;
    using System;

    partial class RegisterUser
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
            this.registerUserGroupBox = new System.Windows.Forms.GroupBox();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.roleLabel = new System.Windows.Forms.Label();
            this.goBackButton = new System.Windows.Forms.Button();
            this.addUserButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordNameLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.allUsersButton = new System.Windows.Forms.Button();
            this.registerUserGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // registerUserGroupBox
            // 
            this.registerUserGroupBox.BackColor = System.Drawing.Color.LightBlue;
            this.registerUserGroupBox.Controls.Add(this.allUsersButton);
            this.registerUserGroupBox.Controls.Add(this.roleComboBox);
            this.registerUserGroupBox.Controls.Add(this.roleLabel);
            this.registerUserGroupBox.Controls.Add(this.goBackButton);
            this.registerUserGroupBox.Controls.Add(this.addUserButton);
            this.registerUserGroupBox.Controls.Add(this.passwordTextBox);
            this.registerUserGroupBox.Controls.Add(this.userNameTextBox);
            this.registerUserGroupBox.Controls.Add(this.passwordNameLabel);
            this.registerUserGroupBox.Controls.Add(this.userNameLabel);
            this.registerUserGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerUserGroupBox.Location = new System.Drawing.Point(74, 92);
            this.registerUserGroupBox.Name = "registerUserGroupBox";
            this.registerUserGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.registerUserGroupBox.Size = new System.Drawing.Size(863, 480);
            this.registerUserGroupBox.TabIndex = 5;
            this.registerUserGroupBox.TabStop = false;
            this.registerUserGroupBox.Text = "Register User";
            // 
            // roleComboBox
            // 
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Items.AddRange(new object[] {
            DEA_Program.Common.Enums.Role.Admin,
            DEA_Program.Common.Enums.Role.User});
            this.roleComboBox.Location = new System.Drawing.Point(390, 229);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(165, 33);
            this.roleComboBox.TabIndex = 3;
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Location = new System.Drawing.Point(261, 229);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(51, 25);
            this.roleLabel.TabIndex = 16;
            this.roleLabel.Text = "Role";
            // 
            // goBackButton
            // 
            this.goBackButton.BackColor = System.Drawing.Color.AliceBlue;
            this.goBackButton.Location = new System.Drawing.Point(664, 392);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(153, 52);
            this.goBackButton.TabIndex = 5;
            this.goBackButton.Text = "Go Back";
            this.goBackButton.UseVisualStyleBackColor = false;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // addUserButton
            // 
            this.addUserButton.BackColor = System.Drawing.Color.AliceBlue;
            this.addUserButton.Location = new System.Drawing.Point(264, 305);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(291, 40);
            this.addUserButton.TabIndex = 4;
            this.addUserButton.Text = "Add User";
            this.addUserButton.UseVisualStyleBackColor = false;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(390, 176);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(167, 30);
            this.passwordTextBox.TabIndex = 2;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(390, 122);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(167, 30);
            this.userNameTextBox.TabIndex = 1;
            // 
            // passwordNameLabel
            // 
            this.passwordNameLabel.AutoSize = true;
            this.passwordNameLabel.Location = new System.Drawing.Point(259, 176);
            this.passwordNameLabel.Name = "passwordNameLabel";
            this.passwordNameLabel.Size = new System.Drawing.Size(98, 25);
            this.passwordNameLabel.TabIndex = 1;
            this.passwordNameLabel.Text = "Password";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(259, 127);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(53, 25);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "User";
            // 
            // allUsersButton
            // 
            this.allUsersButton.BackColor = System.Drawing.Color.AliceBlue;
            this.allUsersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allUsersButton.Location = new System.Drawing.Point(28, 392);
            this.allUsersButton.Name = "allUsersButton";
            this.allUsersButton.Size = new System.Drawing.Size(210, 52);
            this.allUsersButton.TabIndex = 17;
            this.allUsersButton.Text = "Show all Users";
            this.allUsersButton.UseVisualStyleBackColor = false;
            this.allUsersButton.Click += new System.EventHandler(this.allUsersButton_Click);
            // 
            // RegisterUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 661);
            this.Controls.Add(this.registerUserGroupBox);
            this.Name = "RegisterUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterUser";
            this.registerUserGroupBox.ResumeLayout(false);
            this.registerUserGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox registerUserGroupBox;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label passwordNameLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.ComboBox roleComboBox;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Button allUsersButton;
    }
}