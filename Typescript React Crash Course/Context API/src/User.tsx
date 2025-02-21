import { useContext } from "react"
import { UserContext } from './UserContextProvider'

interface Props {
  name: string
  age: number
}

const User = (props: Props) => {

  const {} = useContext(UserContext)

  return (
    <div>
      <p>Name: {props.name}</p>
      <p>Age: {props.age}</p>
    </div>
  )
}

export default User
