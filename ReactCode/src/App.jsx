import {  useState } from 'react'
import { Row, Col,Button} from "react-bootstrap"
import Input from './Components/Input'
import Select from './Components/Select'
import axios from 'axios';
import './App.css'

function App() {
    const [firstProbability, setFirstProbability] = useState(null)
    const [secondProbability, setSecondProbability] = useState(null)
    const [calculationType, setCalculationtype] = useState(null)
    const [result, setResult] = useState(0)

 const  handleCalculate=async ()=>{
  try {
    const payload = {
      firstProbability: parseFloat(firstProbability),
      secondProbability: parseFloat(secondProbability),
      calculationType: calculationType 
    };
    const response = await axios.post('/api/GetProbabilityCalculationResult', payload );
    
    if(response.data ==-1) alert("Probability calculation failed");
      setResult(response.data); 
    } catch (err) {
      alert(err.message);
    } 
 }
const isButtonDisabled = !firstProbability || !secondProbability || !calculationType;
  return (
    <>
    <Row>
      <Col>
        <div className='container'>     
        <div className='headerClass'>
          <header>
            <h2>Probability Calculator</h2>
          </header>
        </div>
        <hr/>
        
        <Input input={'first'} getNumber={setFirstProbability}/>
        <Input input={'second'} getNumber={setSecondProbability}/>
        <Select getCalculationType={setCalculationtype}></Select>
          
        <div style={{textAlign:'center',paddingTop:'10px'}}>
          <Button onClick={handleCalculate} disabled={isButtonDisabled}>Calculate</Button></div>
        </div>
    </Col>
    <Col style={{textAlign:"center"}}> 
      <div style={{width:"400px", paddingLeft:"50px", paddingTop:"50px"}}> 
        <span style={{fontSize:"20px"}} >Result</span>
        <div className='result'>
          <h2>{result}</h2>
        </div>
      </div>
    </Col>
  </Row>

  </>
  )
}

export default App
