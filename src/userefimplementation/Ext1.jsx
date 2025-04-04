import React, {  useRef, useState } from 'react'

const Ext1 = () => {

const [isPlaying,setIsPlaying]=useState(false);
const ref=useRef(null);

const handleClick=()=>{

        if(isPlaying)
        {
            setIsPlaying(false);
                ref.current.pause();

        }
        else{
            setIsPlaying(true);
            ref.current.play();
        }
}

  return (
    <div>
    
        <button onClick={handleClick}>{isPlaying?'pause':'play'}</button>
    
        <video
        width="250"
        ref={ref}
        onPlay={() => setIsPlaying(true)}
        onPause={() => setIsPlaying(false)}
      >
        <source
          src="https://interactive-examples.mdn.mozilla.net/media/cc0-videos/flower.mp4"
          type="video/mp4"
        />
      </video>


      
    </div>
  )
}

export default Ext1
