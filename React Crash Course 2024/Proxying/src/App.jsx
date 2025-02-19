import { useEffect, useState } from 'react'

const App = () => {
  const[jobs, setJobs] = useState([])

  useEffect( () => {
    const fetchJobs = async () => {
      try {
        const res = await fetch('/api/jobs')
        const data = await res.json()
        setJobs(data)
        console.log(data)
      }
      catch (error) {
        console.log("Erro fetching data", error)
      }
    }

    fetchJobs()
  }, [])

  return (
    <div>
      <div>
        {jobs.map((job) => (
          <div key={ job.id }>
            <p>{job.title} </p>
          </div>
        ))}
      </div>
    </div>
  )
}

export default App

