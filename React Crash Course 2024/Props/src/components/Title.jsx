import React from 'react'

function Title({title = 'default prop', subtitle}) {
  return (
    <div>
      <h1>{ title }</h1>
      <h2>{ subtitle }</h2>
    </div>
  )
}

export default Title
