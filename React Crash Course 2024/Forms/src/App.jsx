import { useState } from 'react'

const App = () => {
  const addJob = async (newJob) => {
    const res = await fetch('/api/jobs', {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json'
      },
      body: JSON.stringify(newJob)
    })
    return
  }

  const deleteJob = async (jobID)  => {
    const res = await fetch(`/api/jobs/${id}`, {
      method: 'DELETE',
    })
  }

  const [title, setTitle] = useState('')

  const submitForm = (e) => {
    e.preventDefault()
     const newJob = {
      title 
    }

    addJob(newJob)
  }

  return (
    <div>
      <form onSubmit={submitForm}>
        <input
          type="text" value={title}
          id='title'
          name='title'
          placeholder='title'
          onChange={(e) => setTitle(e.target.value)}
        />
        <input type="submit" />
      </form>
    </div>
  )
}

export default App
