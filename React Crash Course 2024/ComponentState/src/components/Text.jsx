import {React, useState} from 'react'

const Text = () => {
  const [showFullText, setShowFullText] = useState(false)

  let text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Earum, porro!"

  if (!showFullText) {
    text = text.substring(0, 20) + ' ...'
  }

  return (
    <div>
      <p>{ text }</p>
      <button onClick={() => setShowFullText((prevState) => !prevState)}>
        Show {showFullText ? "Less" : "More"}
      </button>
    </div>
  )
}

export default Text
