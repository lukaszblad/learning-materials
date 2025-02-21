import {useEffect, useState, createContext} from "react"

export interface User {
  name: string
  age: number
}

interface UserContextType {
  users: User[] | null
  addUser: (user: User) => void
  updateUser: (id: string) => void
  deleteUser: (id: string) => void
}

const contextInitialValues = {
  users: null,
  addUser: () => null,
  updateUser: () => null,
  deleteUser: () => null
}

export const UserContext = createContext<UserContextType>(contextInitialValues)

interface Props {
  children: React.ReactNode
}

export const UserProvider = (props: Props) => {

  const [users, setUsers] = useState<User[] | null>(null)

  useEffect(() => {
    setUsers([{name: "John", age: 34}])
  }, [])

  const addUser = (user: User) => null
  const updateUser = (id: string) => null
  const deleteUser = (id: string) => null

  return ( 
    <UserContext.Provider value={{users, addUser, updateUser, deleteUser}}>
      {props.children}
    </UserContext.Provider>
  )
}
