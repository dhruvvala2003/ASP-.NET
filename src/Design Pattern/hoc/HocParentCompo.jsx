import React from 'react'

const HocParentCompo = (Compl) => {
  
    return function hocParentCompo(){
        return <Compl msg="sfs"/>

    };

    // return hocParentCompo();

};

                             
export default HocParentCompo
