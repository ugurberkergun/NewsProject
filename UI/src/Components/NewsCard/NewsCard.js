import React, { useContext, useEffect, useState } from 'react'
import { Link, Route, Router, Routes, NavLink, useParams } from 'react-router-dom';
import { Card, CardBody, CardImg, CardFooter, CardHeader, CardText, CardTitle, CardSubtitle, Button, Row, Nav, NavItem } from "reactstrap"
import TokenContext from '../../Contexts/TokenContext/TokenContext';
import UpdateNewsForm from '../Forms/UpdateNewsForm';
import NewsDetail from '../NewsDetail/NewsDetail';
import "./NewsCard.css";
function NewsCard({ news, setNews }) {
    const tkn = useContext(TokenContext);
    const token = `Bearer ${tkn.token}`
    const [deletedNews, setDeletedNews] = useState({
        id: "",
        newsHeader: "",
        newsContext: "",
        newsCategoryId: 0,
        newsById: "",
        photoUrl: ""
    });
    const deleteNews = async (id) => {
        await fetch(`http://localhost:5277/api/News/GetById?newsId=${id}`, {
            method: 'GET',
            headers: {
                'Content-Type': 'application/json',
                "Authorization": token
            }
        })
            .then(data => data.json())
            .then(newsById => setDeletedNews({
                id: newsById.id,
                newsHeader: newsById.newsHeader,
                newsContext: newsById.newsContext,
                newsCategoryId: newsById.newsCategoryId,
                photoUrl: newsById.photoUrl,
            }))
            .catch((e) => console.log(e))
    }
    useEffect(() => {
        if (deletedNews.id !== "") {
            fetch('http://localhost:5277/api/News/Delete', {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json',
                    "Authorization": token
                },
                body: JSON.stringify(deletedNews),
            })
                .then((response) => response.json())
                .then((data) => data)
                .catch((error) => {
                    console.error('Error:', error);
                });
        }
    }, [deletedNews])
    // console.log(setNews);

    // const [filtered,setFiltered] = useState([...news]);

    // const [searchText, setSearchText] = useState("");

    // const onChangeSearch = (event) => {
    //     setSearchText(event.target.value);
    // }
    // // console.log(typeof searchText);
    // useEffect(() => {
    //     if (searchText === "") {
    //         console.log(filtered);
    //     }
    //     else{
    //         setFiltered(filtered.filter(nw => nw.newsHeader.toLowerCase().includes(searchText)));

    //     }
    //         // console.log(filtered.filter(nw => nw.newsHeader.toLowerCase().includes(searchText)));
    //         // setNews(filtered);
    // }, [searchText])
    return (
        <div style={{ display: "flex", justifyContent: "center", gap: "5%" }} className="row">
            {
                news.map(news => (
                    <Card key={news.id}
                        style={{
                            width: '18rem',
                            flex: "none"
                        }}
                        className='mt-5 col-4'
                    >
                        <img
                            alt="Sample"
                            src={news.photoUrl}
                            className="mt-1"
                        />
                        <CardBody>
                            <CardTitle tag="h5">
                                {news.newsHeader}
                            </CardTitle>
                            <CardText>{news.newsContext.length <= 40 ? news.newsContext : news.newsContext.slice(0, 20)}
                                <NavLink to={`/home/newsdetail/${news.id}`}>...haberin devamı için tıklayın</NavLink>
                            </CardText>
                        </CardBody>
                        <CardFooter>
                            <Nav>

                                <NavItem>

                                    <NavLink className="change-btn buton" to={`/home/UpdateNews/${news.id}`}>Güncelle</NavLink>
                                    <NavLink className="del-btn buton" onClick={() => deleteNews(news.id)}>Sil</NavLink>
                                </NavItem>
                            </Nav>
                        </CardFooter>
                    </Card>
                ))
            }
        </div>
    )
}

export default NewsCard