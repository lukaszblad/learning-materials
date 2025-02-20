console.log("unions and intersections")

// type union
type IDFieldType = string | number

const printID = (id: IDFieldType) => {
  console.log(id)
}

// type intersection
interface BusinessPartner {
  name: string
  creditScore: number
}

interface UserIdentity {
  id: number
  email: string
}

type Employee = BusinessPartner & UserIdentity

const signContract = (employee: Employee): void => {
  console.log("Signed by " + employee.name + " with email: " + employee.name)
}

signContract({
  name: "Pedro",
  creditScore: 800,
  id: 34,
  email: "pedro@gmail.com"
})
