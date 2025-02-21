import User from "./User"
import { UserProvider } from "./UserContextProvider"

const App = () => {
  return (
    <UserProvider>
      <User name={"John"} age={34} />
    </UserProvider>
  )
}

export default App
