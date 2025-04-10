import React, { useState } from 'react'
import Tabs from './Tabs'


const Compo1 = () => {
    const [currIdx,setCurrIdx]=useState(1);

    const handleChange=(newIdx)=>{
        setCurrIdx(newIdx)
    }
  return (
    <div>
      <Tabs currTab={currIdx} onChange={handleChange}>
        <Tabs.HeadContainer>
           <Tabs.Item label="tab1" index={0}></Tabs.Item>
           <Tabs.Item label="tab2" index={1}></Tabs.Item>
           <Tabs.Item label="tab3" index={2}></Tabs.Item>
        </Tabs.HeadContainer>

        <Tabs.ContentContainer>
            <Tabs.ContentItem index={0}> content 1</Tabs.ContentItem>
            <Tabs.ContentItem index={1}> content 2</Tabs.ContentItem> 
            <Tabs.ContentItem index={2}> content 3</Tabs.ContentItem>
        </Tabs.ContentContainer>
      </Tabs>
    </div>
  )
}

export default Compo1
