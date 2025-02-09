import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'
import MovieTableItem from './components/movies/MovieTable'

function App() {
  const [count, setCount] = useState(0)

  return (
    <>
      <MovieTableItem></MovieTableItem>
    </>
  )
}

export default App
