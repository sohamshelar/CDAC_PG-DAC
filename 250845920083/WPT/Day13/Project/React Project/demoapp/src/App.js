import logo from './logo.svg';
import './App.css';


import { BrowserRouter,Route,Routes,Link,NavLink,useNavigate } from 'react-router-dom';
import Home from './HomePage';
import About from './About_us';
import Contact_Us from './ContactUS';



const App1 = () => {
    return (
        <BrowserRouter>

            {/* Navigation Bar */}
            <nav
                style={{
                    backgroundColor: "blue",
                    padding: "10px",
                    display: "flex",
                    justifyContent: "center",
                }}
            >
                <ul
                    style={{
                        listStyle: "none",
                        display: "flex",
                        gap: "20px",
                        padding: "0",
                        margin: "0",
                    }}
                >
                    <li>
                        <NavLink to="/" style={linkStyle}>
                            Home
                        </NavLink>
                    </li>
                    <li>
                        <Link to="/About" style={linkStyle}>
                            About Us
                        </Link>
                    </li>
                    <li>
                        <Link to="/Contact_Us" style={linkStyle}>
                            Contact Us
                        </Link>
                    </li>
                    <li>
                        <Link to="/login" style={linkStyle}>
                            Login
                        </Link>
                    </li>
                </ul>
            </nav>

            {/* Page Content */}

            <div
                style={{ display: "flex", justifyContent: "center", padding: "20px" }}
            >



                <Routes>
                    <Route path="/" element={<Home />} />
                    <Route path="/About" element={<About />} />
                    <Route path="/Contact_Us" element={<Contact_Us />} />
                    <Route path="/Login" element={<LoginDemo />} />
                </Routes>
            </div>

        </BrowserRouter>
    );
};

// Style for navigation links
const linkStyle = {
    textDecoration: "none",
    color: "white",
    fontSize: "18px",
    fontWeight: "bold",
};

export default App1;

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          Edit <code>src/App.js</code> and save to reload.
        </p>
        <h1>Hello</h1>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React
        </a>
      </header>
    </div>
  );
}


