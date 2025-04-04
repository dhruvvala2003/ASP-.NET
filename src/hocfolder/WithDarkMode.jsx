import React from 'react'
//  eslint-disable-next-line no-unused-vars
const WithDarkMode = (Component) => {
 
    const style={
        color:'red'
    }
  return function (props) {
        return <div style={style}><Component {...props}/></div>
      }
  
  
}

export default WithDarkMode
