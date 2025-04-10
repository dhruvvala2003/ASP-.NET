import React from 'react'
import Markdown from 'react-markdown'

const ReactMd = () => {

    const markdownText = '## Hi, *Pluto*!';



  return (
    <section>
    <Markdown>{markdownText}</Markdown>
    </section>

  )
}

export default ReactMd
