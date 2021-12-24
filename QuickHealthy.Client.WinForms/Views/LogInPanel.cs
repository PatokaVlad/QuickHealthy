using QuickHealthy.BLL.Interfaces;
using QuickHealthy.Client.WinForms.ApiClient;
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
        private readonly QuickHealthyClient _client;

        PatientPresenter _patientPresenter;
        MedicalCardPresenter _medicalCardPresenter;
        DoctorPresenter _doctorPresenter;

        List<PatientViewModel> _patients;

        public LogInPanel(QuickHealthyClient client) {
            InitializeComponent();

            _client = client;

            _patientPresenter = new PatientPresenter(this, client);
            _medicalCardPresenter = new MedicalCardPresenter(this, client);
            _doctorPresenter = new DoctorPresenter(this, client);
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

        public async void LogIn() {
            foreach (var item in _patients)
            {
                if (item.Username.Equals(PatientLogInUsernameTextBox.Text))
                {
                    if (item.Password.Equals(PatientLogInPasswordTextBox.Text))
                    {
                        if (item.MedicalCardId == null)
                        {
                            await _medicalCardPresenter.Create(new MedicalCardViewModel
                            {
                                PatientId = item.Id
                            });

                            item.MedicalCardId = _medicalCardPresenter.GetMedicalCardByPatient(item.Id).Id;
                        }

                        var window = new PatientPanel(_client, item);
                        window.Show();
                        //this.Hide();
                    }
                }
            }
        }

        private async void PatientRegisterButton_Click(object sender, EventArgs e) {
            await _patientPresenter.Create(new PatientViewModel
            {
                Username = PatientRegistrationUsernameTextBox.Text,
                Password = PatientRegistrationPasswordTextBox.Text,
                FirstName = PatientRegistrationFirstNameTextBox.Text,
                LastName = PatientRegistrationLastNameTextBox.Text,
                CityOfBirth = PatientRegistrationCityTextBox.Text,
                BirthDate = PatientRegistrationBirthDatePicker.Value
            });
        }

        private async void PatientLogInButton_Click(object sender, EventArgs e) {
            await _patientPresenter.LoadModelsToView();
            LogIn();
        }

        private void OpenAdminPanelButton_Click(object sender, EventArgs e) {
            var window = new AdminPanel(_client);
            window.Show();
            //this.Hide();
        }

        public void LoadMedicalCards(IEnumerable<MedicalCardViewModel> medicalCards) {

        }

        public void ClearMedicalCardCreationControls() {

        }

        public void ClearMedicalCardUpdateControls() {

        }

        private async void OpenDoctorPanelButton_Click(object sender, EventArgs e) {

            DoctorViewModel doctor = await _doctorPresenter.Get(int.Parse(DoctorIdTextBox.Text));
            var window = new DoctorPanel(doctor, _client);
            window.Show();
            //this.Hide();
        }

        public void LoadDoctors(IEnumerable<DoctorViewModel> doctors) {
        }

        public void ClearDoctorControls() {
        }
    }
}
