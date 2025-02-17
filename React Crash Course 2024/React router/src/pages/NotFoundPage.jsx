import { Link } from "react-router-dom"

const NotFoundPage = () => {
  return (
    <div>
      <h1>404 not found</h1>
      <Link to='/'>home</Link>
    </div>
  )
}

export default NotFoundPage
