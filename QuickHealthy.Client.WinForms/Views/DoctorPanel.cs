using QuickHealthy.Client.WinForms.ApiClient;
using QuickHealthy.PL.Interfaces.Views;
using QuickHealthy.PL.Models;
using QuickHealthy.PL.Presenters;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuickHealthy.PL.Views
{
    public partial class DoctorPanel : Form, IAppointmentView, IMedicalCardView
    {
        DoctorViewModel _doctor;

        AppointmentPresenter _appointmentPresenter;
        MedicalCardPresenter _medicalCardPresenter;

        public DoctorPanel(DoctorViewModel doctor, QuickHealthyClient client) {
            InitializeComponent();

            _doctor = doctor;

            _appointmentPresenter = new AppointmentPresenter(this, client);
            _medicalCardPresenter = new MedicalCardPresenter(this, client);
        }

        public void ClearAppointmentCreationControls() {
        }

        public void ClearAppointmentUpdateControls() {
            DoctorAppointmentDiagnosisTextBox.Clear();
            DoctorAppointmentIdTextBox.Clear();
        }

        public void LoadAppointments(IEnumerable<AppointmentViewModel> appointments) {
            AppointmentsDataGrid.Rows.Clear();

            foreach (var item in appointments)
            {
                AppointmentsDataGrid.Rows.Add(item.Id, item.Date.ToString("dd.MM.yyyy"), item.Time.ToString("hh:mm"),
                                                item.Diagnosis, item.MedicalCardId);
            }
        }

        private async void DoctorPanel_Load(object sender, EventArgs e) {
            await _appointmentPresenter.LoadAppointmentsByDoctorToView(_doctor.Id);
        }

        private async void DoctorAppointmentModifyButton_Click(object sender, EventArgs e) {
            await _appointmentPresenter.UpdateAppointmentDiagnosis(int.Parse(DoctorAppointmentIdTextBox.Text), DoctorAppointmentDiagnosisTextBox.Text);
            var appointment = await _appointmentPresenter.Get(int.Parse(DoctorAppointmentIdTextBox.Text));
            await _medicalCardPresenter.UpdateLastAppointmentId(appointment.MedicalCardId,
                                                        int.Parse(DoctorAppointmentIdTextBox.Text));
            ClearAppointmentUpdateControls();
        }

        private async void RefleshAppointmentsTableButton_Click(object sender, EventArgs e) {
            await _appointmentPresenter.LoadAppointmentsByDoctorToView(_doctor.Id);
        }

        public void LoadMedicalCards(IEnumerable<MedicalCardViewModel> medicalCards) {
        }

        public void ClearMedicalCardCreationControls() {
        }

        public void ClearMedicalCardUpdateControls() {
        }
    }
}
