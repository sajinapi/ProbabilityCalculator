import React, { useState } from "react";
import { Form,Col,Row} from "react-bootstrap"

const Select =(props)=>{
const [type, setType] = useState('')

const handleSelect=(e)=>{
    setType(e.target.value)
    props.getCalculationType(e.target.value)
}
return(
    <>
      <Form.Group as={Row} className="mb-4">
        <Form.Label column sm={5} style={{paddingLeft:"20px"}}>
            Calculation Type 
        </Form.Label>
        <Col sm={7}>
            <Form.Select 
                value={type} 
                onChange={handleSelect}
                className="selectClass" 
                style={{ cursor: 'pointer' }}
            >
                <option value="">Select an option</option>
                <option value="combined">CombinedWith: P(A)P(B)</option>
                <option value="either">Either: P(A)+P(B)-P(A)P(B)</option>
            </Form.Select>
        </Col>
      </Form.Group>
    </>
);
}

export default Select