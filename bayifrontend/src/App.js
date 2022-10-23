import './App.css';
import { Route, BrowserRouter, Routes } from "react-router-dom";
import Login from './Pages/Login';
import Home from './Pages/Home';
import Layout from "./Layout/index";
import Admin from './Pages/Admin';
import CreateBayi from './Pages/CreateBayi';
import CreateAltBayi from './Pages/CreateAltBayi';
function App() {
  return (
    <div>
      <BrowserRouter>
      <Routes>
        <Route path='/' element={<Layout/>}>
          <Route index element = {<Home/>}/>
          <Route path='Login' element = {<Login/>} />
          <Route path='Admin' element = {<Admin/>} />
          <Route path='CreateBayi' element = {<CreateBayi/>} />
          <Route path='CreateAltBayi' element = {<CreateAltBayi/>} />
        </Route>
      </Routes>
      </BrowserRouter>
    </div>
  );
}

export default App;
