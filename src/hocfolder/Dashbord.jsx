import React from "react";  
import WithAuth from "./WthAuth";
import WithDarkMode from "./WithDarkMode";
 

const Dashbord = () => {  
    return (  
        <div>  
            Dashboard ContFAGGDDGDFGSDFEent  
        </div>  
    );  
}  

const AuthDash = WithDarkMode( WithAuth(Dashbord));  
export default AuthDash;  