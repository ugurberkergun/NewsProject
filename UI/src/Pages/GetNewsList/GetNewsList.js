import React, { useEffect, useState } from 'react'
import NewsCard from '../../Components/NewsCard/NewsCard'

function GetNewsList({ token }) {
    const [news, setNews] = useState([]);
    useEffect(() => {
        fetch('http://localhost:5277/api/News/GetList', {
            method: 'GET',
            headers: {
                'Content-Type': 'application/json',
                "Authorization": token
            }
        })
            .then(data => data.json())
            .then(allNews => setNews(allNews))
            .catch((e) => console.log(e))
    }, [])



    
    return (
        <div>
            
            <NewsCard news={news} setNews={setNews}></NewsCard>
        </div>
    )
}

export default GetNewsList