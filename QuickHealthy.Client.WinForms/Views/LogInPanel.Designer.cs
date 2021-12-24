
namespace QuickHealthy.PL.Views
{
    partial class LogInPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
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
        private void InitializeComponent() {
            this.LogInTabControl = new System.Windows.Forms.TabControl();
            this.PatientTab = new System.Windows.Forms.TabPage();
            this.PatientLogInSplitContainer = new System.Windows.Forms.SplitContainer();
            this.PatientLogInButton = new System.Windows.Forms.Button();
            this.PatientLogInPasswordTextBox = new System.Windows.Forms.TextBox();
            this.PatientLogInUsernameTextBox = new System.Windows.Forms.TextBox();
            this.PatientLogInPasswordLabel = new System.Windows.Forms.Label();
            this.PatientLogInUsernameLabel = new System.Windows.Forms.Label();
            this.PatientRegisterButton = new System.Windows.Forms.Button();
            this.PatientRegistrationBirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.PatientRegistrationPasswordTextBox = new System.Windows.Forms.TextBox();
            this.PatientRegistrationUsernameTextBox = new System.Windows.Forms.TextBox();
            this.PatientRegistrationCityTextBox = new System.Windows.Forms.TextBox();
            this.PatientRegistrationLastNameTextBox = new System.Windows.Forms.TextBox();
            this.PatientRegistrationFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.PatientRegistrationPasswordLabel = new System.Windows.Forms.Label();
            this.PatientRegistrationUsernameLabel = new System.Windows.Forms.Label();
            this.PatientRegistrationBirthDateLabel = new System.Windows.Forms.Label();
            this.PatientRegistrationCityOfBirthLabel = new System.Windows.Forms.Label();
            this.PatientRegistrationLastNameLabel = new System.Windows.Forms.Label();
            this.PatientRegistrationFirstNameLabel = new System.Windows.Forms.Label();
            this.DoctorTab = new System.Windows.Forms.TabPage();
            this.OpenDoctorPanelButton = new System.Windows.Forms.Button();
            this.DoctorIdTextBox = new System.Windows.Forms.TextBox();
            this.DoctorIdLabel = new System.Windows.Forms.Label();
            this.AdminTab = new System.Windows.Forms.TabPage();
            this.OpenAdminPanelButton = new System.Windows.Forms.Button();
            this.LogInTabControl.SuspendLayout();
            this.PatientTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientLogInSplitContainer)).BeginInit();
            this.PatientLogInSplitContainer.Panel1.SuspendLayout();
            this.PatientLogInSplitContainer.Panel2.SuspendLayout();
            this.PatientLogInSplitContainer.SuspendLayout();
            this.DoctorTab.SuspendLayout();
            this.AdminTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogInTabControl
            // 
            this.LogInTabControl.Controls.Add(this.PatientTab);
            this.LogInTabControl.Controls.Add(this.DoctorTab);
            this.LogInTabControl.Controls.Add(this.AdminTab);
            this.LogInTabControl.Location = new System.Drawing.Point(0, 0);
            this.LogInTabControl.Name = "LogInTabControl";
            this.LogInTabControl.SelectedIndex = 0;
            this.LogInTabControl.Size = new System.Drawing.Size(795, 445);
            this.LogInTabControl.TabIndex = 0;
            // 
            // PatientTab
            // 
            this.PatientTab.Controls.Add(this.PatientLogInSplitContainer);
            this.PatientTab.Location = new System.Drawing.Point(4, 29);
            this.PatientTab.Name = "PatientTab";
            this.PatientTab.Padding = new System.Windows.Forms.Padding(3);
            this.PatientTab.Size = new System.Drawing.Size(787, 412);
            this.PatientTab.TabIndex = 0;
            this.PatientTab.Text = "Patient";
            this.PatientTab.UseVisualStyleBackColor = true;
            // 
            // PatientLogInSplitContainer
            // 
            this.PatientLogInSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PatientLogInSplitContainer.Location = new System.Drawing.Point(3, 3);
            this.PatientLogInSplitContainer.Name = "PatientLogInSplitContainer";
            // 
            // PatientLogInSplitContainer.Panel1
            // 
            this.PatientLogInSplitContainer.Panel1.Controls.Add(this.PatientLogInButton);
            this.PatientLogInSplitContainer.Panel1.Controls.Add(this.PatientLogInPasswordTextBox);
            this.PatientLogInSplitContainer.Panel1.Controls.Add(this.PatientLogInUsernameTextBox);
            this.PatientLogInSplitContainer.Panel1.Controls.Add(this.PatientLogInPasswordLabel);
            this.PatientLogInSplitContainer.Panel1.Controls.Add(this.PatientLogInUsernameLabel);
            // 
            // PatientLogInSplitContainer.Panel2
            // 
            this.PatientLogInSplitContainer.Panel2.Controls.Add(this.PatientRegisterButton);
            this.PatientLogInSplitContainer.Panel2.Controls.Add(this.PatientRegistrationBirthDatePicker);
            this.PatientLogInSplitContainer.Panel2.Controls.Add(this.PatientRegistrationPasswordTextBox);
            this.PatientLogInSplitContainer.Panel2.Controls.Add(this.PatientRegistrationUsernameTextBox);
            this.PatientLogInSplitContainer.Panel2.Controls.Add(this.PatientRegistrationCityTextBox);
            this.PatientLogInSplitContainer.Panel2.Controls.Add(this.PatientRegistrationLastNameTextBox);
            this.PatientLogInSplitContainer.Panel2.Controls.Add(this.PatientRegistrationFirstNameTextBox);
            this.PatientLogInSplitContainer.Panel2.Controls.Add(this.PatientRegistrationPasswordLabel);
            this.PatientLogInSplitContainer.Panel2.Controls.Add(this.PatientRegistrationUsernameLabel);
            this.PatientLogInSplitContainer.Panel2.Controls.Add(this.PatientRegistrationBirthDateLabel);
            this.PatientLogInSplitContainer.Panel2.Controls.Add(this.PatientRegistrationCityOfBirthLabel);
            this.PatientLogInSplitContainer.Panel2.Controls.Add(this.PatientRegistrationLastNameLabel);
            this.PatientLogInSplitContainer.Panel2.Controls.Add(this.PatientRegistrationFirstNameLabel);
            this.PatientLogInSplitContainer.Size = new System.Drawing.Size(781, 406);
            this.PatientLogInSplitContainer.SplitterDistance = 325;
            this.PatientLogInSplitContainer.TabIndex = 0;
            // 
            // PatientLogInButton
            // 
            this.PatientLogInButton.Location = new System.Drawing.Point(61, 235);
            this.PatientLogInButton.Name = "PatientLogInButton";
            this.PatientLogInButton.Size = new System.Drawing.Size(218, 40);
            this.PatientLogInButton.TabIndex = 5;
            this.PatientLogInButton.Text = "Log in";
            this.PatientLogInButton.UseVisualStyleBackColor = true;
            this.PatientLogInButton.Click += new System.EventHandler(this.PatientLogInButton_Click);
            // 
            // PatientLogInPasswordTextBox
            // 
            this.PatientLogInPasswordTextBox.Location = new System.Drawing.Point(139, 187);
            this.PatientLogInPasswordTextBox.Name = "PatientLogInPasswordTextBox";
            this.PatientLogInPasswordTextBox.Size = new System.Drawing.Size(140, 27);
            this.PatientLogInPasswordTextBox.TabIndex = 4;
            // 
            // PatientLogInUsernameTextBox
            // 
            this.PatientLogInUsernameTextBox.Location = new System.Drawing.Point(148, 137);
            this.PatientLogInUsernameTextBox.Name = "PatientLogInUsernameTextBox";
            this.PatientLogInUsernameTextBox.Size = new System.Drawing.Size(131, 27);
            this.PatientLogInUsernameTextBox.TabIndex = 3;
            // 
            // PatientLogInPasswordLabel
            // 
            this.PatientLogInPasswordLabel.AutoSize = true;
            this.PatientLogInPasswordLabel.Location = new System.Drawing.Point(60, 190);
            this.PatientLogInPasswordLabel.Name = "PatientLogInPasswordLabel";
            this.PatientLogInPasswordLabel.Size = new System.Drawing.Size(73, 20);
            this.PatientLogInPasswordLabel.TabIndex = 2;
            this.PatientLogInPasswordLabel.Text = "Password:";
            // 
            // PatientLogInUsernameLabel
            // 
            this.PatientLogInUsernameLabel.AutoSize = true;
            this.PatientLogInUsernameLabel.Location = new System.Drawing.Point(60, 140);
            this.PatientLogInUsernameLabel.Name = "PatientLogInUsernameLabel";
            this.PatientLogInUsernameLabel.Size = new System.Drawing.Size(82, 20);
            this.PatientLogInUsernameLabel.TabIndex = 1;
            this.PatientLogInUsernameLabel.Text = "Username: ";
            // 
            // PatientRegisterButton
            // 
            this.PatientRegisterButton.Location = new System.Drawing.Point(75, 270);
            this.PatientRegisterButton.Name = "PatientRegisterButton";
            this.PatientRegisterButton.Size = new System.Drawing.Size(297, 40);
            this.PatientRegisterButton.TabIndex = 12;
            this.PatientRegisterButton.Text = "Register";
            this.PatientRegisterButton.UseVisualStyleBackColor = true;
            this.PatientRegisterButton.Click += new System.EventHandler(this.PatientRegisterButton_Click);
            // 
            // PatientRegistrationBirthDatePicker
            // 
            this.PatientRegistrationBirthDatePicker.CustomFormat = "dd.MM.yyyy";
            this.PatientRegistrationBirthDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.PatientRegistrationBirthDatePicker.Location = new System.Drawing.Point(158, 140);
            this.PatientRegistrationBirthDatePicker.Name = "PatientRegistrationBirthDatePicker";
            this.PatientRegistrationBirthDatePicker.Size = new System.Drawing.Size(214, 27);
            this.PatientRegistrationBirthDatePicker.TabIndex = 11;
            // 
            // PatientRegistrationPasswordTextBox
            // 
            this.PatientRegistrationPasswordTextBox.Location = new System.Drawing.Point(158, 222);
            this.PatientRegistrationPasswordTextBox.Name = "PatientRegistrationPasswordTextBox";
            this.PatientRegistrationPasswordTextBox.Size = new System.Drawing.Size(214, 27);
            this.PatientRegistrationPasswordTextBox.TabIndex = 10;
            // 
            // PatientRegistrationUsernameTextBox
            // 
            this.PatientRegistrationUsernameTextBox.Location = new System.Drawing.Point(163, 182);
            this.PatientRegistrationUsernameTextBox.Name = "PatientRegistrationUsernameTextBox";
            this.PatientRegistrationUsernameTextBox.Size = new System.Drawing.Size(209, 27);
            this.PatientRegistrationUsernameTextBox.TabIndex = 9;
            // 
            // PatientRegistrationCityTextBox
            // 
            this.PatientRegistrationCityTextBox.Location = new System.Drawing.Point(175, 102);
            this.PatientRegistrationCityTextBox.Name = "PatientRegistrationCityTextBox";
            this.PatientRegistrationCityTextBox.Size = new System.Drawing.Size(197, 27);
            this.PatientRegistrationCityTextBox.TabIndex = 8;
            // 
            // PatientRegistrationLastNameTextBox
            // 
            this.PatientRegistrationLastNameTextBox.Location = new System.Drawing.Point(164, 62);
            this.PatientRegistrationLastNameTextBox.Name = "PatientRegistrationLastNameTextBox";
            this.PatientRegistrationLastNameTextBox.Size = new System.Drawing.Size(208, 27);
            this.PatientRegistrationLastNameTextBox.TabIndex = 7;
            // 
            // PatientRegistrationFirstNameTextBox
            // 
            this.PatientRegistrationFirstNameTextBox.Location = new System.Drawing.Point(165, 22);
            this.PatientRegistrationFirstNameTextBox.Name = "PatientRegistrationFirstNameTextBox";
            this.PatientRegistrationFirstNameTextBox.Size = new System.Drawing.Size(207, 27);
            this.PatientRegistrationFirstNameTextBox.TabIndex = 6;
            // 
            // PatientRegistrationPasswordLabel
            // 
            this.PatientRegistrationPasswordLabel.AutoSize = true;
            this.PatientRegistrationPasswordLabel.Location = new System.Drawing.Point(75, 225);
            this.PatientRegistrationPasswordLabel.Name = "PatientRegistrationPasswordLabel";
            this.PatientRegistrationPasswordLabel.Size = new System.Drawing.Size(77, 20);
            this.PatientRegistrationPasswordLabel.TabIndex = 5;
            this.PatientRegistrationPasswordLabel.Text = "Password: ";
            // 
            // PatientRegistrationUsernameLabel
            // 
            this.PatientRegistrationUsernameLabel.AutoSize = true;
            this.PatientRegistrationUsernameLabel.Location = new System.Drawing.Point(75, 185);
            this.PatientRegistrationUsernameLabel.Name = "PatientRegistrationUsernameLabel";
            this.PatientRegistrationUsernameLabel.Size = new System.Drawing.Size(82, 20);
            this.PatientRegistrationUsernameLabel.TabIndex = 4;
            this.PatientRegistrationUsernameLabel.Text = "Username: ";
            // 
            // PatientRegistrationBirthDateLabel
            // 
            this.PatientRegistrationBirthDateLabel.AutoSize = true;
            this.PatientRegistrationBirthDateLabel.Location = new System.Drawing.Point(75, 145);
            this.PatientRegistrationBirthDateLabel.Name = "PatientRegistrationBirthDateLabel";
            this.PatientRegistrationBirthDateLabel.Size = new System.Drawing.Size(77, 20);
            this.PatientRegistrationBirthDateLabel.TabIndex = 3;
            this.PatientRegistrationBirthDateLabel.Text = "Birth date:";
            // 
            // PatientRegistrationCityOfBirthLabel
            // 
            this.PatientRegistrationCityOfBirthLabel.AutoSize = true;
            this.PatientRegistrationCityOfBirthLabel.Location = new System.Drawing.Point(75, 105);
            this.PatientRegistrationCityOfBirthLabel.Name = "PatientRegistrationCityOfBirthLabel";
            this.PatientRegistrationCityOfBirthLabel.Size = new System.Drawing.Size(94, 20);
            this.PatientRegistrationCityOfBirthLabel.TabIndex = 2;
            this.PatientRegistrationCityOfBirthLabel.Text = "City of birth: ";
            // 
            // PatientRegistrationLastNameLabel
            // 
            this.PatientRegistrationLastNameLabel.AutoSize = true;
            this.PatientRegistrationLastNameLabel.Location = new System.Drawing.Point(75, 65);
            this.PatientRegistrationLastNameLabel.Name = "PatientRegistrationLastNameLabel";
            this.PatientRegistrationLastNameLabel.Size = new System.Drawing.Size(83, 20);
            this.PatientRegistrationLastNameLabel.TabIndex = 1;
            this.PatientRegistrationLastNameLabel.Text = "Last name: ";
            // 
            // PatientRegistrationFirstNameLabel
            // 
            this.PatientRegistrationFirstNameLabel.AutoSize = true;
            this.PatientRegistrationFirstNameLabel.Location = new System.Drawing.Point(75, 25);
            this.PatientRegistrationFirstNameLabel.Name = "PatientRegistrationFirstNameLabel";
            this.PatientRegistrationFirstNameLabel.Size = new System.Drawing.Size(84, 20);
            this.PatientRegistrationFirstNameLabel.TabIndex = 0;
            this.PatientRegistrationFirstNameLabel.Text = "First name: ";
            // 
            // DoctorTab
            // 
            this.DoctorTab.Controls.Add(this.OpenDoctorPanelButton);
            this.DoctorTab.Controls.Add(this.DoctorIdTextBox);
            this.DoctorTab.Controls.Add(this.DoctorIdLabel);
            this.DoctorTab.Location = new System.Drawing.Point(4, 29);
            this.DoctorTab.Name = "DoctorTab";
            this.DoctorTab.Padding = new System.Windows.Forms.Padding(3);
            this.DoctorTab.Size = new System.Drawing.Size(787, 412);
            this.DoctorTab.TabIndex = 1;
            this.DoctorTab.Text = "Doctor";
            this.DoctorTab.UseVisualStyleBackColor = true;
            // 
            // OpenDoctorPanelButton
            // 
            this.OpenDoctorPanelButton.Location = new System.Drawing.Point(15, 55);
            this.OpenDoctorPanelButton.Name = "OpenDoctorPanelButton";
            this.OpenDoctorPanelButton.Size = new System.Drawing.Size(210, 46);
            this.OpenDoctorPanelButton.TabIndex = 2;
            this.OpenDoctorPanelButton.Text = "Open doctor panel";
            this.OpenDoctorPanelButton.UseVisualStyleBackColor = true;
            this.OpenDoctorPanelButton.Click += new System.EventHandler(this.OpenDoctorPanelButton_Click);
            // 
            // DoctorIdTextBox
            // 
            this.DoctorIdTextBox.Location = new System.Drawing.Point(100, 12);
            this.DoctorIdTextBox.Name = "DoctorIdTextBox";
            this.DoctorIdTextBox.Size = new System.Drawing.Size(125, 27);
            this.DoctorIdTextBox.TabIndex = 1;
            // 
            // DoctorIdLabel
            // 
            this.DoctorIdLabel.AutoSize = true;
            this.DoctorIdLabel.Location = new System.Drawing.Point(15, 15);
            this.DoctorIdLabel.Name = "DoctorIdLabel";
            this.DoctorIdLabel.Size = new System.Drawing.Size(79, 20);
            this.DoctorIdLabel.TabIndex = 0;
            this.DoctorIdLabel.Text = "Doctor id: ";
            // 
            // AdminTab
            // 
            this.AdminTab.Controls.Add(this.OpenAdminPanelButton);
            this.AdminTab.Location = new System.Drawing.Point(4, 29);
            this.AdminTab.Name = "AdminTab";
            this.AdminTab.Padding = new System.Windows.Forms.Padding(3);
            this.AdminTab.Size = new System.Drawing.Size(787, 412);
            this.AdminTab.TabIndex = 2;
            this.AdminTab.Text = "Admin";
            this.AdminTab.UseVisualStyleBackColor = true;
            // 
            // OpenAdminPanelButton
            // 
            this.OpenAdminPanelButton.Location = new System.Drawing.Point(293, 176);
            this.OpenAdminPanelButton.Name = "OpenAdminPanelButton";
            this.OpenAdminPanelButton.Size = new System.Drawing.Size(200, 60);
            this.OpenAdminPanelButton.TabIndex = 0;
            this.OpenAdminPanelButton.Text = "Open admin panel";
            this.OpenAdminPanelButton.UseVisualStyleBackColor = true;
            this.OpenAdminPanelButton.Click += new System.EventHandler(this.OpenAdminPanelButton_Click);
            // 
            // LogInPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogInTabControl);
            this.Name = "LogInPanel";
            this.Text = "LogInPanel";
            this.LogInTabControl.ResumeLayout(false);
            this.PatientTab.ResumeLayout(false);
            this.PatientLogInSplitContainer.Panel1.ResumeLayout(false);
            this.PatientLogInSplitContainer.Panel1.PerformLayout();
            this.PatientLogInSplitContainer.Panel2.ResumeLayout(false);
            this.PatientLogInSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientLogInSplitContainer)).EndInit();
            this.PatientLogInSplitContainer.ResumeLayout(false);
            this.DoctorTab.ResumeLayout(false);
            this.DoctorTab.PerformLayout();
            this.AdminTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl LogInTabControl;
        private System.Windows.Forms.TabPage PatientTab;
        private System.Windows.Forms.SplitContainer PatientLogInSplitContainer;
        private System.Windows.Forms.TextBox PatientLogInPasswordTextBox;
        private System.Windows.Forms.TextBox PatientLogInUsernameTextBox;
        private System.Windows.Forms.Label PatientLogInPasswordLabel;
        private System.Windows.Forms.Label PatientLogInUsernameLabel;
        private System.Windows.Forms.Label PatientRegistrationBirthDateLabel;
        private System.Windows.Forms.Label PatientRegistrationCityOfBirthLabel;
        private System.Windows.Forms.Label PatientRegistrationLastNameLabel;
        private System.Windows.Forms.Label PatientRegistrationFirstNameLabel;
        private System.Windows.Forms.TabPage DoctorTab;
        private System.Windows.Forms.Button OpenDoctorPanelButton;
        private System.Windows.Forms.TextBox DoctorIdTextBox;
        private System.Windows.Forms.Label DoctorIdLabel;
        private System.Windows.Forms.TabPage AdminTab;
        private System.Windows.Forms.Button OpenAdminPanelButton;
        private System.Windows.Forms.Label PatientRegistrationPasswordLabel;
        private System.Windows.Forms.Label PatientRegistrationUsernameLabel;
        private System.Windows.Forms.Button PatientLogInButton;
        private System.Windows.Forms.Button PatientRegisterButton;
        private System.Windows.Forms.DateTimePicker PatientRegistrationBirthDatePicker;
        private System.Windows.Forms.TextBox PatientRegistrationPasswordTextBox;
        private System.Windows.Forms.TextBox PatientRegistrationUsernameTextBox;
        private System.Windows.Forms.TextBox PatientRegistrationCityTextBox;
        private System.Windows.Forms.TextBox PatientRegistrationLastNameTextBox;
        private System.Windows.Forms.TextBox PatientRegistrationFirstNameTextBox;
    }
}