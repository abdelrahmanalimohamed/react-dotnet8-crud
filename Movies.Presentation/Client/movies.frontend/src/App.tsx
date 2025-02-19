
import './App.css'
import { BrowserRouter, Routes, Route } from "react-router-dom";
import MovieTable from './components/movies/MovieTable'

function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<MovieTable />} />
      </Routes>
    </BrowserRouter>
  );
}

export default App
