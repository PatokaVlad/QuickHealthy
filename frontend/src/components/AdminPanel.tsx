import {NavLink} from 'react-router-dom'

const App = () => {
  return (
      <div>
          <div>
              <NavLink to={'appointments'}>Appointments</NavLink>
          </div>
          <div>
              <NavLink to={'patients'}>Patients</NavLink>
          </div>
          <div>
              <NavLink to={'offices'}>Offices</NavLink>
          </div>
          <div>
              <NavLink to={'doctors'}>Doctors</NavLink>
          </div>
      </div>
  );
};

export default App;