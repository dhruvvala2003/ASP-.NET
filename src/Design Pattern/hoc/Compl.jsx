import React from 'react'
import HocParentCompo from './HocParentCompo'

const Compl = (props) => {
  return (
    <div>
      Compl & updated values is : {props.msg}

    </div>
  )
}

export default HocParentCompo(Compl);

