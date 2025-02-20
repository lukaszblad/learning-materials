
enum LoginError {
  Unauthorized = "unauthorized",
  NoUser = "nouser",
}

const printErrorMessage = (error: string) => {
  if (error === LoginError.Unauthorized) {
    console.log("User not authorized")
  } else if (error === LoginError.NoUser) {
    console.log("user doesn't exist")
  } else {
    console.log(error)
  }
}
