
namespace DEA_Program.Console.Pages
{
    partial class CustomControlInfo
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
            this.checkCustomControlGroupBox = new System.Windows.Forms.GroupBox();
            this.foundTextLabel = new System.Windows.Forms.Label();
            this.goBackButton = new System.Windows.Forms.Button();
            this.findCustomControlsButton = new System.Windows.Forms.Button();
            this.customCheckDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.customCheckLabel = new System.Windows.Forms.Label();
            this.infoallCustomControlsGroupBox = new System.Windows.Forms.GroupBox();
            this.foundCustomControlsListView = new System.Windows.Forms.ListView();
            this.ownerIDLabel = new System.Windows.Forms.Label();
            this.checkCustomControlGroupBox.SuspendLayout();
            this.infoallCustomControlsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkCustomControlGroupBox
            // 
            this.checkCustomControlGroupBox.BackColor = System.Drawing.Color.LightBlue;
            this.checkCustomControlGroupBox.Controls.Add(this.foundTextLabel);
            this.checkCustomControlGroupBox.Controls.Add(this.goBackButton);
            this.checkCustomControlGroupBox.Controls.Add(this.findCustomControlsButton);
            this.checkCustomControlGroupBox.Controls.Add(this.customCheckDateTimePicker);
            this.checkCustomControlGroupBox.Controls.Add(this.customCheckLabel);
            this.checkCustomControlGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkCustomControlGroupBox.Location = new System.Drawing.Point(61, 55);
            this.checkCustomControlGroupBox.Name = "checkCustomControlGroupBox";
            this.checkCustomControlGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkCustomControlGroupBox.Size = new System.Drawing.Size(862, 188);
            this.checkCustomControlGroupBox.TabIndex = 5;
            this.checkCustomControlGroupBox.TabStop = false;
            this.checkCustomControlGroupBox.Text = "Check a Custom Control";
            // 
            // foundTextLabel
            // 
            this.foundTextLabel.AutoSize = true;
            this.foundTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.foundTextLabel.Location = new System.Drawing.Point(17, 140);
            this.foundTextLabel.Name = "foundTextLabel";
            this.foundTextLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.foundTextLabel.Size = new System.Drawing.Size(0, 31);
            this.foundTextLabel.TabIndex = 24;
            // 
            // goBackButton
            // 
            this.goBackButton.BackColor = System.Drawing.Color.AliceBlue;
            this.goBackButton.Location = new System.Drawing.Point(695, 19);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(143, 35);
            this.goBackButton.TabIndex = 4;
            this.goBackButton.Text = "Go Back";
            this.goBackButton.UseVisualStyleBackColor = false;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // findCustomControlsButton
            // 
            this.findCustomControlsButton.BackColor = System.Drawing.Color.AliceBlue;
            this.findCustomControlsButton.Location = new System.Drawing.Point(482, 72);
            this.findCustomControlsButton.Name = "findCustomControlsButton";
            this.findCustomControlsButton.Size = new System.Drawing.Size(304, 42);
            this.findCustomControlsButton.TabIndex = 2;
            this.findCustomControlsButton.Text = "Find Custom Control";
            this.findCustomControlsButton.UseVisualStyleBackColor = false;
            this.findCustomControlsButton.Click += new System.EventHandler(this.findCustomControlsButton_Click);
            // 
            // customCheckDateTimePicker
            // 
            this.customCheckDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customCheckDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.customCheckDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.customCheckDateTimePicker.Location = new System.Drawing.Point(248, 81);
            this.customCheckDateTimePicker.Name = "customCheckDateTimePicker";
            this.customCheckDateTimePicker.Size = new System.Drawing.Size(159, 30);
            this.customCheckDateTimePicker.TabIndex = 1;
            // 
            // customCheckLabel
            // 
            this.customCheckLabel.AutoSize = true;
            this.customCheckLabel.Location = new System.Drawing.Point(36, 81);
            this.customCheckLabel.Name = "customCheckLabel";
            this.customCheckLabel.Size = new System.Drawing.Size(188, 25);
            this.customCheckLabel.TabIndex = 13;
            this.customCheckLabel.Text = "Custom Check Date";
            // 
            // infoallCustomControlsGroupBox
            // 
            this.infoallCustomControlsGroupBox.BackColor = System.Drawing.Color.LightBlue;
            this.infoallCustomControlsGroupBox.Controls.Add(this.foundCustomControlsListView);
            this.infoallCustomControlsGroupBox.Controls.Add(this.ownerIDLabel);
            this.infoallCustomControlsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoallCustomControlsGroupBox.Location = new System.Drawing.Point(61, 268);
            this.infoallCustomControlsGroupBox.Name = "infoallCustomControlsGroupBox";
            this.infoallCustomControlsGroupBox.Size = new System.Drawing.Size(862, 340);
            this.infoallCustomControlsGroupBox.TabIndex = 6;
            this.infoallCustomControlsGroupBox.TabStop = false;
            this.infoallCustomControlsGroupBox.Text = "Custom Controls Information";
            this.infoallCustomControlsGroupBox.Visible = false;
            // 
            // foundCustomControlsListView
            // 
            this.foundCustomControlsListView.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.foundCustomControlsListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.foundCustomControlsListView.HideSelection = false;
            this.foundCustomControlsListView.Location = new System.Drawing.Point(28, 44);
            this.foundCustomControlsListView.Name = "foundCustomControlsListView";
            this.foundCustomControlsListView.ShowItemToolTips = true;
            this.foundCustomControlsListView.Size = new System.Drawing.Size(809, 265);
            this.foundCustomControlsListView.TabIndex = 3;
            this.foundCustomControlsListView.UseCompatibleStateImageBehavior = false;
            // 
            // ownerIDLabel
            // 
            this.ownerIDLabel.AutoSize = true;
            this.ownerIDLabel.Location = new System.Drawing.Point(46, 177);
            this.ownerIDLabel.Name = "ownerIDLabel";
            this.ownerIDLabel.Size = new System.Drawing.Size(0, 25);
            this.ownerIDLabel.TabIndex = 19;
            // 
            // CustomControlInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 661);
            this.Controls.Add(this.infoallCustomControlsGroupBox);
            this.Controls.Add(this.checkCustomControlGroupBox);
            this.Name = "CustomControlInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomControlInfo";
            this.checkCustomControlGroupBox.ResumeLayout(false);
            this.checkCustomControlGroupBox.PerformLayout();
            this.infoallCustomControlsGroupBox.ResumeLayout(false);
            this.infoallCustomControlsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox checkCustomControlGroupBox;
        private System.Windows.Forms.Button findCustomControlsButton;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.DateTimePicker customCheckDateTimePicker;
        private System.Windows.Forms.Label customCheckLabel;
        private System.Windows.Forms.GroupBox infoallCustomControlsGroupBox;
        private System.Windows.Forms.Label ownerIDLabel;
        private System.Windows.Forms.Label foundTextLabel;
        private System.Windows.Forms.ListView foundCustomControlsListView;
    }
}