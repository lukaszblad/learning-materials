import React, { useState } from "react"

interface Person {
  name: string
  age: number
}

const Person = (props: Person) => {

  const [isShowInfo, setShowInfo] = useState<boolean | null>(true)
  const toggleInfo = () => {
    setShowInfo((prev) => !prev)
  }

  const [personBio, setPersonBio] = useState<string | null>(null)

  const handleChange = (event: React.ChangeEvent<HTMLInputElement>) => {
    setPersonBio(event.target.value)
  }

  // const handleSubmit = (event: React.FormEvent<HTMLFormElement>) => {
  //   event.preventDefault()
  // }

  return (
    <div>
      {isShowInfo &&
        <>
          <p>Name: {props.name}</p>
          <p>Age: {props.age}</p>
        </>
      }

      <button onClick={toggleInfo}>Toogle Info</button>

      {/* Form events */}
      <p>
        {props.name} Bio: {!personBio ? "No Bio avilable" : personBio}
      </p>
      <input onChange={handleChange} />
    </div>
  )
}

export default Person
