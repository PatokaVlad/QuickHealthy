import { FC , useEffect, useState } from 'react';
import { NavLink } from 'react-router-dom'
import { Client, PatientViewModel } from '../api/api';

const apiClient = new Client('https://localhost:5001');

const AllPatients:FC = ()=> {
    const [patients, setPatients] = useState<PatientViewModel[] | undefined>(undefined);
  
    async function GetPatients() {
        const patientsListVM = await apiClient.patientAll();
        setPatients(patientsListVM);
    }
    

  useEffect(() => {
    GetPatients();
}, []);
  
    return(
        <div>
            Patients
            <div>
                <table className='table table-striped' aria-labelledby="tabelLabel">
                    <thead>
                        <tr>
                            <th>Id</th>
                            <th>First name</th>
                            <th>Last name</th>
                            <th>Medical card id</th>
                            <th>Birth date</th>
                            <th>City of birth</th>
                        </tr>
                    </thead>
                    <tbody>
                      {patients?.map((patient) => (
                          <tr key={patient.id}>
                          <td>{patient.id}</td>
                          <td>{patient.firstName}</td>
                          <td>{patient.lastName}</td>
                          <td>{patient.medicalCardId}</td>
                          <td>{new Date(patient.birthDate!).toLocaleDateString()}</td>
                          <td>{patient.cityOfBirth}</td>
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

export default AllPatients;