import React from "react";
import { Link } from "react-router-dom";
import logo from "./logo.svg";

const Navbar = () => {
    return (
        <nav className="navbar navbar-dark bg-dark">
            <div className="navbar-brand" href="#">
                <Link to={`/`}>
                    <img
                        src={logo}
                        style={{ height: "5vmin" }}
                        className="App-logo"
                        alt="logo"
                    />
                </Link>
            </div>
        </nav>
    );
};

export default Navbar;
