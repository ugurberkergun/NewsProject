import React, { useState, useEffect, useContext } from 'react'
import NewsNavbar from '../../Components/Navbar/Navbar';
import NewsCard from '../../Components/NewsCard/NewsCard';
import { NavLink, Route, BrowserRouter as Router, Routes } from "react-router-dom"
import {
    Collapse,
    Navbar,
    NavbarToggler,
    NavbarBrand,
    Nav,
    NavItem,
    Container,
} from 'reactstrap';
import AddNewsForm from '../../Components/Forms/AddNewsForm';
import CategoryNav from '../../Components/CategoryNav/CategoryNav';
import GetNewsList from '../GetNewsList/GetNewsList';
import AddNews from '../AddNews/AddNews';
import UpdateNewsForm from '../../Components/Forms/UpdateNewsForm';
import NewsDetailById from '../NewsDetailById/NewsDetailById';
import GetListByCategory from '../GetListByCategory/GetListByCategory';
import "./Main.css"
import TokenContext from '../../Contexts/TokenContext/TokenContext';

function Main() {
    // const [searchText, setSearchText] = useState("");
    // const onChangeSearch = (event) => {
    //     setSearchText(event.target.value);
    // }
    // useEffect(() => {
    //     if (searchText == "") {
    //         setNews(news)
    //        return;
    //     }
    //     const filtered = [...news]
    //     setNews(filtered.filter(nw => nw.newsHeader.includes(searchText)))
    // }, [searchText])

    const tkn = useContext(TokenContext);
    const token = `Bearer ${tkn.token}`


    const [newsCategory, setNewsCategory] = useState([])
    useEffect(() => {
        fetch("http://localhost:5277/api/NewsCategory/GetNewsCategoryList", {
            method: 'GET',
            headers: {
                'Content-Type': 'application/json',
                "Authorization": token
            }
        })
            .then(data => data.json())
            .then(newsCategoryName => setNewsCategory(newsCategoryName))
            .catch((e) => console.log(e))
    }, [])
    return (
        <div>
            
            <div className='main-nav'>
                <Container>
                    <NewsNavbar newsCategory={newsCategory}></NewsNavbar>
                </Container>
            </div>
            <div>
                <Container>
                    <CategoryNav newsCategory={newsCategory}></CategoryNav>
                </Container>
            </div>
            <div className='main-body'>
                
            <Routes>
                <Route render path="/*" element={<GetNewsList token={token} />}></Route>
                <Route path="/AddNews" element={<AddNews />}></Route>
                <Route path={`/UpdateNews/:id`} element={<UpdateNewsForm />}></Route>
                <Route path={`/newsdetail/:id`} element={<NewsDetailById />}></Route>
                <Route path={`/getNewsByCategory/:id`} element={<GetListByCategory />}></Route>

            </Routes>
            </div>
           
        </div>



    )
}

export default Main