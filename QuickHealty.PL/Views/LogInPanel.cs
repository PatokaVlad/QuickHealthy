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
    public partial class LogInPanel : Form, IPatientView, IMedicalCardView, IDoctorView
    {
        IAppointmentService _appointmentService;
        IDoctorService _doctorService;
        IMedicalCardService _medicalCardService;
        IOfficeService _officeService;
        IPatientService _patientService;

        PatientPresenter _patientPresenter;
        MedicalCardPresenter _medicalCardPresenter;
        DoctorPresenter _doctorPresenter;

        List<PatientViewModel> _patients;

        public LogInPanel(IPatientService patientService, IAppointmentService appointmentService, IMedicalCardService medicalCardService,
                            IOfficeService officeService, IDoctorService doctorService) {
            InitializeComponent();

            _patientService = patientService;
            _doctorService = doctorService;
            _appointmentService = appointmentService;
            _officeService = officeService;
            _medicalCardService = medicalCardService;

            _patientPresenter = new PatientPresenter(this, _patientService);
            _medicalCardPresenter = new MedicalCardPresenter(this, _medicalCardService);
            _doctorPresenter = new DoctorPresenter(this, _doctorService);
        }

        public void ClearPatientControls() {
            PatientRegistrationFirstNameTextBox.Clear();
            PatientRegistrationLastNameTextBox.Clear();
            PatientRegistrationUsernameTextBox.Clear();
            PatientRegistrationPasswordTextBox.Clear();
            PatientRegistrationCityTextBox.Clear();
        }

        public void LoadPatients(IEnumerable<PatientViewModel> patients) {
            _patients = new List<PatientViewModel>(patients);
        }

        public void LogIn() {
            foreach (var item in _patients)
            {
                if (item.Username.Equals(PatientLogInUsernameTextBox.Text))
                {
                    if (item.Password.Equals(PatientLogInPasswordTextBox.Text))
                    {
                        if (item.MedicalCardId == null)
                        {
                            _medicalCardPresenter.Create(new MedicalCardViewModel
                            {
                                PatientId = item.Id
                            });

                            item.MedicalCardId = _medicalCardPresenter.GetMedicalCardByPatient(item.Id).Id;
                        }

                        var window = new PatientPanel(_appointmentService, _doctorService, item);
                        window.Show();
                        //this.Hide();
                    }
                }
            }
        }

        private void PatientRegisterButton_Click(object sender, EventArgs e) {
            _patientPresenter.Create(new PatientViewModel
            {
                Username = PatientRegistrationUsernameTextBox.Text,
                Password = PatientRegistrationPasswordTextBox.Text,
                FirstName = PatientRegistrationFirstNameTextBox.Text,
                LastName = PatientRegistrationLastNameTextBox.Text,
                CityOfBirth = PatientRegistrationCityTextBox.Text,
                BirthDate = PatientRegistrationBirthDatePicker.Value
            });
        }

        private void PatientLogInButton_Click(object sender, EventArgs e) {
            _patientPresenter.LoadModelsToView();
            LogIn();
        }

        private void OpenAdminPanelButton_Click(object sender, EventArgs e) {
            var window = new AdminPanel(_appointmentService, _patientService, _doctorService, _officeService);
            window.Show();
            //this.Hide();
        }

        public void LoadMedicalCards(IEnumerable<MedicalCardViewModel> medicalCards) {

        }

        public void ClearMedicalCardCreationControls() {

        }

        public void ClearMedicalCardUpdateControls() {

        }

        private void OpenDoctorPanelButton_Click(object sender, EventArgs e) {

            DoctorViewModel doctor = _doctorPresenter.Get(int.Parse(DoctorIdTextBox.Text));
            var window = new DoctorPanel(_appointmentService, _medicalCardService, doctor);
            window.Show();
            //this.Hide();
        }

        public void LoadDoctors(IEnumerable<DoctorViewModel> doctors) {
            throw new NotImplementedException();
        }

        public void ClearDoctorControls() {
            throw new NotImplementedException();
        }
    }
}
