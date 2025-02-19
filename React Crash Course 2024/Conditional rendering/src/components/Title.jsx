import React from 'react'

const Title = (isConditional) => {
  return (
    <div>
      { isConditional ? 'Is conditional' : 'Is not conditional'}
    </div>
  )
}

export default Title
