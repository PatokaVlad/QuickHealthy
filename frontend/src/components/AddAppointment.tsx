import { FC , useState } from 'react'
import '../App.css'
import { DatePickerComponent, TimePickerComponent } from '@syncfusion/ej2-react-calendars';
import { Client, AppointmentViewModel } from '../api/api'
import "react-datepicker/dist/react-datepicker.css"

const apiClient = new Client('https://localhost:5001');

async function CreateAppointment(appointment: AppointmentViewModel) {
    await apiClient.appointmentPOST(appointment);
    console.log('appointment created');
}

const AddAppointment:FC = ()=> {
    const [doctorId, setdoctorId] = useState(Number)
    const [medicalCardId, setmedicalCardId] = useState(Number)
    const [diagnosis, setdiagnosis] = useState('')
    const [time, settime] = useState(new Date)
    const [date, setdate] = useState(new Date)

const addsetDate = (datepicker: Date) =>{
    setdate(datepicker);
}

const addsetTime = (timepicker: Date) =>{
    settime(timepicker);
}

    const clickHandler = () => {
        const appointment : AppointmentViewModel = {
            date : date,
            time :time,
            diagnosis: diagnosis ,
            doctorId : doctorId,
            medicalCardId: medicalCardId
        };
        CreateAppointment(appointment);
    }

    return(
        <div>
            <form>
                <div>
                    <label>Введите diagnosis</label>
                    <input value={diagnosis} onChange={event => setdiagnosis(event.target.value)} />
                </div>
                <div>
                    <label>Выберите doctor id</label>
                    <input value={doctorId} onChange={event => setdoctorId(Number(event.target.value))} />
                </div>
                <div>
                    <label >Введите medical card id</label>
                    <input value={medicalCardId} onChange={event => setmedicalCardId(Number(event.target.value))} />
                </div>
                <div>
                    <label>Введите date</label>
                    <DatePickerComponent width={200} value={date} change={date => addsetDate(date.value)}/>
                </div>
                <div>
                    <label>Введите time</label>
                    <TimePickerComponent width={200} value={time} change={date => addsetTime(date.value)}/>
                </div>
                <div>
                    <input type="submit" onClick={clickHandler.bind(this)} value="Add" />
                </div>
            </form>
        </div>
    );
}

export default AddAppointment;