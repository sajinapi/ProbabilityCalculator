import { useState } from 'react';
import { Form,Col,Row} from "react-bootstrap"
const Input =(props)=>{
const [number, setNumber] = useState(null);
const [isValid, setIsValid] = useState(false);

const handleNumberChange=(e)=>{
    setNumber(e.target.value)
    const inputValue = e.target.value;
     if (inputValue === "" || inputValue==null) {
        setIsValid(false); 
        return;
     }
    const num = parseFloat(inputValue);
    if(!isNaN(Number(inputValue))&&!isNaN(num) && num >= 0 && num <= 1){
         props.getNumber(inputValue)
         setIsValid(false);
    } 
    else {
        setIsValid(true)
    }
}
return(
    <>
    <Form.Group as={Row} className="mb-4">
        <Form.Label column sm={5} style={{paddingLeft:"20px"}}>
        Enter the {props.input} Probability
        </Form.Label>
        <Col sm={7}>
            <Form.Control
            type="text" 
            className='inputClass'
            value={number} 
            isInvalid={isValid}
            onChange={handleNumberChange}
            />
            <Form.Control.Feedback type="invalid">
                Must be a number between 0 and 1.
            </Form.Control.Feedback>
        </Col>
    </Form.Group>
</>
);
}

export default Input