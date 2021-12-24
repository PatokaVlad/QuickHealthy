import {FC,ReactElement, useEffect, useState } from 'react';
import { Client, AppointmentViewModel } from '../api/api';
import { NavLink } from 'react-router-dom'

const apiClient = new Client('https://localhost:5001');

const AllAppointments : FC = (): ReactElement => {
  const [appointments, setAppointments] = useState<AppointmentViewModel[] | undefined>(undefined);

  async function GetAppointments() {
      const appointmnetListVm = await apiClient.appointmentAll();
      setAppointments(appointmnetListVm);
  }

  useEffect(() => {
      GetAppointments();
  }, []);

  return(
      <div>
          Appointments
          <div>
              <table className='table table-striped' aria-labelledby="tabelLabel">
                  <thead>
                      <tr>
                          <th>Id</th>
                          <th>Doctor id</th>
                          <th>Medical card id</th>
                          <th>Diagnosis</th>
                          <th>Date</th>
                          <th>Time</th>
                      </tr>
                  </thead>
                  <tbody>
                    {appointments?.map((appointment) => (
                        <tr key={appointment.id}>
                        <td>{appointment.id}</td>
                        <td>{appointment.doctorId}</td>
                        <td>{appointment.medicalCardId}</td>
                        <td>{appointment.diagnosis}</td>
                        <td>{new Date(appointment.date!).toLocaleDateString()}</td>
                        <td>{new Date(appointment.time!).toLocaleTimeString()}</td>
                        </tr>
                    ))}
                  </tbody>
              </table>
          </div>

          <div>
              <NavLink to={'add'}>Add</NavLink>
          </div>
      </div>
  );
}

export default AllAppointments;