import React from 'react'
import { useParams } from 'react-router-dom';
import { Row } from 'reactstrap';

function NewsDetail({ news }) {

    return (
        <div className='mt-3 container' style={{ width: "50rem", heigth: "10rem" }}>
            <h3>{news.newsHeader}</h3>
            <hr></hr>
            <img src={news.photoUrl} alt="Haber Resmi" style={{ width: "100%", heigth: "10rem" }}></img>
            <Row>
                <div className='mt-4' style={{ width: "100%", heigth: "10rem" }}><h5>{news.newsContext}</h5></div>
            </Row>
        </div>
    )
}

export default NewsDetail