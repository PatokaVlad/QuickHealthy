import { FC , useEffect, useState } from 'react';
import { Client, DoctorViewModel } from '../api/api';
import { NavLink } from 'react-router-dom';

const apiClient = new Client('https://localhost:5001');

const AllOffices:FC = ()=> {
    const [doctors, setDoctor] = useState<DoctorViewModel[] | undefined>(undefined);
  
    async function GetDoctors() {
        const doctorsListVM = await apiClient.doctorAll();
        setDoctor(doctorsListVM);
    }

    useEffect(() => {
        GetDoctors();
    }, []);
  
    return(
        <div>
            Doctors
            <div>
                <table className='table table-striped' aria-labelledby="tabelLabel">
                    <thead>
                        <tr>
                            <th>Id</th>
                            <th>First name</th>
                            <th>Last name</th>
                            <th>Start work time</th>
                            <th>End work time</th>
                            <th>Job position</th>
                            <th>Office id</th>
                        </tr>
                    </thead>
                    <tbody>
                      {doctors?.map((doctor) => (
                          <tr key={doctor.id}>
                          <td>{doctor.id}</td>
                          <td>{doctor.firstName}</td>
                          <td>{doctor.lastName}</td>
                          <td>{new Date(doctor.startWorkTime!).toLocaleTimeString()}</td>
                          <td>{new Date(doctor.endWorkTime!).toLocaleTimeString()}</td>
                          <td>{doctor.jobPosition}</td>
                          <td>{doctor.officeId}</td>
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

export default AllOffices;