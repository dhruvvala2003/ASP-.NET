import React, { useState } from 'react'

const FormSubmition = () => {
    const [x,setX]=useState({});

        const tmp={
            name1:"ef",
            pass1:"f"
        }
    const handleClick=(e)=>{
      

        setX(prv=>({...prv,[e.target.name]:e.target.value}));

    } 
    
    const handleClick1=()=>{
       
        const {name1,pass1}=tmp;
        alert("name:"+name1 +" pass"+pass1)
            
    } 
    

    
  return (
    <div>

    <div>
        <input type='text' name='uname' value={x.uname || " "} onChange={handleClick} placeholder='enter name:'/>
        <input type='password' name='upassword' value={x.upassword || " "} onChange={handleClick}  placeholder='enter pasword '/>

        {/* <textarea typeof='text'  name='textbox' /> */}

        <button onClick={(e)=>handleClick(e)}>click me </button>
        <button onClick={handleClick1}> me </button>
    </div>
       
    </div>
  )
}

export default FormSubmition
