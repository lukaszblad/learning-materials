console.log("custom types")

interface UserInterface {
  id: number
  name: string
  age?: number // optional field
  // methods
  greet(message: string): void
}

const User: UserInterface =  {
  id: 1,
  name: "Lukasz",
  age: 22,

  greet(message) {
    console.log(message)
  }
}

User.greet("Hello")
