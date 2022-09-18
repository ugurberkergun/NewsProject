import logo from './logo.svg';
import './App.css';
import { Container, Navbar, Row } from "reactstrap";
import Auth from './Pages/Authentication/Auth';
import Main from "./Pages/Main/Main"
import {
  BrowserRouter as Router,
  Switch,
  Route,
  Redirect,
  Routes,
} from "react-router-dom";
import { useEffect, useState } from 'react';
import { TokenProvider } from './Contexts/TokenContext/TokenContext';

function App() {
  return (
    <div className="App">
      
      <Router>
      <TokenProvider>
        <div>
          <Routes>
            <Route path='/home/*' element={<Main />}></Route>

          </Routes>
        </div>

        <Container>
          <Row className='mt-5 row'>
            <Routes>
              
              <Route path='/' element={<Auth/>}></Route>
              
            </Routes>
          </Row>
        </Container>

</TokenProvider>
      </Router>
    </div>
  );
}

export default App;
