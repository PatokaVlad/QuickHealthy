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
    public partial class DoctorPanel : Form, IAppointmentView, IMedicalCardView
    {
        DoctorViewModel _doctor;

        IAppointmentService _appointmentService;
        IMedicalCardService _medicalCardService;

        AppointmentPresenter _appointmentPresenter;
        MedicalCardPresenter _medicalCardPresenter;

        public DoctorPanel(IAppointmentService appointmentService, IMedicalCardService medicalCardService, DoctorViewModel doctor) {
            InitializeComponent();

            _doctor = doctor;

            _appointmentService = appointmentService;
            _medicalCardService = medicalCardService;

            _appointmentPresenter = new AppointmentPresenter(this, _appointmentService);
            _medicalCardPresenter = new MedicalCardPresenter(this, _medicalCardService);
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

        private void DoctorPanel_Load(object sender, EventArgs e) {
            _appointmentPresenter.LoadAppointmentsByDoctorToView(_doctor.Id);
        }

        private void DoctorAppointmentModifyButton_Click(object sender, EventArgs e) {
            _appointmentService.AddAppointmentDiagnosis(int.Parse(DoctorAppointmentIdTextBox.Text), DoctorAppointmentDiagnosisTextBox.Text);
            _medicalCardPresenter.UpdateLastAppointmentId(_appointmentPresenter.Get(int.Parse(DoctorAppointmentIdTextBox.Text)).MedicalCardId,
                                                        int.Parse(DoctorAppointmentIdTextBox.Text));
            ClearAppointmentUpdateControls();
        }

        private void RefleshAppointmentsTableButton_Click(object sender, EventArgs e) {
            _appointmentPresenter.LoadAppointmentsByDoctorToView(_doctor.Id);
        }

        public void LoadMedicalCards(IEnumerable<MedicalCardViewModel> medicalCards) {
        }

        public void ClearMedicalCardCreationControls() {
        }

        public void ClearMedicalCardUpdateControls() {
        }
    }
}
