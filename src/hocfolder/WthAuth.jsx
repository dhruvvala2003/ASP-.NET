import React from "react";  

//  eslint-disable-next-line no-unused-vars
const WithAuth = (Component) => {  
    const isAuthenticated = false; // Logic to determine if the user is authenticated  

    return function(props) {  
        if (isAuthenticated) {  
            return <Component     {...props}  />;  
        } else {  
            return <p>Please authenticate....{props.text11}</p>;  
        }  
    };  
};   

export default WithAuth;  