import 'bootstrap/dist/css/bootstrap.css';
import { useState } from 'react';


function App()
{
  const [tytul, ustawTytul] = useState();
  const [rodzaj, ustawRodzaj] = useState();

  const onSubmit = (e) => {
    e.preventDefault();
    console.log(`tytul: ${tytul}; rodzaj: ${rodzaj}`);
  }

  return(
    <div className='container'>
      <form onSubmit={onSubmit}>
        <div className='form-group'>
          <label htmlFor="tytulFilmu">Tytuł filmu</label>
          <input id="tytulFilmu" className='form-control' onChange={(e) => ustawTytul(e.target.value)}></input>

          <label htmlFor='rodzaj' className='mt-3'>Rodzaj</label>
          <select id='select' className='form-select' onChange={(e) => ustawRodzaj(e.target.value)}>
            <option></option>
            <option value="1">Komedia</option>
            <option value="2">Obyczajowy</option>
            <option value="3">Sensacyjny</option>
            <option value="4">Horror</option>
          </select>
          <button className='btn btn-primary mt-3'>Dodaj</button>
        </div>
      </form>
    </div>
  )
}

export default App;