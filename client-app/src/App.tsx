import { useEffect, useState } from 'react'
import './App.css'
import axios from 'axios';

function App() {
  const [institutions, setInstitutions] = useState([]);

  useEffect(() => {

    axios.get('http://localhost:5000/api/institution')
      .then(response => {
        setInstitutions(response.data)
      })
  }, [])


  return (
    <div>
      <h1 className='text-4xl font-bold'>OTB</h1>
      <ul>
        {institutions.map((institution: any) => (
          <li className='font-bold underline' key={institution.id}>
            {institution.name + ' ' + '(' + institution.phone + ')'}
          </li>
        ))}
      </ul>
    </div>

  )
}

export default App
