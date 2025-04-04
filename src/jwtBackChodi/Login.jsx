import React, { useState } from 'react';  
import CryptoJS from "crypto-js";

const Login = () => {  
    const secretKey = "ancd";
 

    const [name, setName] = useState('');  
    const [password, setPassword] = useState('');  

    const encryptPassword = (password) => {
        return CryptoJS.AES.encrypt(password, secretKey).toString();
    };

    const encryptName = (name) => {
        return CryptoJS.AES.encrypt(name, secretKey).toString();
    };

    const handleClickl = async() => {  
        
        const encryptedPassword = encryptPassword(password);
        const encryptedName=encryptName(name);


        console.log(encryptedPassword);

        console.log(encryptedName   );

        const response = await fetch("http://localhost:5273/login", {
            method: "POST", 
            headers: { "Content-Type": "application/json" },
            body: JSON.stringify({ uname:encryptedName, pass: encryptedPassword }),
        });

        const data = await response.json();
        console.log ("data="+data);


    };       

    return (  
        <div>  
            <input  
                type='text'  
                placeholder='Enter name'  
                onChange={(e) => setName(e.target.value)}  
                value={name}  
            />
              
            <input  
                type='password'  
                placeholder='Enter password'  
                onChange={(e) => setPassword(e.target.value)}  
                value={password}  
            />  
            <button onClick={handleClickl}>Submit</button>  
        </div>  
    );  
};  

export default Login;  