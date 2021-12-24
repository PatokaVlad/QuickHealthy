using QuickHealthy.BLL.Interfaces;
using QuickHealthy.Client.WinForms.ApiClient;
using QuickHealthy.Client.WinForms.Constants;
using QuickHealthy.PL.Interfaces.Views;
using QuickHealthy.PL.Models;
using QuickHealthy.PL.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuickHealthy.PL.Views
{
    public partial class PatientPanel : Form, IAppointmentView, IDoctorView
    {
        PatientViewModel _patient;

        QuickHealthyClient _client;

        AppointmentPresenter _appointmentPresenter;
        DoctorPresenter _doctorPresenter;

        private List<DoctorViewModel> _doctors;
        private int? _doctorIndex;

        public PatientPanel(QuickHealthyClient client, PatientViewModel patient) {
            InitializeComponent();

            _patient = patient;
            _client = client;

            PatientFirstName.Text = patient.FirstName;
            PatientLastNameValueLabel.Text = patient.LastName;
            PatientBirthDateValueLabel.Text = patient.BirthDate.ToString();
            PatientCityOfBirthValueLabel.Text = patient.CityOfBirth;
            PatientMedicalCardIdValueLabel.Text = patient.MedicalCardId.ToString();

            _appointmentPresenter = new AppointmentPresenter(this, _client);
            _doctorPresenter = new DoctorPresenter(this, _client);
        }

        public void ClearAppointmentCreationControls() {
            DoctorsListBox.ClearSelected();
            DoctorDataLabel.Text = "Doctor: not selected.";
            _doctorIndex = null;
        }

        public void ClearAppointmentUpdateControls() {
        }

        public void LoadAppointments(IEnumerable<AppointmentViewModel> appointments) {
            AppointmentsDataGrid.Rows.Clear();

            foreach (var item in appointments)
            {
                AppointmentsDataGrid.Rows.Add(item.Id, item.DoctorId, item.Diagnosis, item.Date.ToString("dd.MM.yyyy"), item.Time.ToString("hh:mm"));
            }
        }

        public void LoadDoctors(IEnumerable<DoctorViewModel> doctors) {
            _doctors = new List<DoctorViewModel>(doctors);

            DoctorsListBox.Items.Clear();

            foreach (var item in _doctors)
            {
                DoctorsListBox.Items.Add("Id: " + item.Id + " - " + item.FirstName + " " + item.LastName);
            }
        }

        public void ClearDoctorControls() {
        }

        private async void PatientsAppointmentsRefleshButton_Click(object sender, EventArgs e) {
            await _appointmentPresenter.LoadAppointmentsByMedicalCardToView(_patient.MedicalCardId);
        }

        private async void PatientPanel_Load(object sender, EventArgs e) {
            await _doctorPresenter.LoadModelsToView();

            await _appointmentPresenter.LoadAppointmentsByMedicalCardToView(_patient.MedicalCardId);
        }

        private async void CreateAppointmentButton_Click(object sender, EventArgs e) {
            string result = await _appointmentPresenter.Create(new AppointmentViewModel
            {
                Id = 0,
                DoctorId = _doctors[_doctorIndex.Value].Id,
                MedicalCardId = _patient.MedicalCardId.Value,
                Date = AppointmentDatePicker.Value,
                Time = AppointmentTimePicker.Value,
                Diagnosis = ""
            });

            if (!result.Equals(true.ToString()))
            {
                MessageBox.Show(result, "Create error!");
            }

            ClearAppointmentCreationControls();
        }

        private void ChooseDoctorButton_Click(object sender, EventArgs e) {
            if (DoctorsListBox.SelectedItems.Count != 0)
            {
                _doctorIndex = DoctorsListBox.SelectedIndex;

                if (_doctorIndex != null)
                {
                    DoctorDataLabel.Text = "Doctor: " + _doctors[_doctorIndex.Value].FirstName + " " + _doctors[_doctorIndex.Value].LastName;
                }
            }
        }

        private void PatientDiagnosisValueLabel_Click(object sender, EventArgs e)
        {

        }

        private void AppointmentsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DoctorsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
