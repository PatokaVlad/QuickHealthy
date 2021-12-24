
namespace QuickHealthy.PL.Views
{
    partial class AdminPanel
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
            this.AdminTabControl = new System.Windows.Forms.TabControl();
            this.AppointmentsTab = new System.Windows.Forms.TabPage();
            this.RefleshAppointmentsTableButton = new System.Windows.Forms.Button();
            this.AppointmentsDataGrid = new System.Windows.Forms.DataGridView();
            this.IdAppointmentsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiagnisisColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicalCardAppointmentsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientsTab = new System.Windows.Forms.TabPage();
            this.RefleshPatientsTableButton = new System.Windows.Forms.Button();
            this.PatientsDataGrid = new System.Windows.Forms.DataGridView();
            this.IdPatientsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirsNamePatientsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastNamePatientsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityOfBirthColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicalCardPatientsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OfficesTab = new System.Windows.Forms.TabPage();
            this.OfficeCreationPanel = new System.Windows.Forms.Panel();
            this.OfficeAddButton = new System.Windows.Forms.Button();
            this.OfficeDoctorIdTextBox = new System.Windows.Forms.TextBox();
            this.OfficeDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.OfficeDoctorIdLabel = new System.Windows.Forms.Label();
            this.OfficeDescriptionLabel = new System.Windows.Forms.Label();
            this.RefleshOfficesTableButton = new System.Windows.Forms.Button();
            this.OfficesDateGrid = new System.Windows.Forms.DataGridView();
            this.IdOfficesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorOfficesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorsTab = new System.Windows.Forms.TabPage();
            this.DoctorCreationPanel = new System.Windows.Forms.Panel();
            this.EndWorkTimeTextBox = new System.Windows.Forms.DateTimePicker();
            this.StartWorkTimeTextBox = new System.Windows.Forms.DateTimePicker();
            this.EndWorkTimeLabel = new System.Windows.Forms.Label();
            this.DoctorOfficeIdTextBox = new System.Windows.Forms.TextBox();
            this.StartWorkTimeLabel = new System.Windows.Forms.Label();
            this.OfficeIdLabel = new System.Windows.Forms.Label();
            this.JobPositionTextBox = new System.Windows.Forms.TextBox();
            this.JobPositionLabel = new System.Windows.Forms.Label();
            this.AddDoctorButton = new System.Windows.Forms.Button();
            this.DoctorLastNameTextBox = new System.Windows.Forms.TextBox();
            this.DoctorFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.DoctorLastNameLabel = new System.Windows.Forms.Label();
            this.DoctorFirstNameLabel = new System.Windows.Forms.Label();
            this.RefleshDoctorsTableButton = new System.Windows.Forms.Button();
            this.DoctorsDataGrid = new System.Windows.Forms.DataGridView();
            this.IdDoctorsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstNameDoctorsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastNameDoctorsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobPositionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartWorkTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndWorkTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OfficeIdDoctorsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdminTabControl.SuspendLayout();
            this.AppointmentsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsDataGrid)).BeginInit();
            this.PatientsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsDataGrid)).BeginInit();
            this.OfficesTab.SuspendLayout();
            this.OfficeCreationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OfficesDateGrid)).BeginInit();
            this.DoctorsTab.SuspendLayout();
            this.DoctorCreationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminTabControl
            // 
            this.AdminTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminTabControl.Controls.Add(this.AppointmentsTab);
            this.AdminTabControl.Controls.Add(this.PatientsTab);
            this.AdminTabControl.Controls.Add(this.OfficesTab);
            this.AdminTabControl.Controls.Add(this.DoctorsTab);
            this.AdminTabControl.Location = new System.Drawing.Point(0, 0);
            this.AdminTabControl.Name = "AdminTabControl";
            this.AdminTabControl.SelectedIndex = 0;
            this.AdminTabControl.Size = new System.Drawing.Size(795, 445);
            this.AdminTabControl.TabIndex = 0;
            // 
            // AppointmentsTab
            // 
            this.AppointmentsTab.Controls.Add(this.RefleshAppointmentsTableButton);
            this.AppointmentsTab.Controls.Add(this.AppointmentsDataGrid);
            this.AppointmentsTab.Location = new System.Drawing.Point(4, 29);
            this.AppointmentsTab.Name = "AppointmentsTab";
            this.AppointmentsTab.Padding = new System.Windows.Forms.Padding(3);
            this.AppointmentsTab.Size = new System.Drawing.Size(787, 412);
            this.AppointmentsTab.TabIndex = 0;
            this.AppointmentsTab.Text = "Appointments";
            this.AppointmentsTab.UseVisualStyleBackColor = true;
            // 
            // RefleshAppointmentsTableButton
            // 
            this.RefleshAppointmentsTableButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RefleshAppointmentsTableButton.Location = new System.Drawing.Point(577, 362);
            this.RefleshAppointmentsTableButton.Name = "RefleshAppointmentsTableButton";
            this.RefleshAppointmentsTableButton.Size = new System.Drawing.Size(202, 43);
            this.RefleshAppointmentsTableButton.TabIndex = 1;
            this.RefleshAppointmentsTableButton.Text = "Reflesh";
            this.RefleshAppointmentsTableButton.UseVisualStyleBackColor = true;
            this.RefleshAppointmentsTableButton.Click += new System.EventHandler(this.RefleshAppointmentsTableButton_Click);
            // 
            // AppointmentsDataGrid
            // 
            this.AppointmentsDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AppointmentsDataGrid.ColumnHeadersHeight = 29;
            this.AppointmentsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAppointmentsColumn,
            this.DateColumn,
            this.TimeColumn,
            this.DiagnisisColumn,
            this.DoctorColumn,
            this.MedicalCardAppointmentsColumn});
            this.AppointmentsDataGrid.Location = new System.Drawing.Point(7, 3);
            this.AppointmentsDataGrid.Name = "AppointmentsDataGrid";
            this.AppointmentsDataGrid.RowHeadersWidth = 51;
            this.AppointmentsDataGrid.RowTemplate.Height = 29;
            this.AppointmentsDataGrid.Size = new System.Drawing.Size(773, 341);
            this.AppointmentsDataGrid.TabIndex = 0;
            // 
            // IdAppointmentsColumn
            // 
            this.IdAppointmentsColumn.HeaderText = "Id";
            this.IdAppointmentsColumn.MinimumWidth = 6;
            this.IdAppointmentsColumn.Name = "IdAppointmentsColumn";
            this.IdAppointmentsColumn.Width = 40;
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
            // DiagnisisColumn
            // 
            this.DiagnisisColumn.HeaderText = "Diagnosis";
            this.DiagnisisColumn.MinimumWidth = 6;
            this.DiagnisisColumn.Name = "DiagnisisColumn";
            this.DiagnisisColumn.Width = 125;
            // 
            // DoctorColumn
            // 
            this.DoctorColumn.HeaderText = "Doctor";
            this.DoctorColumn.MinimumWidth = 6;
            this.DoctorColumn.Name = "DoctorColumn";
            this.DoctorColumn.Width = 180;
            // 
            // MedicalCardAppointmentsColumn
            // 
            this.MedicalCardAppointmentsColumn.HeaderText = "MedicalCard";
            this.MedicalCardAppointmentsColumn.MinimumWidth = 6;
            this.MedicalCardAppointmentsColumn.Name = "MedicalCardAppointmentsColumn";
            this.MedicalCardAppointmentsColumn.Width = 125;
            // 
            // PatientsTab
            // 
            this.PatientsTab.Controls.Add(this.RefleshPatientsTableButton);
            this.PatientsTab.Controls.Add(this.PatientsDataGrid);
            this.PatientsTab.Location = new System.Drawing.Point(4, 29);
            this.PatientsTab.Name = "PatientsTab";
            this.PatientsTab.Padding = new System.Windows.Forms.Padding(3);
            this.PatientsTab.Size = new System.Drawing.Size(787, 412);
            this.PatientsTab.TabIndex = 1;
            this.PatientsTab.Text = "Patients";
            this.PatientsTab.UseVisualStyleBackColor = true;
            // 
            // RefleshPatientsTableButton
            // 
            this.RefleshPatientsTableButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RefleshPatientsTableButton.Location = new System.Drawing.Point(577, 362);
            this.RefleshPatientsTableButton.Name = "RefleshPatientsTableButton";
            this.RefleshPatientsTableButton.Size = new System.Drawing.Size(202, 43);
            this.RefleshPatientsTableButton.TabIndex = 3;
            this.RefleshPatientsTableButton.Text = "Reflesh";
            this.RefleshPatientsTableButton.UseVisualStyleBackColor = true;
            this.RefleshPatientsTableButton.Click += new System.EventHandler(this.RefleshPatientsTableButton_Click);
            // 
            // PatientsDataGrid
            // 
            this.PatientsDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PatientsDataGrid.ColumnHeadersHeight = 29;
            this.PatientsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPatientsColumn,
            this.FirsNamePatientsColumn,
            this.LastNamePatientsColumn,
            this.CityOfBirthColumn,
            this.BirthDateColumn,
            this.MedicalCardPatientsColumn});
            this.PatientsDataGrid.Location = new System.Drawing.Point(7, 8);
            this.PatientsDataGrid.Name = "PatientsDataGrid";
            this.PatientsDataGrid.RowHeadersWidth = 51;
            this.PatientsDataGrid.RowTemplate.Height = 29;
            this.PatientsDataGrid.Size = new System.Drawing.Size(773, 341);
            this.PatientsDataGrid.TabIndex = 2;
            // 
            // IdPatientsColumn
            // 
            this.IdPatientsColumn.HeaderText = "Id";
            this.IdPatientsColumn.MinimumWidth = 6;
            this.IdPatientsColumn.Name = "IdPatientsColumn";
            this.IdPatientsColumn.Width = 40;
            // 
            // FirsNamePatientsColumn
            // 
            this.FirsNamePatientsColumn.HeaderText = "FirstName";
            this.FirsNamePatientsColumn.MinimumWidth = 6;
            this.FirsNamePatientsColumn.Name = "FirsNamePatientsColumn";
            this.FirsNamePatientsColumn.Width = 125;
            // 
            // LastNamePatientsColumn
            // 
            this.LastNamePatientsColumn.HeaderText = "LastName";
            this.LastNamePatientsColumn.MinimumWidth = 6;
            this.LastNamePatientsColumn.Name = "LastNamePatientsColumn";
            this.LastNamePatientsColumn.Width = 125;
            // 
            // CityOfBirthColumn
            // 
            this.CityOfBirthColumn.HeaderText = "CityOfBirth";
            this.CityOfBirthColumn.MinimumWidth = 6;
            this.CityOfBirthColumn.Name = "CityOfBirthColumn";
            this.CityOfBirthColumn.Width = 125;
            // 
            // BirthDateColumn
            // 
            this.BirthDateColumn.HeaderText = "BirthDate";
            this.BirthDateColumn.MinimumWidth = 6;
            this.BirthDateColumn.Name = "BirthDateColumn";
            this.BirthDateColumn.Width = 125;
            // 
            // MedicalCardPatientsColumn
            // 
            this.MedicalCardPatientsColumn.HeaderText = "MedicalCard";
            this.MedicalCardPatientsColumn.MinimumWidth = 6;
            this.MedicalCardPatientsColumn.Name = "MedicalCardPatientsColumn";
            this.MedicalCardPatientsColumn.Width = 125;
            // 
            // OfficesTab
            // 
            this.OfficesTab.Controls.Add(this.OfficeCreationPanel);
            this.OfficesTab.Controls.Add(this.RefleshOfficesTableButton);
            this.OfficesTab.Controls.Add(this.OfficesDateGrid);
            this.OfficesTab.Location = new System.Drawing.Point(4, 29);
            this.OfficesTab.Name = "OfficesTab";
            this.OfficesTab.Padding = new System.Windows.Forms.Padding(3);
            this.OfficesTab.Size = new System.Drawing.Size(787, 412);
            this.OfficesTab.TabIndex = 2;
            this.OfficesTab.Text = "Offices";
            this.OfficesTab.UseVisualStyleBackColor = true;
            // 
            // OfficeCreationPanel
            // 
            this.OfficeCreationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OfficeCreationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OfficeCreationPanel.Controls.Add(this.OfficeAddButton);
            this.OfficeCreationPanel.Controls.Add(this.OfficeDoctorIdTextBox);
            this.OfficeCreationPanel.Controls.Add(this.OfficeDescriptionTextBox);
            this.OfficeCreationPanel.Controls.Add(this.OfficeDoctorIdLabel);
            this.OfficeCreationPanel.Controls.Add(this.OfficeDescriptionLabel);
            this.OfficeCreationPanel.Location = new System.Drawing.Point(7, 263);
            this.OfficeCreationPanel.Name = "OfficeCreationPanel";
            this.OfficeCreationPanel.Size = new System.Drawing.Size(550, 140);
            this.OfficeCreationPanel.TabIndex = 6;
            // 
            // OfficeAddButton
            // 
            this.OfficeAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OfficeAddButton.Location = new System.Drawing.Point(481, 10);
            this.OfficeAddButton.Name = "OfficeAddButton";
            this.OfficeAddButton.Size = new System.Drawing.Size(57, 120);
            this.OfficeAddButton.TabIndex = 4;
            this.OfficeAddButton.Text = "Add";
            this.OfficeAddButton.UseVisualStyleBackColor = true;
            this.OfficeAddButton.Click += new System.EventHandler(this.OfficeAddButton_Click);
            // 
            // OfficeDoctorIdTextBox
            // 
            this.OfficeDoctorIdTextBox.Location = new System.Drawing.Point(92, 82);
            this.OfficeDoctorIdTextBox.Name = "OfficeDoctorIdTextBox";
            this.OfficeDoctorIdTextBox.Size = new System.Drawing.Size(159, 27);
            this.OfficeDoctorIdTextBox.TabIndex = 3;
            // 
            // OfficeDescriptionTextBox
            // 
            this.OfficeDescriptionTextBox.Location = new System.Drawing.Point(109, 32);
            this.OfficeDescriptionTextBox.Name = "OfficeDescriptionTextBox";
            this.OfficeDescriptionTextBox.Size = new System.Drawing.Size(142, 27);
            this.OfficeDescriptionTextBox.TabIndex = 2;
            // 
            // OfficeDoctorIdLabel
            // 
            this.OfficeDoctorIdLabel.AutoSize = true;
            this.OfficeDoctorIdLabel.Location = new System.Drawing.Point(10, 85);
            this.OfficeDoctorIdLabel.Name = "OfficeDoctorIdLabel";
            this.OfficeDoctorIdLabel.Size = new System.Drawing.Size(75, 20);
            this.OfficeDoctorIdLabel.TabIndex = 1;
            this.OfficeDoctorIdLabel.Text = "DoctorId: ";
            // 
            // OfficeDescriptionLabel
            // 
            this.OfficeDescriptionLabel.AutoSize = true;
            this.OfficeDescriptionLabel.Location = new System.Drawing.Point(11, 35);
            this.OfficeDescriptionLabel.Name = "OfficeDescriptionLabel";
            this.OfficeDescriptionLabel.Size = new System.Drawing.Size(92, 20);
            this.OfficeDescriptionLabel.TabIndex = 0;
            this.OfficeDescriptionLabel.Text = "Description: ";
            // 
            // RefleshOfficesTableButton
            // 
            this.RefleshOfficesTableButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RefleshOfficesTableButton.Location = new System.Drawing.Point(577, 362);
            this.RefleshOfficesTableButton.Name = "RefleshOfficesTableButton";
            this.RefleshOfficesTableButton.Size = new System.Drawing.Size(202, 43);
            this.RefleshOfficesTableButton.TabIndex = 5;
            this.RefleshOfficesTableButton.Text = "Reflesh";
            this.RefleshOfficesTableButton.UseVisualStyleBackColor = true;
            this.RefleshOfficesTableButton.Click += new System.EventHandler(this.RefleshOfficesTableButton_Click);
            // 
            // OfficesDateGrid
            // 
            this.OfficesDateGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OfficesDateGrid.ColumnHeadersHeight = 29;
            this.OfficesDateGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdOfficesColumn,
            this.DescriptionColumn,
            this.DoctorOfficesColumn});
            this.OfficesDateGrid.Location = new System.Drawing.Point(7, 8);
            this.OfficesDateGrid.Name = "OfficesDateGrid";
            this.OfficesDateGrid.RowHeadersWidth = 51;
            this.OfficesDateGrid.RowTemplate.Height = 29;
            this.OfficesDateGrid.Size = new System.Drawing.Size(773, 242);
            this.OfficesDateGrid.TabIndex = 4;
            // 
            // IdOfficesColumn
            // 
            this.IdOfficesColumn.HeaderText = "Id";
            this.IdOfficesColumn.MinimumWidth = 6;
            this.IdOfficesColumn.Name = "IdOfficesColumn";
            this.IdOfficesColumn.Width = 40;
            // 
            // DescriptionColumn
            // 
            this.DescriptionColumn.HeaderText = "Description";
            this.DescriptionColumn.MinimumWidth = 6;
            this.DescriptionColumn.Name = "DescriptionColumn";
            this.DescriptionColumn.Width = 125;
            // 
            // DoctorOfficesColumn
            // 
            this.DoctorOfficesColumn.HeaderText = "Doctor";
            this.DoctorOfficesColumn.MinimumWidth = 6;
            this.DoctorOfficesColumn.Name = "DoctorOfficesColumn";
            this.DoctorOfficesColumn.Width = 125;
            // 
            // DoctorsTab
            // 
            this.DoctorsTab.Controls.Add(this.DoctorCreationPanel);
            this.DoctorsTab.Controls.Add(this.RefleshDoctorsTableButton);
            this.DoctorsTab.Controls.Add(this.DoctorsDataGrid);
            this.DoctorsTab.Location = new System.Drawing.Point(4, 29);
            this.DoctorsTab.Name = "DoctorsTab";
            this.DoctorsTab.Padding = new System.Windows.Forms.Padding(3);
            this.DoctorsTab.Size = new System.Drawing.Size(787, 412);
            this.DoctorsTab.TabIndex = 3;
            this.DoctorsTab.Text = "Doctors";
            this.DoctorsTab.UseVisualStyleBackColor = true;
            // 
            // DoctorCreationPanel
            // 
            this.DoctorCreationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DoctorCreationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DoctorCreationPanel.Controls.Add(this.EndWorkTimeTextBox);
            this.DoctorCreationPanel.Controls.Add(this.StartWorkTimeTextBox);
            this.DoctorCreationPanel.Controls.Add(this.EndWorkTimeLabel);
            this.DoctorCreationPanel.Controls.Add(this.DoctorOfficeIdTextBox);
            this.DoctorCreationPanel.Controls.Add(this.StartWorkTimeLabel);
            this.DoctorCreationPanel.Controls.Add(this.OfficeIdLabel);
            this.DoctorCreationPanel.Controls.Add(this.JobPositionTextBox);
            this.DoctorCreationPanel.Controls.Add(this.JobPositionLabel);
            this.DoctorCreationPanel.Controls.Add(this.AddDoctorButton);
            this.DoctorCreationPanel.Controls.Add(this.DoctorLastNameTextBox);
            this.DoctorCreationPanel.Controls.Add(this.DoctorFirstNameTextBox);
            this.DoctorCreationPanel.Controls.Add(this.DoctorLastNameLabel);
            this.DoctorCreationPanel.Controls.Add(this.DoctorFirstNameLabel);
            this.DoctorCreationPanel.Location = new System.Drawing.Point(7, 263);
            this.DoctorCreationPanel.Name = "DoctorCreationPanel";
            this.DoctorCreationPanel.Size = new System.Drawing.Size(670, 140);
            this.DoctorCreationPanel.TabIndex = 7;
            // 
            // EndWorkTimeTextBox
            // 
            this.EndWorkTimeTextBox.CustomFormat = "HH:mm";
            this.EndWorkTimeTextBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndWorkTimeTextBox.Location = new System.Drawing.Point(377, 85);
            this.EndWorkTimeTextBox.MinDate = new System.DateTime(2021, 12, 13, 23, 38, 3, 0);
            this.EndWorkTimeTextBox.Name = "EndWorkTimeTextBox";
            this.EndWorkTimeTextBox.ShowUpDown = true;
            this.EndWorkTimeTextBox.Size = new System.Drawing.Size(159, 27);
            this.EndWorkTimeTextBox.TabIndex = 13;
            this.EndWorkTimeTextBox.Value = new System.DateTime(2021, 12, 14, 0, 0, 0, 0);
            // 
            // StartWorkTimeTextBox
            // 
            this.StartWorkTimeTextBox.CustomFormat = "HH:mm";
            this.StartWorkTimeTextBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartWorkTimeTextBox.Location = new System.Drawing.Point(387, 45);
            this.StartWorkTimeTextBox.MinDate = new System.DateTime(2021, 12, 13, 23, 38, 3, 0);
            this.StartWorkTimeTextBox.Name = "StartWorkTimeTextBox";
            this.StartWorkTimeTextBox.ShowUpDown = true;
            this.StartWorkTimeTextBox.Size = new System.Drawing.Size(149, 27);
            this.StartWorkTimeTextBox.TabIndex = 12;
            this.StartWorkTimeTextBox.Value = new System.DateTime(2021, 12, 14, 0, 0, 0, 0);
            // 
            // EndWorkTimeLabel
            // 
            this.EndWorkTimeLabel.AutoSize = true;
            this.EndWorkTimeLabel.Location = new System.Drawing.Point(264, 90);
            this.EndWorkTimeLabel.Name = "EndWorkTimeLabel";
            this.EndWorkTimeLabel.Size = new System.Drawing.Size(107, 20);
            this.EndWorkTimeLabel.TabIndex = 11;
            this.EndWorkTimeLabel.Text = "End work time:";
            // 
            // DoctorOfficeIdTextBox
            // 
            this.DoctorOfficeIdTextBox.Location = new System.Drawing.Point(339, 7);
            this.DoctorOfficeIdTextBox.Name = "DoctorOfficeIdTextBox";
            this.DoctorOfficeIdTextBox.Size = new System.Drawing.Size(197, 27);
            this.DoctorOfficeIdTextBox.TabIndex = 9;
            // 
            // StartWorkTimeLabel
            // 
            this.StartWorkTimeLabel.AutoSize = true;
            this.StartWorkTimeLabel.Location = new System.Drawing.Point(264, 50);
            this.StartWorkTimeLabel.Name = "StartWorkTimeLabel";
            this.StartWorkTimeLabel.Size = new System.Drawing.Size(117, 20);
            this.StartWorkTimeLabel.TabIndex = 8;
            this.StartWorkTimeLabel.Text = "Start work time: ";
            // 
            // OfficeIdLabel
            // 
            this.OfficeIdLabel.AutoSize = true;
            this.OfficeIdLabel.Location = new System.Drawing.Point(264, 10);
            this.OfficeIdLabel.Name = "OfficeIdLabel";
            this.OfficeIdLabel.Size = new System.Drawing.Size(69, 20);
            this.OfficeIdLabel.TabIndex = 7;
            this.OfficeIdLabel.Text = "OfficeId: ";
            // 
            // JobPositionTextBox
            // 
            this.JobPositionTextBox.Location = new System.Drawing.Point(113, 87);
            this.JobPositionTextBox.Name = "JobPositionTextBox";
            this.JobPositionTextBox.Size = new System.Drawing.Size(145, 27);
            this.JobPositionTextBox.TabIndex = 6;
            // 
            // JobPositionLabel
            // 
            this.JobPositionLabel.AutoSize = true;
            this.JobPositionLabel.Location = new System.Drawing.Point(10, 90);
            this.JobPositionLabel.Name = "JobPositionLabel";
            this.JobPositionLabel.Size = new System.Drawing.Size(97, 20);
            this.JobPositionLabel.TabIndex = 5;
            this.JobPositionLabel.Text = "Job position: ";
            // 
            // AddDoctorButton
            // 
            this.AddDoctorButton.Location = new System.Drawing.Point(602, 7);
            this.AddDoctorButton.Name = "AddDoctorButton";
            this.AddDoctorButton.Size = new System.Drawing.Size(57, 120);
            this.AddDoctorButton.TabIndex = 4;
            this.AddDoctorButton.Text = "Add";
            this.AddDoctorButton.UseVisualStyleBackColor = true;
            this.AddDoctorButton.Click += new System.EventHandler(this.AddDoctorButton_Click);
            // 
            // DoctorLastNameTextBox
            // 
            this.DoctorLastNameTextBox.Location = new System.Drawing.Point(99, 47);
            this.DoctorLastNameTextBox.Name = "DoctorLastNameTextBox";
            this.DoctorLastNameTextBox.Size = new System.Drawing.Size(159, 27);
            this.DoctorLastNameTextBox.TabIndex = 3;
            // 
            // DoctorFirstNameTextBox
            // 
            this.DoctorFirstNameTextBox.Location = new System.Drawing.Point(99, 7);
            this.DoctorFirstNameTextBox.Name = "DoctorFirstNameTextBox";
            this.DoctorFirstNameTextBox.Size = new System.Drawing.Size(159, 27);
            this.DoctorFirstNameTextBox.TabIndex = 2;
            // 
            // DoctorLastNameLabel
            // 
            this.DoctorLastNameLabel.AutoSize = true;
            this.DoctorLastNameLabel.Location = new System.Drawing.Point(10, 50);
            this.DoctorLastNameLabel.Name = "DoctorLastNameLabel";
            this.DoctorLastNameLabel.Size = new System.Drawing.Size(83, 20);
            this.DoctorLastNameLabel.TabIndex = 1;
            this.DoctorLastNameLabel.Text = "Last name: ";
            // 
            // DoctorFirstNameLabel
            // 
            this.DoctorFirstNameLabel.AutoSize = true;
            this.DoctorFirstNameLabel.Location = new System.Drawing.Point(10, 10);
            this.DoctorFirstNameLabel.Name = "DoctorFirstNameLabel";
            this.DoctorFirstNameLabel.Size = new System.Drawing.Size(84, 20);
            this.DoctorFirstNameLabel.TabIndex = 0;
            this.DoctorFirstNameLabel.Text = "First name: ";
            // 
            // RefleshDoctorsTableButton
            // 
            this.RefleshDoctorsTableButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RefleshDoctorsTableButton.Location = new System.Drawing.Point(680, 256);
            this.RefleshDoctorsTableButton.Name = "RefleshDoctorsTableButton";
            this.RefleshDoctorsTableButton.Size = new System.Drawing.Size(100, 45);
            this.RefleshDoctorsTableButton.TabIndex = 5;
            this.RefleshDoctorsTableButton.Text = "Reflesh";
            this.RefleshDoctorsTableButton.UseVisualStyleBackColor = true;
            this.RefleshDoctorsTableButton.Click += new System.EventHandler(this.RefleshDoctorsTableButton_Click);
            // 
            // DoctorsDataGrid
            // 
            this.DoctorsDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DoctorsDataGrid.ColumnHeadersHeight = 29;
            this.DoctorsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdDoctorsColumn,
            this.FirstNameDoctorsColumn,
            this.LastNameDoctorsColumn,
            this.JobPositionColumn,
            this.StartWorkTimeColumn,
            this.EndWorkTimeColumn,
            this.OfficeIdDoctorsColumn});
            this.DoctorsDataGrid.Location = new System.Drawing.Point(7, 8);
            this.DoctorsDataGrid.Name = "DoctorsDataGrid";
            this.DoctorsDataGrid.RowHeadersWidth = 51;
            this.DoctorsDataGrid.RowTemplate.Height = 29;
            this.DoctorsDataGrid.Size = new System.Drawing.Size(773, 242);
            this.DoctorsDataGrid.TabIndex = 4;
            // 
            // IdDoctorsColumn
            // 
            this.IdDoctorsColumn.HeaderText = "Id";
            this.IdDoctorsColumn.MinimumWidth = 6;
            this.IdDoctorsColumn.Name = "IdDoctorsColumn";
            this.IdDoctorsColumn.Width = 40;
            // 
            // FirstNameDoctorsColumn
            // 
            this.FirstNameDoctorsColumn.HeaderText = "FirstName";
            this.FirstNameDoctorsColumn.MinimumWidth = 6;
            this.FirstNameDoctorsColumn.Name = "FirstNameDoctorsColumn";
            this.FirstNameDoctorsColumn.Width = 125;
            // 
            // LastNameDoctorsColumn
            // 
            this.LastNameDoctorsColumn.HeaderText = "LastName";
            this.LastNameDoctorsColumn.MinimumWidth = 6;
            this.LastNameDoctorsColumn.Name = "LastNameDoctorsColumn";
            this.LastNameDoctorsColumn.Width = 125;
            // 
            // JobPositionColumn
            // 
            this.JobPositionColumn.HeaderText = "JobPosition";
            this.JobPositionColumn.MinimumWidth = 6;
            this.JobPositionColumn.Name = "JobPositionColumn";
            this.JobPositionColumn.Width = 125;
            // 
            // StartWorkTimeColumn
            // 
            this.StartWorkTimeColumn.HeaderText = "StartWorkTime";
            this.StartWorkTimeColumn.MinimumWidth = 6;
            this.StartWorkTimeColumn.Name = "StartWorkTimeColumn";
            this.StartWorkTimeColumn.Width = 125;
            // 
            // EndWorkTimeColumn
            // 
            this.EndWorkTimeColumn.HeaderText = "EndWorkTime";
            this.EndWorkTimeColumn.MinimumWidth = 6;
            this.EndWorkTimeColumn.Name = "EndWorkTimeColumn";
            this.EndWorkTimeColumn.Width = 125;
            // 
            // OfficeIdDoctorsColumn
            // 
            this.OfficeIdDoctorsColumn.HeaderText = "Office";
            this.OfficeIdDoctorsColumn.MinimumWidth = 6;
            this.OfficeIdDoctorsColumn.Name = "OfficeIdDoctorsColumn";
            this.OfficeIdDoctorsColumn.Width = 125;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AdminTabControl);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.AdminTabControl.ResumeLayout(false);
            this.AppointmentsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsDataGrid)).EndInit();
            this.PatientsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PatientsDataGrid)).EndInit();
            this.OfficesTab.ResumeLayout(false);
            this.OfficeCreationPanel.ResumeLayout(false);
            this.OfficeCreationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OfficesDateGrid)).EndInit();
            this.DoctorsTab.ResumeLayout(false);
            this.DoctorCreationPanel.ResumeLayout(false);
            this.DoctorCreationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl AdminTabControl;
        private System.Windows.Forms.TabPage AppointmentsTab;
        private System.Windows.Forms.TabPage PatientsTab;
        private System.Windows.Forms.TabPage OfficesTab;
        private System.Windows.Forms.TabPage DoctorsTab;
        private System.Windows.Forms.DataGridView AppointmentsDataGrid;
        private System.Windows.Forms.Button RefleshAppointmentsTableButton;
        private System.Windows.Forms.Button RefleshPatientsTableButton;
        private System.Windows.Forms.DataGridView PatientsDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAppointmentsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiagnisisColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicalCardAppointmentsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPatientsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirsNamePatientsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastNamePatientsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityOfBirthColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicalCardPatientsColumn;
        private System.Windows.Forms.Button RefleshOfficesTableButton;
        private System.Windows.Forms.DataGridView OfficesDateGrid;
        private System.Windows.Forms.Button RefleshDoctorsTableButton;
        private System.Windows.Forms.DataGridView DoctorsDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdOfficesColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorOfficesColumn;
        private System.Windows.Forms.Panel OfficeCreationPanel;
        private System.Windows.Forms.Label OfficeDoctorIdLabel;
        private System.Windows.Forms.Label OfficeDescriptionLabel;
        private System.Windows.Forms.Button OfficeAddButton;
        private System.Windows.Forms.TextBox OfficeDoctorIdTextBox;
        private System.Windows.Forms.TextBox OfficeDescriptionTextBox;
        private System.Windows.Forms.Panel DoctorCreationPanel;
        private System.Windows.Forms.TextBox JobPositionTextBox;
        private System.Windows.Forms.Label JobPositionLabel;
        private System.Windows.Forms.Button AddDoctorButton;
        private System.Windows.Forms.TextBox DoctorLastNameTextBox;
        private System.Windows.Forms.TextBox DoctorFirstNameTextBox;
        private System.Windows.Forms.Label DoctorLastNameLabel;
        private System.Windows.Forms.Label DoctorFirstNameLabel;
        private System.Windows.Forms.Label EndWorkTimeLabel;
        private System.Windows.Forms.TextBox DoctorOfficeIdTextBox;
        private System.Windows.Forms.Label StartWorkTimeLabel;
        private System.Windows.Forms.Label OfficeIdLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDoctorsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstNameDoctorsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastNameDoctorsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobPositionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartWorkTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndWorkTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OfficeIdDoctorsColumn;
        private System.Windows.Forms.DateTimePicker EndWorkTimeTextBox;
        private System.Windows.Forms.DateTimePicker StartWorkTimeTextBox;
    }
}