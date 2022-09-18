import React, { useState } from 'react';
import { Route, Routes, NavLink } from 'react-router-dom';
import {
  Nav,
  NavItem,
  NavLink as NavListİtem
} from 'reactstrap';
import "./CategoryNav.css"

function CategoryNav({ newsCategory }) {
  return (
    <>
      <Nav tabs>
        {
          newsCategory.map((e) => (
            <NavItem key={e.id}>
              <NavListİtem>
                <NavLink className="catNav-btn" to={`/home/getNewsByCategory/${e.id}`}>{e.categoryName}</NavLink>
              </NavListİtem>
            </NavItem>
          ))
        }
      </Nav>
    </>
  );
}

export default CategoryNav;