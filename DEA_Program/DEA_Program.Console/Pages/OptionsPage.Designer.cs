
namespace DEA_Program.Console.Pages
{
    partial class OptionsPage
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
            this.optionsGroupBox = new System.Windows.Forms.GroupBox();
            this.goMenuPageButton = new System.Windows.Forms.Button();
            this.reportBugButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.sendReportGroupBox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userTextMessageTextBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.fromWhoTextBox = new System.Windows.Forms.TextBox();
            this.optionsGroupBox.SuspendLayout();
            this.sendReportGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // optionsGroupBox
            // 
            this.optionsGroupBox.BackColor = System.Drawing.Color.LightBlue;
            this.optionsGroupBox.Controls.Add(this.goMenuPageButton);
            this.optionsGroupBox.Controls.Add(this.reportBugButton);
            this.optionsGroupBox.Controls.Add(this.exitButton);
            this.optionsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.optionsGroupBox.Location = new System.Drawing.Point(120, 68);
            this.optionsGroupBox.Name = "optionsGroupBox";
            this.optionsGroupBox.Size = new System.Drawing.Size(398, 411);
            this.optionsGroupBox.TabIndex = 12;
            this.optionsGroupBox.TabStop = false;
            this.optionsGroupBox.Text = "Options";
            // 
            // goMenuPageButton
            // 
            this.goMenuPageButton.BackColor = System.Drawing.Color.AliceBlue;
            this.goMenuPageButton.Location = new System.Drawing.Point(76, 187);
            this.goMenuPageButton.Name = "goMenuPageButton";
            this.goMenuPageButton.Size = new System.Drawing.Size(237, 65);
            this.goMenuPageButton.TabIndex = 2;
            this.goMenuPageButton.Text = "Go to Menu page";
            this.goMenuPageButton.UseVisualStyleBackColor = false;
            this.goMenuPageButton.Click += new System.EventHandler(this.goMenuPageButton_Click);
            // 
            // reportBugButton
            // 
            this.reportBugButton.BackColor = System.Drawing.Color.AliceBlue;
            this.reportBugButton.Location = new System.Drawing.Point(76, 77);
            this.reportBugButton.Name = "reportBugButton";
            this.reportBugButton.Size = new System.Drawing.Size(237, 65);
            this.reportBugButton.TabIndex = 1;
            this.reportBugButton.Text = "Report a Bug";
            this.reportBugButton.UseVisualStyleBackColor = false;
            this.reportBugButton.Click += new System.EventHandler(this.reportBugButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.AliceBlue;
            this.exitButton.Location = new System.Drawing.Point(76, 298);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(237, 65);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // sendReportGroupBox
            // 
            this.sendReportGroupBox.BackColor = System.Drawing.Color.LightBlue;
            this.sendReportGroupBox.Controls.Add(this.panel1);
            this.sendReportGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendReportGroupBox.Location = new System.Drawing.Point(577, 68);
            this.sendReportGroupBox.Name = "sendReportGroupBox";
            this.sendReportGroupBox.Size = new System.Drawing.Size(398, 411);
            this.sendReportGroupBox.TabIndex = 13;
            this.sendReportGroupBox.TabStop = false;
            this.sendReportGroupBox.Text = "Send Report";
            this.sendReportGroupBox.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.fromWhoTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.userTextMessageTextBox);
            this.panel1.Controls.Add(this.sendButton);
            this.panel1.Location = new System.Drawing.Point(50, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 358);
            this.panel1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "Problem description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Write your Name/Email";
            // 
            // userTextMessageTextBox
            // 
            this.userTextMessageTextBox.Location = new System.Drawing.Point(18, 135);
            this.userTextMessageTextBox.Multiline = true;
            this.userTextMessageTextBox.Name = "userTextMessageTextBox";
            this.userTextMessageTextBox.Size = new System.Drawing.Size(237, 144);
            this.userTextMessageTextBox.TabIndex = 8;
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.AliceBlue;
            this.sendButton.Location = new System.Drawing.Point(18, 294);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(237, 43);
            this.sendButton.TabIndex = 1;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // fromWhoTextBox
            // 
            this.fromWhoTextBox.Location = new System.Drawing.Point(19, 64);
            this.fromWhoTextBox.Name = "fromWhoTextBox";
            this.fromWhoTextBox.Size = new System.Drawing.Size(235, 35);
            this.fromWhoTextBox.TabIndex = 12;
            // 
            // OptionsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 661);
            this.Controls.Add(this.sendReportGroupBox);
            this.Controls.Add(this.optionsGroupBox);
            this.Name = "OptionsPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OptionsPage";
            this.optionsGroupBox.ResumeLayout(false);
            this.sendReportGroupBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox optionsGroupBox;
        private System.Windows.Forms.Button goMenuPageButton;
        private System.Windows.Forms.Button reportBugButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox sendReportGroupBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userTextMessageTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fromWhoTextBox;
    }
}