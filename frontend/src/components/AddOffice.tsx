import { FC , useState } from 'react';
import { Client, OfficeViewModel } from '../api/api';

const apiClient = new Client('https://localhost:5001');

async function CreateOffice(office: OfficeViewModel) {
    await apiClient.officePOST(office);
    console.log('office created');
}

const AddOffice:FC = ()=> {
    const [title, setTitle] = useState('')

    const clickHandler = () => {
        const office : OfficeViewModel = {
            description: title
        };
        CreateOffice(office);
    }

    return(
        <div>
            <form asp-action="AddOffice" asp-controller="Admin">
                <div>
                    <div>
                        <label>Введите description</label>
                        <input value={title} onChange={event => setTitle(event.target.value)} />
                    </div>
                    <div>
                        <input type="submit" onClick={clickHandler.bind(this)} value="Add" />
                    </div>
                </div>
            </form>
        </div>
    );
}

export default AddOffice;