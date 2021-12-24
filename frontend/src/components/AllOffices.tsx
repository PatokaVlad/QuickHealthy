import { FC , useEffect, useState } from 'react'
import { NavLink } from 'react-router-dom'
import { Client, OfficeViewModel } from '../api/api'

const apiClient = new Client('https://localhost:5001');

const AllOffices:FC = ()=> {
    const [offices, setOffices] = useState<OfficeViewModel[] | undefined>(undefined);
  
    async function GetOffices() {
        const officesListVM = await apiClient.officeAll();
        setOffices(officesListVM);
    }

    useEffect(() => {
        GetOffices();
    }, []);
  
    return(
        <div>
            Offices
            <div>
                <table className='table table-striped' aria-labelledby="tabelLabel">
                    <thead>
                        <tr>
                            <th>Id</th>
                            <th>Description</th>
                            <th>Doctor id</th>
                        </tr>
                    </thead>
                    <tbody>
                      {offices?.map((office) => (
                          <tr key={office.id}>
                          <td>{office.id}</td>
                          <td>{office.description}</td>
                          <td>{office.doctorId}</td>
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