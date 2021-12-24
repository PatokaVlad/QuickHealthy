import { FC , useState } from 'react'
import '../App.css'
import { DatePickerComponent } from '@syncfusion/ej2-react-calendars';
import { Client, PatientViewModel } from '../api/api'
import "react-datepicker/dist/react-datepicker.css"

const apiClient = new Client('https://localhost:5001');

async function CreatePatient(patient: PatientViewModel) {
    await apiClient.patientPOST(patient);
    console.log('patient created');
}

const AddPatient:FC = ()=> {
    const [firstName, setFirstName] = useState('')
    const [lastName, setLastName] = useState('')
    const [userName, setuserName] = useState('')
    const [password, setpassword] = useState('')
    const [cityOfBirth, setcityOfBirth] = useState('')
    const [birthDate, setbirthDate] = useState(new Date)

const addsetbirthDate = (datepicker: Date) =>{
    setbirthDate(datepicker);
}

    const clickHandler = () => {
        const doctor : PatientViewModel = {
            firstName: firstName,
            lastName: lastName,
            username: userName,
            password:password,
            cityOfBirth: cityOfBirth,
            birthDate: birthDate
        };
        CreatePatient(doctor);
    }

    return(
        <div>
            <form>
                <div>
                    <label>Введите FirstName</label>
                    <input value={firstName} onChange={event => setFirstName(event.target.value)} />
                </div>
                <div>
                        <label>Введите LastName</label>
                        <input value={lastName} onChange={event => setLastName(event.target.value)} />
                </div>
                <div>
                    <label >Введите Username</label>
                    <input value={userName} onChange={event => setuserName(event.target.value)} />
                </div>
                <div>
                    <label >Введите password</label>
                    <input value={password} onChange={event => setpassword(event.target.value)} />
                </div>
                <div>
                    <label>Введите birth date</label>
                    <DatePickerComponent width={200} value={birthDate} change={date => addsetbirthDate(date.value)}/>
                </div>
                <div>
                    <label>Введите city of birth</label>
                    <input value={cityOfBirth} onChange={event => setcityOfBirth(event.target.value)} />
                </div>
                <div>
                    <input type="submit" onClick={clickHandler.bind(this)} value="Add" />
                </div>
            </form>
        </div>
    );
}

export default AddPatient;