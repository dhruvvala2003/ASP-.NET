import React, { createContext, useContext } from 'react'
import "./TabCss.css";

const Tabs = ({currTab,onChange,children}) => {
  const tabContext=createContext();

  return (
    <div className="tab">
   
        <tabContext.Provider value={currTab,onChange}>
        {children}
        </tabContext.Provider>
    
      
    </div>
  )
}

Tabs.HeadContainer=({children})=>{
  return <div className='HeadContainer'>{children}</div>
};

Tabs.Item=({label,index,children})=>{

  const {currTab,onChange}=useContext(createContext);

  return <div className='Item' onClick={}>{label}</div>
};


Tabs.ContentContainer=({children})=>{
  return <div className='ContentContainer'>{children}</div>
};

Tabs.ContentItem=({index,children})=>{
  return <div className='ContentItem'>{children}</div>
};




export default Tabs
