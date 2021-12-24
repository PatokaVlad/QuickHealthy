using QuickHealthy.BLL.Interfaces;
using QuickHealthy.Client.WinForms.ApiClient;
using QuickHealthy.PL.Models;
using QuickHealthy.PL.Presenters;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuickHealty.PL2
{
    public partial class ApppointmentsList : Form, QuickHealthy.PL.Interfaces.Views.IAppointmentView
    {
        AppointmentPresenter _appointmentPresenter;

        public ApppointmentsList(QuickHealthyClient _client) {
            InitializeComponent();

            _appointmentPresenter = new AppointmentPresenter(this, _client);
        }

        private async void ApppointmentsList_Load(object sender, EventArgs e) {
            await _appointmentPresenter.LoadModelsToView();
        }

        public void LoadAppointments(IEnumerable<AppointmentViewModel> appointments) {
            AppointmentsListBox.Items.Clear();
            foreach (var item in appointments)
            {
                AppointmentsListBox.Items.Add($"Id: {item.Id}, Diagnosis: {item.Diagnosis}, Date: {item.Date.ToString("dd/MM/yyyy")}");
            }
        }

        public void ClearAppointmentCreationControls() {
            DoctorIdTextBox.Clear();
            PatientIdTextBox.Clear();
            OfficeIdTextBox.Clear();
            DateTextBox.Clear();
            DiagnosisTextBox.Clear();
            TimeTextBox.Clear();
        }

        private async void CreateAppointmentButton_Click(object sender, EventArgs e) {
            await _appointmentPresenter.Create(new AppointmentViewModel());
        }

        private async void RefleshButton_Click(object sender, EventArgs e) {
            await _appointmentPresenter.LoadModelsToView();
        }

        public void ClearAppointmentUpdateControls() {
            throw new NotImplementedException();
        }
    }
}
