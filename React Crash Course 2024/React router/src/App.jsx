import { Route, createBrowserRouter, createRoutesFromElements, RouterProvider } from 'react-router-dom'
import HomePage from './pages/HomePage'
import ContentPage from './pages/ContentPage'
import NotFoundPage from './pages/NotFoundPage'
import MainLayout from './layouts/MainLayout'

const router = createBrowserRouter(
  createRoutesFromElements(
    <Route path='/' element={<MainLayout />}>
      <Route path='/' element={ <HomePage /> } />
      <Route path='/content' element={ <ContentPage /> } />
      <Route path='*' element={ <NotFoundPage /> } />
    </Route>
  )
)

const App = () => {
  return (
    <RouterProvider router={router} />
  )
}

export default App
