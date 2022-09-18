import React, { useState } from 'react';
import {
    Collapse,
    Navbar,
    NavbarToggler,
    NavbarBrand,
    Nav,
    NavItem,
} from 'reactstrap';
import { NavLink, Route, BrowserRouter as Router, Routes, useMatch } from "react-router-dom"
import "./Navbar.css"

function NewsNavbar(props) {
    return (
            <div>
                <Navbar
                    color="dark"
                    dark
                    style={{height:"6rem"}}
                >
                    <NavbarBrand href="/home">
                    <img
                            alt="logo"
                            src="https://35inch.com/_next/image?url=%2F_next%2Fstatic%2Fmedia%2Flogo_white.fc4d54d0.png&w=256&q=75"
                            style={{
                                height: 30,
                                width: 150
                            }}
                        />
                        News Project
                    </NavbarBrand>
                    <Nav>
                        <NavItem>
                            <NavLink className="nav-btn" to="/home">Ana Sayfa</NavLink>
                            <NavLink className="nav-btn" to="/home/AddNews">Yeni Haber</NavLink>
                            <NavLink className="nav-btn" to="/">Çıkış</NavLink>
                        </NavItem>
                    </Nav>

                </Navbar>
                
                
            </div>
    );
}

export default NewsNavbar;