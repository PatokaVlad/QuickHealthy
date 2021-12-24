import {NavLink} from 'react-router-dom'

const App = () => {
  return (
      <div>
          <div>
              <NavLink to={'login'}>Login</NavLink>
          </div>
          <div>
              <NavLink to={'register'}>Register</NavLink>
          </div>
      </div>
  );
};

export default App;