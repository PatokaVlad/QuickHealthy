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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickHealthy.PL.Views
{
    public partial class AdminPanel : Form, IAppointmentView, IDoctorView, IPatientView, IOfficeView
    {
        private readonly QuickHealthyClient _client;
        
        AppointmentPresenter _appointmentPresenter;
        PatientPresenter _patientPresenter;
        DoctorPresenter _doctorPresenter;
        OfficePresenter _officePresenter;

        public AdminPanel(QuickHealthyClient client) {
            InitializeComponent();

            _client = client;

            _appointmentPresenter = new AppointmentPresenter(this, client);
            _patientPresenter = new PatientPresenter(this, client);
            _doctorPresenter = new DoctorPresenter(this, client);
            _officePresenter = new OfficePresenter(this, client);
        }

        public void ClearAppointmentCreationControls() {
            throw new NotImplementedException();
        }

        public void ClearAppointmentUpdateControls() {
            throw new NotImplementedException();
        }

        public void ClearDoctorControls() {
            DoctorFirstNameTextBox.Clear();
            DoctorLastNameTextBox.Clear();
            JobPositionTextBox.Clear();
            DoctorOfficeIdTextBox.Clear();
        }

        public void ClearOfficeControls() {
            OfficeDescriptionTextBox.Clear();
            OfficeDoctorIdTextBox.Clear();
        }

        public void ClearPatientControls() {
            throw new NotImplementedException();
        }

        public void LoadAppointments(IEnumerable<AppointmentViewModel> appointments) {
            AppointmentsDataGrid.Rows.Clear();

            foreach (var item in appointments)
            {
                AppointmentsDataGrid.Rows.Add(item.Id, item.Date.ToString("dd.MM.yyyy"), item.Time.ToString("hh:mm"),
                                                item.Diagnosis, item.DoctorId, item.MedicalCardId);
            }
        }

        public void LoadDoctors(IEnumerable<DoctorViewModel> doctors) {
            DoctorsDataGrid.Rows.Clear();

            foreach (var item in doctors)
            {
                DoctorsDataGrid.Rows.Add(item.Id, item.FirstName, item.LastName, item.JobPosition,
                                            item.StartWorkTime.ToString("HH:mm"), item.EndWorkTime.ToString("HH:mm"), item.OfficeId);
            }
        }

        public void LoadOffices(IEnumerable<OfficeViewModel> offices) {
            OfficesDateGrid.Rows.Clear();

            foreach (var item in offices)
            {
                OfficesDateGrid.Rows.Add(item.Id, item.Description, item.DoctorId);
            }
        }

        public void LoadPatients(IEnumerable<PatientViewModel> appointments) {
            PatientsDataGrid.Rows.Clear();

            foreach (var item in appointments)
            {
                PatientsDataGrid.Rows.Add(item.Id, item.FirstName, item.LastName,
                                            item.CityOfBirth, item.BirthDate.ToString("dd.MM.yyyy"), item.MedicalCardId);
            }
        }

        private async void AdminPanel_Load(object sender, EventArgs e) {
            await _appointmentPresenter.LoadModelsToView();
            await _patientPresenter.LoadModelsToView();
            await _doctorPresenter.LoadModelsToView();
            await _officePresenter.LoadModelsToView();
        }

        private async void RefleshAppointmentsTableButton_Click(object sender, EventArgs e) {
            await _appointmentPresenter.LoadModelsToView();
        }

        private async void RefleshPatientsTableButton_Click(object sender, EventArgs e) {
            await _patientPresenter.LoadModelsToView();
        }

        private async void RefleshOfficesTableButton_Click(object sender, EventArgs e) {
            await _officePresenter.LoadModelsToView();
        }

        private async void RefleshDoctorsTableButton_Click(object sender, EventArgs e) {
            await _doctorPresenter.LoadModelsToView();
        }

        private async void AddDoctorButton_Click(object sender, EventArgs e) {
            string result = await _doctorPresenter.Create(new DoctorViewModel
            {
                FirstName = DoctorFirstNameTextBox.Text,
                LastName = DoctorLastNameTextBox.Text,
                JobPosition = JobPositionTextBox.Text,
                OfficeId = int.Parse(DoctorOfficeIdTextBox.Text),
                StartWorkTime = StartWorkTimeTextBox.Value,
                EndWorkTime = EndWorkTimeTextBox.Value
            });

            ClearDoctorControls();

            if (!result.Equals(true.ToString()))
            {
                MessageBox.Show(result, "Create error!");
            }
        }

        private async void OfficeAddButton_Click(object sender, EventArgs e) {

            int? doctorId;

            if (OfficeDoctorIdTextBox.Text.Equals(null) || OfficeDoctorIdTextBox.Text.Equals(""))
            {
                doctorId = null;
            }
            else
            {
                doctorId = int.Parse(OfficeDoctorIdTextBox.Text);
            }

            string result = await _officePresenter.Create(new OfficeViewModel
            {
                Description = OfficeDescriptionTextBox.Text,
                DoctorId = doctorId
            });

            ClearDoctorControls();

            if (!result.Equals(true.ToString()))
            {
                MessageBox.Show(result, "Create error!");
            }
        }
    }
}
