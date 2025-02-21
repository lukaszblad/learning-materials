interface Person {
  name: string
  age: number
}

function Person(props: Person) {
  
  return (
    <>
      <p>name: {props.name}</p>
      <p>age: {props.age}</p>
    </>
  )
}

export default Person
