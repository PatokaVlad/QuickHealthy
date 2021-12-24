import { FC , useState } from 'react'
import '../App.css'
import { TimePickerComponent } from '@syncfusion/ej2-react-calendars';

import { Client, DoctorViewModel } from '../api/api'

import "react-datepicker/dist/react-datepicker.css"

const apiClient = new Client('https://localhost:5001');

async function CreateDoctor(doctor: DoctorViewModel) {
    await apiClient.doctorPOST(doctor);
    console.log('doctor created');
}

const AddDoctor:FC = ()=> {
    const [firstName, setFirstName] = useState('')
    const [lastName, setLastName] = useState('')
    const [jobPosition, setJobPosition] = useState('')
    const [startWorkTime, setStartWorkTime] = useState(new Date)
    const [endWorkTime, setEndWorkTime] = useState(new Date)
    const [officeId, setOfficeId] = useState(Number)

const addStartWorkTime = (datepicker: Date) =>{
    setStartWorkTime(datepicker);
}

const addEndWorkTime = (datepicker: Date) =>{
    setEndWorkTime(datepicker);
}

    const clickHandler = () => {
        const doctor : DoctorViewModel = {
            firstName: firstName,
            lastName: lastName,
            jobPosition: jobPosition,
            startWorkTime: startWorkTime,
            endWorkTime: endWorkTime,
            officeId: officeId
        };
        CreateDoctor(doctor);
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
                    <label >Введите JobPosition</label>
                    <input value={jobPosition} onChange={event => setJobPosition(event.target.value)} />
                </div>
                <div>
                    <label >Введите StartWorkTime</label>
                    <TimePickerComponent width={200} step={5} value={startWorkTime} change={date => addStartWorkTime(date.value)}/>
                </div>
                <div>
                    <label>Введите EndWorkTime</label>
                    <TimePickerComponent width={200} step={5} value={endWorkTime} change={date => addEndWorkTime(date.value)}/>
                </div>
                <div>
                    <label>Введите OfficeId</label>
                    <input value={officeId} onChange={event => setOfficeId(Number(event.target.value))} />
                </div>
                <div>
                    <input type="submit" onClick={clickHandler.bind(this)} value="Add" />
                </div>
            </form>
        </div>
    );
}

export default AddDoctor;