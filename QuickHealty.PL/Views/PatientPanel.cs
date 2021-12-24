using QuickHealthy.BLL.Interfaces;
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

        IAppointmentService _appointmentService;
        IDoctorService _doctorService;

        AppointmentPresenter _appointmentPresenter;
        DoctorPresenter _doctorPresenter;

        private List<DoctorViewModel> _doctors;
        private int? _doctorIndex;

        public PatientPanel(IAppointmentService appointmentService, IDoctorService doctorService, PatientViewModel patient) {
            InitializeComponent();

            _patient = patient;

            _appointmentService = appointmentService;
            _doctorService = doctorService;

            _appointmentPresenter = new AppointmentPresenter(this, _appointmentService);
            _doctorPresenter = new DoctorPresenter(this, _doctorService);
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

        private void PatientsAppointmentsRefleshButton_Click(object sender, EventArgs e) {
            _appointmentPresenter.LoadAppointmentsByMedicalCardToView(_patient.MedicalCardId);
        }

        private void PatientPanel_Load(object sender, EventArgs e) {
            _doctorPresenter.LoadModelsToView();

            _appointmentPresenter.LoadAppointmentsByMedicalCardToView(_patient.MedicalCardId);
        }

        private void CreateAppointmentButton_Click(object sender, EventArgs e) {
            string result = _appointmentPresenter.Create(new AppointmentViewModel
            {
                DoctorId = _doctors[_doctorIndex.Value].Id,
                MedicalCardId = _patient.MedicalCardId.Value,
                Date = AppointmentDatePicker.Value,
                Time = AppointmentTimePicker.Value
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
    }
}
