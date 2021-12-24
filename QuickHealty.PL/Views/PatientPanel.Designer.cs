
namespace QuickHealthy.PL.Views
{
    partial class PatientPanel
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
            this.PatientTabControl = new System.Windows.Forms.TabControl();
            this.MakeAnAppointmentTab = new System.Windows.Forms.TabPage();
            this.CreateAppointmentButton = new System.Windows.Forms.Button();
            this.AppointmentTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AppointmentTimeLabel = new System.Windows.Forms.Label();
            this.AppointmentDatePicker = new System.Windows.Forms.DateTimePicker();
            this.AppointmentDateTimeLabel = new System.Windows.Forms.Label();
            this.DoctorDataLabel = new System.Windows.Forms.Label();
            this.ChooseDoctorButton = new System.Windows.Forms.Button();
            this.DoctorsListBox = new System.Windows.Forms.ListBox();
            this.PatientAppointmentsTab = new System.Windows.Forms.TabPage();
            this.AppointmentsDataGrid = new System.Windows.Forms.DataGridView();
            this.IdAppointmentsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiagnisisColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientsAppointmentsRefleshButton = new System.Windows.Forms.Button();
            this.PersonalInformationTab = new System.Windows.Forms.TabPage();
            this.PersonalInfoSplitContainer = new System.Windows.Forms.SplitContainer();
            this.PatientMedicalCardIdValueLabel = new System.Windows.Forms.Label();
            this.PatientBirthDateValueLabel = new System.Windows.Forms.Label();
            this.PatientCityOfBirthValueLabel = new System.Windows.Forms.Label();
            this.PatientLastNameValueLabel = new System.Windows.Forms.Label();
            this.PatientFirstNameValueLabel = new System.Windows.Forms.Label();
            this.PatientMedicalCardIdLabel = new System.Windows.Forms.Label();
            this.PatientBirthDateLabel = new System.Windows.Forms.Label();
            this.PatientCityOfBirthLabel = new System.Windows.Forms.Label();
            this.PatientLastNameLabel = new System.Windows.Forms.Label();
            this.PatientFirstNameLabel = new System.Windows.Forms.Label();
            this.PatientAppointmentTimeValueLabel = new System.Windows.Forms.Label();
            this.PatientAppointmentTimeLabel = new System.Windows.Forms.Label();
            this.PatientAppointmentDateValueLabel = new System.Windows.Forms.Label();
            this.PatientAppointmentDateLabel = new System.Windows.Forms.Label();
            this.PatientDoctorValueLabel = new System.Windows.Forms.Label();
            this.PatientDoctorLabel = new System.Windows.Forms.Label();
            this.PatientDiagnosisValueLabel = new System.Windows.Forms.Label();
            this.PatientDiagnosisLabel = new System.Windows.Forms.Label();
            this.PatientTabControl.SuspendLayout();
            this.MakeAnAppointmentTab.SuspendLayout();
            this.PatientAppointmentsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsDataGrid)).BeginInit();
            this.PersonalInformationTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonalInfoSplitContainer)).BeginInit();
            this.PersonalInfoSplitContainer.Panel1.SuspendLayout();
            this.PersonalInfoSplitContainer.Panel2.SuspendLayout();
            this.PersonalInfoSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // PatientTabControl
            // 
            this.PatientTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PatientTabControl.Controls.Add(this.MakeAnAppointmentTab);
            this.PatientTabControl.Controls.Add(this.PatientAppointmentsTab);
            this.PatientTabControl.Controls.Add(this.PersonalInformationTab);
            this.PatientTabControl.Location = new System.Drawing.Point(0, 0);
            this.PatientTabControl.Name = "PatientTabControl";
            this.PatientTabControl.SelectedIndex = 0;
            this.PatientTabControl.Size = new System.Drawing.Size(901, 445);
            this.PatientTabControl.TabIndex = 0;
            // 
            // MakeAnAppointmentTab
            // 
            this.MakeAnAppointmentTab.Controls.Add(this.CreateAppointmentButton);
            this.MakeAnAppointmentTab.Controls.Add(this.AppointmentTimePicker);
            this.MakeAnAppointmentTab.Controls.Add(this.AppointmentTimeLabel);
            this.MakeAnAppointmentTab.Controls.Add(this.AppointmentDatePicker);
            this.MakeAnAppointmentTab.Controls.Add(this.AppointmentDateTimeLabel);
            this.MakeAnAppointmentTab.Controls.Add(this.DoctorDataLabel);
            this.MakeAnAppointmentTab.Controls.Add(this.ChooseDoctorButton);
            this.MakeAnAppointmentTab.Controls.Add(this.DoctorsListBox);
            this.MakeAnAppointmentTab.Location = new System.Drawing.Point(4, 29);
            this.MakeAnAppointmentTab.Name = "MakeAnAppointmentTab";
            this.MakeAnAppointmentTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.MakeAnAppointmentTab.Size = new System.Drawing.Size(893, 412);
            this.MakeAnAppointmentTab.TabIndex = 2;
            this.MakeAnAppointmentTab.Text = "Make an appointment";
            this.MakeAnAppointmentTab.UseVisualStyleBackColor = true;
            // 
            // CreateAppointmentButton
            // 
            this.CreateAppointmentButton.Location = new System.Drawing.Point(570, 365);
            this.CreateAppointmentButton.Name = "CreateAppointmentButton";
            this.CreateAppointmentButton.Size = new System.Drawing.Size(205, 37);
            this.CreateAppointmentButton.TabIndex = 7;
            this.CreateAppointmentButton.Text = "Make an appointment";
            this.CreateAppointmentButton.UseVisualStyleBackColor = true;
            this.CreateAppointmentButton.Click += new System.EventHandler(this.CreateAppointmentButton_Click);
            // 
            // AppointmentTimePicker
            // 
            this.AppointmentTimePicker.CustomFormat = "HH:mm";
            this.AppointmentTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AppointmentTimePicker.Location = new System.Drawing.Point(65, 327);
            this.AppointmentTimePicker.MinDate = new System.DateTime(2021, 12, 13, 23, 38, 3, 0);
            this.AppointmentTimePicker.Name = "AppointmentTimePicker";
            this.AppointmentTimePicker.ShowUpDown = true;
            this.AppointmentTimePicker.Size = new System.Drawing.Size(167, 27);
            this.AppointmentTimePicker.TabIndex = 6;
            this.AppointmentTimePicker.Value = new System.DateTime(2021, 12, 14, 0, 0, 0, 0);
            // 
            // AppointmentTimeLabel
            // 
            this.AppointmentTimeLabel.AutoSize = true;
            this.AppointmentTimeLabel.Location = new System.Drawing.Point(11, 332);
            this.AppointmentTimeLabel.Name = "AppointmentTimeLabel";
            this.AppointmentTimeLabel.Size = new System.Drawing.Size(49, 20);
            this.AppointmentTimeLabel.TabIndex = 5;
            this.AppointmentTimeLabel.Text = "Time: ";
            // 
            // AppointmentDatePicker
            // 
            this.AppointmentDatePicker.CustomFormat = "ddd dd MMM yyyy";
            this.AppointmentDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AppointmentDatePicker.Location = new System.Drawing.Point(65, 283);
            this.AppointmentDatePicker.MinDate = new System.DateTime(2021, 12, 13, 23, 38, 3, 0);
            this.AppointmentDatePicker.Name = "AppointmentDatePicker";
            this.AppointmentDatePicker.Size = new System.Drawing.Size(167, 27);
            this.AppointmentDatePicker.TabIndex = 4;
            this.AppointmentDatePicker.Value = new System.DateTime(2021, 12, 14, 0, 0, 0, 0);
            // 
            // AppointmentDateTimeLabel
            // 
            this.AppointmentDateTimeLabel.AutoSize = true;
            this.AppointmentDateTimeLabel.Location = new System.Drawing.Point(11, 287);
            this.AppointmentDateTimeLabel.Name = "AppointmentDateTimeLabel";
            this.AppointmentDateTimeLabel.Size = new System.Drawing.Size(48, 20);
            this.AppointmentDateTimeLabel.TabIndex = 3;
            this.AppointmentDateTimeLabel.Text = "Date: ";
            // 
            // DoctorDataLabel
            // 
            this.DoctorDataLabel.AutoSize = true;
            this.DoctorDataLabel.Location = new System.Drawing.Point(8, 235);
            this.DoctorDataLabel.Name = "DoctorDataLabel";
            this.DoctorDataLabel.Size = new System.Drawing.Size(146, 20);
            this.DoctorDataLabel.TabIndex = 2;
            this.DoctorDataLabel.Text = "Doctor: not selected.";
            // 
            // ChooseDoctorButton
            // 
            this.ChooseDoctorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChooseDoctorButton.Location = new System.Drawing.Point(792, 0);
            this.ChooseDoctorButton.Name = "ChooseDoctorButton";
            this.ChooseDoctorButton.Size = new System.Drawing.Size(97, 221);
            this.ChooseDoctorButton.TabIndex = 1;
            this.ChooseDoctorButton.Text = "Choose";
            this.ChooseDoctorButton.UseVisualStyleBackColor = true;
            this.ChooseDoctorButton.Click += new System.EventHandler(this.ChooseDoctorButton_Click);
            // 
            // DoctorsListBox
            // 
            this.DoctorsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DoctorsListBox.FormattingEnabled = true;
            this.DoctorsListBox.ItemHeight = 20;
            this.DoctorsListBox.Location = new System.Drawing.Point(0, 0);
            this.DoctorsListBox.Name = "DoctorsListBox";
            this.DoctorsListBox.Size = new System.Drawing.Size(684, 222);
            this.DoctorsListBox.TabIndex = 0;
            // 
            // PatientAppointmentsTab
            // 
            this.PatientAppointmentsTab.Controls.Add(this.AppointmentsDataGrid);
            this.PatientAppointmentsTab.Controls.Add(this.PatientsAppointmentsRefleshButton);
            this.PatientAppointmentsTab.Location = new System.Drawing.Point(4, 29);
            this.PatientAppointmentsTab.Name = "PatientAppointmentsTab";
            this.PatientAppointmentsTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.PatientAppointmentsTab.Size = new System.Drawing.Size(893, 412);
            this.PatientAppointmentsTab.TabIndex = 0;
            this.PatientAppointmentsTab.Text = "My appointments";
            this.PatientAppointmentsTab.UseVisualStyleBackColor = true;
            // 
            // AppointmentsDataGrid
            // 
            this.AppointmentsDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AppointmentsDataGrid.ColumnHeadersHeight = 29;
            this.AppointmentsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAppointmentsColumn,
            this.DoctorColumn,
            this.DiagnisisColumn,
            this.DateColumn,
            this.TimeColumn});
            this.AppointmentsDataGrid.Location = new System.Drawing.Point(7, 0);
            this.AppointmentsDataGrid.Name = "AppointmentsDataGrid";
            this.AppointmentsDataGrid.RowHeadersWidth = 51;
            this.AppointmentsDataGrid.RowTemplate.Height = 29;
            this.AppointmentsDataGrid.Size = new System.Drawing.Size(882, 341);
            this.AppointmentsDataGrid.TabIndex = 2;
            // 
            // IdAppointmentsColumn
            // 
            this.IdAppointmentsColumn.HeaderText = "Id";
            this.IdAppointmentsColumn.MinimumWidth = 6;
            this.IdAppointmentsColumn.Name = "IdAppointmentsColumn";
            this.IdAppointmentsColumn.Width = 40;
            // 
            // DoctorColumn
            // 
            this.DoctorColumn.HeaderText = "Doctor";
            this.DoctorColumn.MinimumWidth = 6;
            this.DoctorColumn.Name = "DoctorColumn";
            this.DoctorColumn.Width = 240;
            // 
            // DiagnisisColumn
            // 
            this.DiagnisisColumn.HeaderText = "Diagnosis";
            this.DiagnisisColumn.MinimumWidth = 6;
            this.DiagnisisColumn.Name = "DiagnisisColumn";
            this.DiagnisisColumn.Width = 190;
            // 
            // DateColumn
            // 
            this.DateColumn.HeaderText = "Date";
            this.DateColumn.MinimumWidth = 6;
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.Width = 125;
            // 
            // TimeColumn
            // 
            this.TimeColumn.HeaderText = "Time";
            this.TimeColumn.MinimumWidth = 6;
            this.TimeColumn.Name = "TimeColumn";
            this.TimeColumn.Width = 125;
            // 
            // PatientsAppointmentsRefleshButton
            // 
            this.PatientsAppointmentsRefleshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PatientsAppointmentsRefleshButton.Location = new System.Drawing.Point(682, 363);
            this.PatientsAppointmentsRefleshButton.Name = "PatientsAppointmentsRefleshButton";
            this.PatientsAppointmentsRefleshButton.Size = new System.Drawing.Size(202, 43);
            this.PatientsAppointmentsRefleshButton.TabIndex = 1;
            this.PatientsAppointmentsRefleshButton.Text = "Reflesh";
            this.PatientsAppointmentsRefleshButton.UseVisualStyleBackColor = true;
            this.PatientsAppointmentsRefleshButton.Click += new System.EventHandler(this.PatientsAppointmentsRefleshButton_Click);
            // 
            // PersonalInformationTab
            // 
            this.PersonalInformationTab.Controls.Add(this.PersonalInfoSplitContainer);
            this.PersonalInformationTab.Location = new System.Drawing.Point(4, 29);
            this.PersonalInformationTab.Name = "PersonalInformationTab";
            this.PersonalInformationTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.PersonalInformationTab.Size = new System.Drawing.Size(893, 412);
            this.PersonalInformationTab.TabIndex = 1;
            this.PersonalInformationTab.Text = "Personal information";
            this.PersonalInformationTab.UseVisualStyleBackColor = true;
            // 
            // PersonalInfoSplitContainer
            // 
            this.PersonalInfoSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PersonalInfoSplitContainer.Location = new System.Drawing.Point(3, 3);
            this.PersonalInfoSplitContainer.Name = "PersonalInfoSplitContainer";
            // 
            // PersonalInfoSplitContainer.Panel1
            // 
            this.PersonalInfoSplitContainer.Panel1.Controls.Add(this.PatientMedicalCardIdValueLabel);
            this.PersonalInfoSplitContainer.Panel1.Controls.Add(this.PatientBirthDateValueLabel);
            this.PersonalInfoSplitContainer.Panel1.Controls.Add(this.PatientCityOfBirthValueLabel);
            this.PersonalInfoSplitContainer.Panel1.Controls.Add(this.PatientLastNameValueLabel);
            this.PersonalInfoSplitContainer.Panel1.Controls.Add(this.PatientFirstNameValueLabel);
            this.PersonalInfoSplitContainer.Panel1.Controls.Add(this.PatientMedicalCardIdLabel);
            this.PersonalInfoSplitContainer.Panel1.Controls.Add(this.PatientBirthDateLabel);
            this.PersonalInfoSplitContainer.Panel1.Controls.Add(this.PatientCityOfBirthLabel);
            this.PersonalInfoSplitContainer.Panel1.Controls.Add(this.PatientLastNameLabel);
            this.PersonalInfoSplitContainer.Panel1.Controls.Add(this.PatientFirstNameLabel);
            // 
            // PersonalInfoSplitContainer.Panel2
            // 
            this.PersonalInfoSplitContainer.Panel2.Controls.Add(this.PatientAppointmentTimeValueLabel);
            this.PersonalInfoSplitContainer.Panel2.Controls.Add(this.PatientAppointmentTimeLabel);
            this.PersonalInfoSplitContainer.Panel2.Controls.Add(this.PatientAppointmentDateValueLabel);
            this.PersonalInfoSplitContainer.Panel2.Controls.Add(this.PatientAppointmentDateLabel);
            this.PersonalInfoSplitContainer.Panel2.Controls.Add(this.PatientDoctorValueLabel);
            this.PersonalInfoSplitContainer.Panel2.Controls.Add(this.PatientDoctorLabel);
            this.PersonalInfoSplitContainer.Panel2.Controls.Add(this.PatientDiagnosisValueLabel);
            this.PersonalInfoSplitContainer.Panel2.Controls.Add(this.PatientDiagnosisLabel);
            this.PersonalInfoSplitContainer.Size = new System.Drawing.Size(887, 406);
            this.PersonalInfoSplitContainer.SplitterDistance = 396;
            this.PersonalInfoSplitContainer.SplitterWidth = 5;
            this.PersonalInfoSplitContainer.TabIndex = 0;
            // 
            // PatientMedicalCardIdValueLabel
            // 
            this.PatientMedicalCardIdValueLabel.AutoSize = true;
            this.PatientMedicalCardIdValueLabel.Location = new System.Drawing.Point(139, 180);
            this.PatientMedicalCardIdValueLabel.Name = "PatientMedicalCardIdValueLabel";
            this.PatientMedicalCardIdValueLabel.Size = new System.Drawing.Size(130, 20);
            this.PatientMedicalCardIdValueLabel.TabIndex = 35;
            this.PatientMedicalCardIdValueLabel.Text = "No data available.";
            // 
            // PatientBirthDateValueLabel
            // 
            this.PatientBirthDateValueLabel.AutoSize = true;
            this.PatientBirthDateValueLabel.Location = new System.Drawing.Point(102, 140);
            this.PatientBirthDateValueLabel.Name = "PatientBirthDateValueLabel";
            this.PatientBirthDateValueLabel.Size = new System.Drawing.Size(130, 20);
            this.PatientBirthDateValueLabel.TabIndex = 34;
            this.PatientBirthDateValueLabel.Text = "No data available.";
            // 
            // PatientCityOfBirthValueLabel
            // 
            this.PatientCityOfBirthValueLabel.AutoSize = true;
            this.PatientCityOfBirthValueLabel.Location = new System.Drawing.Point(115, 100);
            this.PatientCityOfBirthValueLabel.Name = "PatientCityOfBirthValueLabel";
            this.PatientCityOfBirthValueLabel.Size = new System.Drawing.Size(130, 20);
            this.PatientCityOfBirthValueLabel.TabIndex = 33;
            this.PatientCityOfBirthValueLabel.Text = "No data available.";
            // 
            // PatientLastNameValueLabel
            // 
            this.PatientLastNameValueLabel.AutoSize = true;
            this.PatientLastNameValueLabel.Location = new System.Drawing.Point(104, 60);
            this.PatientLastNameValueLabel.Name = "PatientLastNameValueLabel";
            this.PatientLastNameValueLabel.Size = new System.Drawing.Size(130, 20);
            this.PatientLastNameValueLabel.TabIndex = 32;
            this.PatientLastNameValueLabel.Text = "No data available.";
            // 
            // PatientFirstNameValueLabel
            // 
            this.PatientFirstNameValueLabel.AutoSize = true;
            this.PatientFirstNameValueLabel.Location = new System.Drawing.Point(105, 20);
            this.PatientFirstNameValueLabel.Name = "PatientFirstNameValueLabel";
            this.PatientFirstNameValueLabel.Size = new System.Drawing.Size(130, 20);
            this.PatientFirstNameValueLabel.TabIndex = 31;
            this.PatientFirstNameValueLabel.Text = "No data available.";
            // 
            // PatientMedicalCardIdLabel
            // 
            this.PatientMedicalCardIdLabel.AutoSize = true;
            this.PatientMedicalCardIdLabel.Location = new System.Drawing.Point(15, 180);
            this.PatientMedicalCardIdLabel.Name = "PatientMedicalCardIdLabel";
            this.PatientMedicalCardIdLabel.Size = new System.Drawing.Size(119, 20);
            this.PatientMedicalCardIdLabel.TabIndex = 30;
            this.PatientMedicalCardIdLabel.Text = "Medical card id: ";
            // 
            // PatientBirthDateLabel
            // 
            this.PatientBirthDateLabel.AutoSize = true;
            this.PatientBirthDateLabel.Location = new System.Drawing.Point(15, 140);
            this.PatientBirthDateLabel.Name = "PatientBirthDateLabel";
            this.PatientBirthDateLabel.Size = new System.Drawing.Size(81, 20);
            this.PatientBirthDateLabel.TabIndex = 29;
            this.PatientBirthDateLabel.Text = "Birth date: ";
            // 
            // PatientCityOfBirthLabel
            // 
            this.PatientCityOfBirthLabel.AutoSize = true;
            this.PatientCityOfBirthLabel.Location = new System.Drawing.Point(15, 100);
            this.PatientCityOfBirthLabel.Name = "PatientCityOfBirthLabel";
            this.PatientCityOfBirthLabel.Size = new System.Drawing.Size(94, 20);
            this.PatientCityOfBirthLabel.TabIndex = 28;
            this.PatientCityOfBirthLabel.Text = "City of birth: ";
            // 
            // PatientLastNameLabel
            // 
            this.PatientLastNameLabel.AutoSize = true;
            this.PatientLastNameLabel.Location = new System.Drawing.Point(15, 60);
            this.PatientLastNameLabel.Name = "PatientLastNameLabel";
            this.PatientLastNameLabel.Size = new System.Drawing.Size(83, 20);
            this.PatientLastNameLabel.TabIndex = 27;
            this.PatientLastNameLabel.Text = "Last name: ";
            // 
            // PatientFirstNameLabel
            // 
            this.PatientFirstNameLabel.AutoSize = true;
            this.PatientFirstNameLabel.Location = new System.Drawing.Point(15, 20);
            this.PatientFirstNameLabel.Name = "PatientFirstNameLabel";
            this.PatientFirstNameLabel.Size = new System.Drawing.Size(84, 20);
            this.PatientFirstNameLabel.TabIndex = 26;
            this.PatientFirstNameLabel.Text = "First name: ";
            // 
            // PatientAppointmentTimeValueLabel
            // 
            this.PatientAppointmentTimeValueLabel.AutoSize = true;
            this.PatientAppointmentTimeValueLabel.Location = new System.Drawing.Point(187, 140);
            this.PatientAppointmentTimeValueLabel.Name = "PatientAppointmentTimeValueLabel";
            this.PatientAppointmentTimeValueLabel.Size = new System.Drawing.Size(130, 20);
            this.PatientAppointmentTimeValueLabel.TabIndex = 33;
            this.PatientAppointmentTimeValueLabel.Text = "No data available.";
            // 
            // PatientAppointmentTimeLabel
            // 
            this.PatientAppointmentTimeLabel.AutoSize = true;
            this.PatientAppointmentTimeLabel.Location = new System.Drawing.Point(15, 140);
            this.PatientAppointmentTimeLabel.Name = "PatientAppointmentTimeLabel";
            this.PatientAppointmentTimeLabel.Size = new System.Drawing.Size(166, 20);
            this.PatientAppointmentTimeLabel.TabIndex = 32;
            this.PatientAppointmentTimeLabel.Text = "Last appointment time: ";
            // 
            // PatientAppointmentDateValueLabel
            // 
            this.PatientAppointmentDateValueLabel.AutoSize = true;
            this.PatientAppointmentDateValueLabel.Location = new System.Drawing.Point(187, 100);
            this.PatientAppointmentDateValueLabel.Name = "PatientAppointmentDateValueLabel";
            this.PatientAppointmentDateValueLabel.Size = new System.Drawing.Size(130, 20);
            this.PatientAppointmentDateValueLabel.TabIndex = 31;
            this.PatientAppointmentDateValueLabel.Text = "No data available.";
            // 
            // PatientAppointmentDateLabel
            // 
            this.PatientAppointmentDateLabel.AutoSize = true;
            this.PatientAppointmentDateLabel.Location = new System.Drawing.Point(15, 100);
            this.PatientAppointmentDateLabel.Name = "PatientAppointmentDateLabel";
            this.PatientAppointmentDateLabel.Size = new System.Drawing.Size(166, 20);
            this.PatientAppointmentDateLabel.TabIndex = 30;
            this.PatientAppointmentDateLabel.Text = "Last appointment date: ";
            // 
            // PatientDoctorValueLabel
            // 
            this.PatientDoctorValueLabel.AutoSize = true;
            this.PatientDoctorValueLabel.Location = new System.Drawing.Point(83, 60);
            this.PatientDoctorValueLabel.Name = "PatientDoctorValueLabel";
            this.PatientDoctorValueLabel.Size = new System.Drawing.Size(130, 20);
            this.PatientDoctorValueLabel.TabIndex = 29;
            this.PatientDoctorValueLabel.Text = "No data available.";
            // 
            // PatientDoctorLabel
            // 
            this.PatientDoctorLabel.AutoSize = true;
            this.PatientDoctorLabel.Location = new System.Drawing.Point(15, 60);
            this.PatientDoctorLabel.Name = "PatientDoctorLabel";
            this.PatientDoctorLabel.Size = new System.Drawing.Size(62, 20);
            this.PatientDoctorLabel.TabIndex = 28;
            this.PatientDoctorLabel.Text = "Doctor: ";
            // 
            // PatientDiagnosisValueLabel
            // 
            this.PatientDiagnosisValueLabel.AutoSize = true;
            this.PatientDiagnosisValueLabel.Location = new System.Drawing.Point(102, 20);
            this.PatientDiagnosisValueLabel.Name = "PatientDiagnosisValueLabel";
            this.PatientDiagnosisValueLabel.Size = new System.Drawing.Size(130, 20);
            this.PatientDiagnosisValueLabel.TabIndex = 27;
            this.PatientDiagnosisValueLabel.Text = "No data available.";
            // 
            // PatientDiagnosisLabel
            // 
            this.PatientDiagnosisLabel.AutoSize = true;
            this.PatientDiagnosisLabel.Location = new System.Drawing.Point(15, 20);
            this.PatientDiagnosisLabel.Name = "PatientDiagnosisLabel";
            this.PatientDiagnosisLabel.Size = new System.Drawing.Size(81, 20);
            this.PatientDiagnosisLabel.TabIndex = 26;
            this.PatientDiagnosisLabel.Text = "Diagnosis: ";
            // 
            // PatientPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 451);
            this.Controls.Add(this.PatientTabControl);
            this.Name = "PatientPanel";
            this.Text = "PatientPanel";
            this.Load += new System.EventHandler(this.PatientPanel_Load);
            this.PatientTabControl.ResumeLayout(false);
            this.MakeAnAppointmentTab.ResumeLayout(false);
            this.MakeAnAppointmentTab.PerformLayout();
            this.PatientAppointmentsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsDataGrid)).EndInit();
            this.PersonalInformationTab.ResumeLayout(false);
            this.PersonalInfoSplitContainer.Panel1.ResumeLayout(false);
            this.PersonalInfoSplitContainer.Panel1.PerformLayout();
            this.PersonalInfoSplitContainer.Panel2.ResumeLayout(false);
            this.PersonalInfoSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonalInfoSplitContainer)).EndInit();
            this.PersonalInfoSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl PatientTabControl;
        private System.Windows.Forms.TabPage PatientAppointmentsTab;
        private System.Windows.Forms.TabPage PersonalInformationTab;
        private System.Windows.Forms.TabPage MakeAnAppointmentTab;
        private System.Windows.Forms.Button CreateAppointmentButton;
        private System.Windows.Forms.DateTimePicker AppointmentTimePicker;
        private System.Windows.Forms.Label AppointmentTimeLabel;
        private System.Windows.Forms.DateTimePicker AppointmentDatePicker;
        private System.Windows.Forms.Label AppointmentDateTimeLabel;
        private System.Windows.Forms.Label DoctorDataLabel;
        private System.Windows.Forms.Button ChooseDoctorButton;
        private System.Windows.Forms.ListBox DoctorsListBox;
        private System.Windows.Forms.Button PatientsAppointmentsRefleshButton;
        private System.Windows.Forms.DataGridView AppointmentsDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAppointmentsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiagnisisColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeColumn;
        private System.Windows.Forms.SplitContainer PersonalInfoSplitContainer;
        private System.Windows.Forms.Label PatientMedicalCardIdValueLabel;
        private System.Windows.Forms.Label PatientBirthDateValueLabel;
        private System.Windows.Forms.Label PatientCityOfBirthValueLabel;
        private System.Windows.Forms.Label PatientLastNameValueLabel;
        private System.Windows.Forms.Label PatientFirstNameValueLabel;
        private System.Windows.Forms.Label PatientMedicalCardIdLabel;
        private System.Windows.Forms.Label PatientBirthDateLabel;
        private System.Windows.Forms.Label PatientCityOfBirthLabel;
        private System.Windows.Forms.Label PatientLastNameLabel;
        private System.Windows.Forms.Label PatientFirstNameLabel;
        private System.Windows.Forms.Label PatientAppointmentDateValueLabel;
        private System.Windows.Forms.Label PatientAppointmentDateLabel;
        private System.Windows.Forms.Label PatientDoctorValueLabel;
        private System.Windows.Forms.Label PatientDoctorLabel;
        private System.Windows.Forms.Label PatientDiagnosisValueLabel;
        private System.Windows.Forms.Label PatientDiagnosisLabel;
        private System.Windows.Forms.Label PatientAppointmentTimeValueLabel;
        private System.Windows.Forms.Label PatientAppointmentTimeLabel;
    }
}