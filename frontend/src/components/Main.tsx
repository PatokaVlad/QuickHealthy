import AdminPanel from './AdminPanel'
import PatientPanel from './PatientPanel'
import DoctorPanel from './DoctorPanel'
import AllAppointments from './AllAppointments'
import AllOffices from './AllOffices'
import AllPatients from './AllPatients'
import AllDoctors from './AllDoctors'
import AddOffice from './AddOffice'
import AddDoctor from './AddDoctor'
import AddPatient from './AddPatient'
import AddAppointment from './AddAppointment'
import { Navbar, Nav, NavDropdown } from "react-bootstrap";
import {BrowserRouter, Route, Routes, NavLink} from 'react-router-dom'


const Main = () => {
  return (
    <BrowserRouter>
      <div>
          <div>
          <Navbar>
              <NavDropdown title="Patients" id="basic-nav-dropdown">
                <NavLink to={'patient'}>Main</NavLink>
              </NavDropdown>

              <NavDropdown title="Doctors" id="basic-nav-dropdown">
                <NavLink to={'doctor'}>Main</NavLink>
              </NavDropdown>

              <NavDropdown title="Admin panel" id="basic-nav-dropdown">
              <Nav>
                <NavLink to={'admin/appointments'}>Appointments</NavLink>
              </Nav>
              <Nav>
                <NavLink to={'admin/patients'}>Patients</NavLink>
              </Nav>
              <Nav>
                <NavLink to={'admin/offices'}>Offices</NavLink>
              </Nav>
              <Nav>
                <NavLink to={'admin/doctors'}>Doctors</NavLink>
              </Nav>
              </NavDropdown>
          </Navbar>
          </div>
        <Routes>
          <Route path={'/patient'} element={<PatientPanel />} />
        </Routes>
        <Routes>
          <Route path={'/doctor'} element={<DoctorPanel />} />
        </Routes>
        <Routes>
          <Route path={'/admin'} element={<AdminPanel />} />
          <Route path={'admin/appointments'} element={<AllAppointments />} />
          <Route path={'admin/appointments/add'} element={<AddAppointment />} />
          <Route path={'admin/patients'} element={<AllPatients />} />
          <Route path={'admin/patients/add'} element={<AddPatient />} />
          <Route path={'admin/offices'} element={<AllOffices />} />
          <Route path={'admin/offices/add'} element={<AddOffice />} />
          <Route path={'admin/doctors'} element={<AllDoctors />} />
          <Route path={'admin/doctors/add'} element={<AddDoctor />} />
        </Routes>
      </div>
    </BrowserRouter>
  );
};

export default Main;