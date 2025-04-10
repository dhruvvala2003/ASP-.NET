
import React from 'react'
import Input from './Input';


const Props_Passing = () => {

    
    const HandleBoldInpuText=(values)=>{
           return( <h2><b>{values}</b></h2>);

    }

    const HandleInputText=(values)=>{
            return (<h3>{values}</h3>);
            
    }

  return (
    <div>
        
        <Input renderTextBelow={HandleBoldInpuText}/>


        <Input renderTextBelow={HandleInputText}/>

    </div>
  )
}

export default Props_Passing
