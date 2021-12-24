
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
            this.DoctorAppointmentsTab = new System.Windows.Forms.TabPage();
            this.AppointmentsDataGrid = new System.Windows.Forms.DataGridView();
            this.MedicalCardAppointmentsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiagnisisColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdAppointmentsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefleshAppointmentsTableButton = new System.Windows.Forms.Button();
            this.OfficeCreationPanel = new System.Windows.Forms.Panel();
            this.AppointmentDiagnosisLabel = new System.Windows.Forms.Label();
            this.AppointmentIdLabel = new System.Windows.Forms.Label();
            this.DoctorAppointmentDiagnosisTextBox = new System.Windows.Forms.TextBox();
            this.DoctorAppointmentIdTextBox = new System.Windows.Forms.TextBox();
            this.OfficeAddButton = new System.Windows.Forms.Button();
            this.DoctorAppointmentModifyButton = new System.Windows.Forms.Button();
            this.DoctorTabControl = new System.Windows.Forms.TabControl();
            this.DoctorAppointmentsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsDataGrid)).BeginInit();
            this.OfficeCreationPanel.SuspendLayout();
            this.DoctorTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // DoctorAppointmentsTab
            // 
            this.DoctorAppointmentsTab.Controls.Add(this.OfficeCreationPanel);
            this.DoctorAppointmentsTab.Controls.Add(this.RefleshAppointmentsTableButton);
            this.DoctorAppointmentsTab.Controls.Add(this.AppointmentsDataGrid);
            this.DoctorAppointmentsTab.Location = new System.Drawing.Point(4, 24);
            this.DoctorAppointmentsTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DoctorAppointmentsTab.Name = "DoctorAppointmentsTab";
            this.DoctorAppointmentsTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DoctorAppointmentsTab.Size = new System.Drawing.Size(688, 306);
            this.DoctorAppointmentsTab.TabIndex = 0;
            this.DoctorAppointmentsTab.Text = "Appointments";
            this.DoctorAppointmentsTab.UseVisualStyleBackColor = true;
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
            this.AppointmentsDataGrid.Location = new System.Drawing.Point(6, 2);
            this.AppointmentsDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AppointmentsDataGrid.Name = "AppointmentsDataGrid";
            this.AppointmentsDataGrid.RowHeadersWidth = 51;
            this.AppointmentsDataGrid.RowTemplate.Height = 29;
            this.AppointmentsDataGrid.Size = new System.Drawing.Size(676, 206);
            this.AppointmentsDataGrid.TabIndex = 2;
            // 
            // MedicalCardAppointmentsColumn
            // 
            this.MedicalCardAppointmentsColumn.HeaderText = "MedicalCard";
            this.MedicalCardAppointmentsColumn.MinimumWidth = 6;
            this.MedicalCardAppointmentsColumn.Name = "MedicalCardAppointmentsColumn";
            this.MedicalCardAppointmentsColumn.Width = 125;
            // 
            // DiagnisisColumn
            // 
            this.DiagnisisColumn.HeaderText = "Diagnosis";
            this.DiagnisisColumn.MinimumWidth = 6;
            this.DiagnisisColumn.Name = "DiagnisisColumn";
            this.DiagnisisColumn.Width = 125;
            // 
            // TimeColumn
            // 
            this.TimeColumn.HeaderText = "Time";
            this.TimeColumn.MinimumWidth = 6;
            this.TimeColumn.Name = "TimeColumn";
            this.TimeColumn.Width = 125;
            // 
            // DateColumn
            // 
            this.DateColumn.HeaderText = "Date";
            this.DateColumn.MinimumWidth = 6;
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.Width = 125;
            // 
            // IdAppointmentsColumn
            // 
            this.IdAppointmentsColumn.HeaderText = "Id";
            this.IdAppointmentsColumn.MinimumWidth = 6;
            this.IdAppointmentsColumn.Name = "IdAppointmentsColumn";
            this.IdAppointmentsColumn.Width = 40;
            // 
            // RefleshAppointmentsTableButton
            // 
            this.RefleshAppointmentsTableButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RefleshAppointmentsTableButton.Location = new System.Drawing.Point(505, 272);
            this.RefleshAppointmentsTableButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RefleshAppointmentsTableButton.Name = "RefleshAppointmentsTableButton";
            this.RefleshAppointmentsTableButton.Size = new System.Drawing.Size(177, 32);
            this.RefleshAppointmentsTableButton.TabIndex = 3;
            this.RefleshAppointmentsTableButton.Text = "Reflesh";
            this.RefleshAppointmentsTableButton.UseVisualStyleBackColor = true;
            this.RefleshAppointmentsTableButton.Click += new System.EventHandler(this.RefleshAppointmentsTableButton_Click);
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
            this.OfficeCreationPanel.Location = new System.Drawing.Point(7, 213);
            this.OfficeCreationPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OfficeCreationPanel.Name = "OfficeCreationPanel";
            this.OfficeCreationPanel.Size = new System.Drawing.Size(482, 91);
            this.OfficeCreationPanel.TabIndex = 7;
            // 
            // AppointmentDiagnosisLabel
            // 
            this.AppointmentDiagnosisLabel.AutoSize = true;
            this.AppointmentDiagnosisLabel.Location = new System.Drawing.Point(13, 15);
            this.AppointmentDiagnosisLabel.Name = "AppointmentDiagnosisLabel";
            this.AppointmentDiagnosisLabel.Size = new System.Drawing.Size(64, 15);
            this.AppointmentDiagnosisLabel.TabIndex = 0;
            this.AppointmentDiagnosisLabel.Text = "Diagnosis: ";
            // 
            // AppointmentIdLabel
            // 
            this.AppointmentIdLabel.AutoSize = true;
            this.AppointmentIdLabel.Location = new System.Drawing.Point(13, 52);
            this.AppointmentIdLabel.Name = "AppointmentIdLabel";
            this.AppointmentIdLabel.Size = new System.Drawing.Size(97, 15);
            this.AppointmentIdLabel.TabIndex = 1;
            this.AppointmentIdLabel.Text = "Appointment id: ";
            // 
            // DoctorAppointmentDiagnosisTextBox
            // 
            this.DoctorAppointmentDiagnosisTextBox.Location = new System.Drawing.Point(89, 13);
            this.DoctorAppointmentDiagnosisTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DoctorAppointmentDiagnosisTextBox.Name = "DoctorAppointmentDiagnosisTextBox";
            this.DoctorAppointmentDiagnosisTextBox.Size = new System.Drawing.Size(175, 23);
            this.DoctorAppointmentDiagnosisTextBox.TabIndex = 2;
            // 
            // DoctorAppointmentIdTextBox
            // 
            this.DoctorAppointmentIdTextBox.Location = new System.Drawing.Point(124, 50);
            this.DoctorAppointmentIdTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DoctorAppointmentIdTextBox.Name = "DoctorAppointmentIdTextBox";
            this.DoctorAppointmentIdTextBox.Size = new System.Drawing.Size(140, 23);
            this.DoctorAppointmentIdTextBox.TabIndex = 3;
            // 
            // OfficeAddButton
            // 
            this.OfficeAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OfficeAddButton.Location = new System.Drawing.Point(725, 22);
            this.OfficeAddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OfficeAddButton.Name = "OfficeAddButton";
            this.OfficeAddButton.Size = new System.Drawing.Size(50, 90);
            this.OfficeAddButton.TabIndex = 4;
            this.OfficeAddButton.Text = "Add";
            this.OfficeAddButton.UseVisualStyleBackColor = true;
            // 
            // DoctorAppointmentModifyButton
            // 
            this.DoctorAppointmentModifyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DoctorAppointmentModifyButton.Location = new System.Drawing.Point(401, -1);
            this.DoctorAppointmentModifyButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DoctorAppointmentModifyButton.Name = "DoctorAppointmentModifyButton";
            this.DoctorAppointmentModifyButton.Size = new System.Drawing.Size(72, 90);
            this.DoctorAppointmentModifyButton.TabIndex = 5;
            this.DoctorAppointmentModifyButton.Text = "Modify";
            this.DoctorAppointmentModifyButton.UseVisualStyleBackColor = true;
            this.DoctorAppointmentModifyButton.Click += new System.EventHandler(this.DoctorAppointmentModifyButton_Click);
            // 
            // DoctorTabControl
            // 
            this.DoctorTabControl.Controls.Add(this.DoctorAppointmentsTab);
            this.DoctorTabControl.Location = new System.Drawing.Point(0, 0);
            this.DoctorTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DoctorTabControl.Name = "DoctorTabControl";
            this.DoctorTabControl.SelectedIndex = 0;
            this.DoctorTabControl.Size = new System.Drawing.Size(696, 334);
            this.DoctorTabControl.TabIndex = 0;
            // 
            // DoctorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.DoctorTabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DoctorPanel";
            this.Text = "DoctorPanel";
            this.Load += new System.EventHandler(this.DoctorPanel_Load);
            this.DoctorAppointmentsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsDataGrid)).EndInit();
            this.OfficeCreationPanel.ResumeLayout(false);
            this.OfficeCreationPanel.PerformLayout();
            this.DoctorTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage DoctorAppointmentsTab;
        private System.Windows.Forms.Panel OfficeCreationPanel;
        private System.Windows.Forms.Button DoctorAppointmentModifyButton;
        private System.Windows.Forms.Button OfficeAddButton;
        private System.Windows.Forms.TextBox DoctorAppointmentIdTextBox;
        private System.Windows.Forms.TextBox DoctorAppointmentDiagnosisTextBox;
        private System.Windows.Forms.Label AppointmentIdLabel;
        private System.Windows.Forms.Label AppointmentDiagnosisLabel;
        private System.Windows.Forms.Button RefleshAppointmentsTableButton;
        private System.Windows.Forms.DataGridView AppointmentsDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAppointmentsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiagnisisColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicalCardAppointmentsColumn;
        private System.Windows.Forms.TabControl DoctorTabControl;
    }
}