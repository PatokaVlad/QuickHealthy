
namespace QuickHealthy.PL.Views
{
    partial class DoctorPanel
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
            this.DoctorTabControl = new System.Windows.Forms.TabControl();
            this.DoctorAppointmentsTab = new System.Windows.Forms.TabPage();
            this.OfficeCreationPanel = new System.Windows.Forms.Panel();
            this.DoctorAppointmentModifyButton = new System.Windows.Forms.Button();
            this.OfficeAddButton = new System.Windows.Forms.Button();
            this.DoctorAppointmentIdTextBox = new System.Windows.Forms.TextBox();
            this.DoctorAppointmentDiagnosisTextBox = new System.Windows.Forms.TextBox();
            this.AppointmentIdLabel = new System.Windows.Forms.Label();
            this.AppointmentDiagnosisLabel = new System.Windows.Forms.Label();
            this.RefleshAppointmentsTableButton = new System.Windows.Forms.Button();
            this.AppointmentsDataGrid = new System.Windows.Forms.DataGridView();
            this.IdAppointmentsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiagnisisColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicalCardAppointmentsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorPersonalInformationTab = new System.Windows.Forms.TabPage();
            this.DoctorTabControl.SuspendLayout();
            this.DoctorAppointmentsTab.SuspendLayout();
            this.OfficeCreationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DoctorTabControl
            // 
            this.DoctorTabControl.Controls.Add(this.DoctorAppointmentsTab);
            this.DoctorTabControl.Controls.Add(this.DoctorPersonalInformationTab);
            this.DoctorTabControl.Location = new System.Drawing.Point(0, 0);
            this.DoctorTabControl.Name = "DoctorTabControl";
            this.DoctorTabControl.SelectedIndex = 0;
            this.DoctorTabControl.Size = new System.Drawing.Size(795, 445);
            this.DoctorTabControl.TabIndex = 0;
            // 
            // DoctorAppointmentsTab
            // 
            this.DoctorAppointmentsTab.Controls.Add(this.OfficeCreationPanel);
            this.DoctorAppointmentsTab.Controls.Add(this.RefleshAppointmentsTableButton);
            this.DoctorAppointmentsTab.Controls.Add(this.AppointmentsDataGrid);
            this.DoctorAppointmentsTab.Location = new System.Drawing.Point(4, 29);
            this.DoctorAppointmentsTab.Name = "DoctorAppointmentsTab";
            this.DoctorAppointmentsTab.Padding = new System.Windows.Forms.Padding(3);
            this.DoctorAppointmentsTab.Size = new System.Drawing.Size(787, 412);
            this.DoctorAppointmentsTab.TabIndex = 0;
            this.DoctorAppointmentsTab.Text = "Appointments";
            this.DoctorAppointmentsTab.UseVisualStyleBackColor = true;
            // 
            // OfficeCreationPanel
            // 
            this.OfficeCreationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OfficeCreationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OfficeCreationPanel.Controls.Add(this.DoctorAppointmentModifyButton);
            this.OfficeCreationPanel.Controls.Add(this.OfficeAddButton);
            this.OfficeCreationPanel.Controls.Add(this.DoctorAppointmentIdTextBox);
            this.OfficeCreationPanel.Controls.Add(this.DoctorAppointmentDiagnosisTextBox);
            this.OfficeCreationPanel.Controls.Add(this.AppointmentIdLabel);
            this.OfficeCreationPanel.Controls.Add(this.AppointmentDiagnosisLabel);
            this.OfficeCreationPanel.Location = new System.Drawing.Point(8, 284);
            this.OfficeCreationPanel.Name = "OfficeCreationPanel";
            this.OfficeCreationPanel.Size = new System.Drawing.Size(550, 121);
            this.OfficeCreationPanel.TabIndex = 7;
            // 
            // DoctorAppointmentModifyButton
            // 
            this.DoctorAppointmentModifyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DoctorAppointmentModifyButton.Location = new System.Drawing.Point(458, -1);
            this.DoctorAppointmentModifyButton.Name = "DoctorAppointmentModifyButton";
            this.DoctorAppointmentModifyButton.Size = new System.Drawing.Size(82, 120);
            this.DoctorAppointmentModifyButton.TabIndex = 5;
            this.DoctorAppointmentModifyButton.Text = "Modify";
            this.DoctorAppointmentModifyButton.UseVisualStyleBackColor = true;
            this.DoctorAppointmentModifyButton.Click += new System.EventHandler(this.DoctorAppointmentModifyButton_Click);
            // 
            // OfficeAddButton
            // 
            this.OfficeAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OfficeAddButton.Location = new System.Drawing.Point(829, 29);
            this.OfficeAddButton.Name = "OfficeAddButton";
            this.OfficeAddButton.Size = new System.Drawing.Size(57, 120);
            this.OfficeAddButton.TabIndex = 4;
            this.OfficeAddButton.Text = "Add";
            this.OfficeAddButton.UseVisualStyleBackColor = true;
            // 
            // DoctorAppointmentIdTextBox
            // 
            this.DoctorAppointmentIdTextBox.Location = new System.Drawing.Point(142, 67);
            this.DoctorAppointmentIdTextBox.Name = "DoctorAppointmentIdTextBox";
            this.DoctorAppointmentIdTextBox.Size = new System.Drawing.Size(159, 27);
            this.DoctorAppointmentIdTextBox.TabIndex = 3;
            // 
            // DoctorAppointmentDiagnosisTextBox
            // 
            this.DoctorAppointmentDiagnosisTextBox.Location = new System.Drawing.Point(102, 17);
            this.DoctorAppointmentDiagnosisTextBox.Name = "DoctorAppointmentDiagnosisTextBox";
            this.DoctorAppointmentDiagnosisTextBox.Size = new System.Drawing.Size(199, 27);
            this.DoctorAppointmentDiagnosisTextBox.TabIndex = 2;
            // 
            // AppointmentIdLabel
            // 
            this.AppointmentIdLabel.AutoSize = true;
            this.AppointmentIdLabel.Location = new System.Drawing.Point(15, 70);
            this.AppointmentIdLabel.Name = "AppointmentIdLabel";
            this.AppointmentIdLabel.Size = new System.Drawing.Size(121, 20);
            this.AppointmentIdLabel.TabIndex = 1;
            this.AppointmentIdLabel.Text = "Appointment id: ";
            // 
            // AppointmentDiagnosisLabel
            // 
            this.AppointmentDiagnosisLabel.AutoSize = true;
            this.AppointmentDiagnosisLabel.Location = new System.Drawing.Point(15, 20);
            this.AppointmentDiagnosisLabel.Name = "AppointmentDiagnosisLabel";
            this.AppointmentDiagnosisLabel.Size = new System.Drawing.Size(81, 20);
            this.AppointmentDiagnosisLabel.TabIndex = 0;
            this.AppointmentDiagnosisLabel.Text = "Diagnosis: ";
            // 
            // RefleshAppointmentsTableButton
            // 
            this.RefleshAppointmentsTableButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RefleshAppointmentsTableButton.Location = new System.Drawing.Point(577, 362);
            this.RefleshAppointmentsTableButton.Name = "RefleshAppointmentsTableButton";
            this.RefleshAppointmentsTableButton.Size = new System.Drawing.Size(202, 43);
            this.RefleshAppointmentsTableButton.TabIndex = 3;
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
            this.MedicalCardAppointmentsColumn});
            this.AppointmentsDataGrid.Location = new System.Drawing.Point(7, 3);
            this.AppointmentsDataGrid.Name = "AppointmentsDataGrid";
            this.AppointmentsDataGrid.RowHeadersWidth = 51;
            this.AppointmentsDataGrid.RowTemplate.Height = 29;
            this.AppointmentsDataGrid.Size = new System.Drawing.Size(773, 275);
            this.AppointmentsDataGrid.TabIndex = 2;
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
            // MedicalCardAppointmentsColumn
            // 
            this.MedicalCardAppointmentsColumn.HeaderText = "MedicalCard";
            this.MedicalCardAppointmentsColumn.MinimumWidth = 6;
            this.MedicalCardAppointmentsColumn.Name = "MedicalCardAppointmentsColumn";
            this.MedicalCardAppointmentsColumn.Width = 125;
            // 
            // DoctorPersonalInformationTab
            // 
            this.DoctorPersonalInformationTab.Location = new System.Drawing.Point(4, 29);
            this.DoctorPersonalInformationTab.Name = "DoctorPersonalInformationTab";
            this.DoctorPersonalInformationTab.Padding = new System.Windows.Forms.Padding(3);
            this.DoctorPersonalInformationTab.Size = new System.Drawing.Size(787, 412);
            this.DoctorPersonalInformationTab.TabIndex = 1;
            this.DoctorPersonalInformationTab.Text = "Personal information";
            this.DoctorPersonalInformationTab.UseVisualStyleBackColor = true;
            // 
            // DoctorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DoctorTabControl);
            this.Name = "DoctorPanel";
            this.Text = "DoctorPanel";
            this.Load += new System.EventHandler(this.DoctorPanel_Load);
            this.DoctorTabControl.ResumeLayout(false);
            this.DoctorAppointmentsTab.ResumeLayout(false);
            this.OfficeCreationPanel.ResumeLayout(false);
            this.OfficeCreationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl DoctorTabControl;
        private System.Windows.Forms.TabPage DoctorAppointmentsTab;
        private System.Windows.Forms.TabPage DoctorPersonalInformationTab;
        private System.Windows.Forms.Button RefleshAppointmentsTableButton;
        private System.Windows.Forms.DataGridView AppointmentsDataGrid;
        private System.Windows.Forms.Panel OfficeCreationPanel;
        private System.Windows.Forms.Button OfficeAddButton;
        private System.Windows.Forms.TextBox DoctorAppointmentIdTextBox;
        private System.Windows.Forms.TextBox DoctorAppointmentDiagnosisTextBox;
        private System.Windows.Forms.Label AppointmentIdLabel;
        private System.Windows.Forms.Label AppointmentDiagnosisLabel;
        private System.Windows.Forms.Button DoctorAppointmentModifyButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAppointmentsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiagnisisColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicalCardAppointmentsColumn;
    }
}