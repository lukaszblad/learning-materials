// defining number type
console.log("types")
let id: number = 5;
let company: string = 'Acme Corp.'
let isPublished: boolean = true

let ids: number[] = [1, 2, 3, 4, 5]
let x: any = "Pedro"
let xArr: any[] = ["pedro", 0, true]

                                          // return type
const concatValues = (a: number, b: number): number => {
  return a + b;
}


                    // multiple types
const printId = (id: string | number) => {
  console.log(id)
}
