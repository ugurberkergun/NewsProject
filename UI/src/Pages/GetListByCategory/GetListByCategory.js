import React, { useContext, useEffect, useState } from 'react'
import { useParams } from 'react-router-dom'
import NewsCard from '../../Components/NewsCard/NewsCard';
import TokenContext from '../../Contexts/TokenContext/TokenContext';

function GetListByCategory() {
  const {id} = useParams();
  const [news, setNews] = useState([]);
  const tkn = useContext(TokenContext);
  const token = `Bearer ${tkn.token}`
    useEffect(() => {
        fetch(`http://localhost:5277/api/News/GetListByCategory?categoryId=${id}`, {
            method: 'GET',
            headers: {
                'Content-Type': 'application/json',
                "Authorization": token
            }
        })
            .then(data => data.json())
            .then(allNews => setNews(allNews))
            .catch((e) => console.log(e))
    }, [news])



    
    return (
        <div>
            
            <NewsCard news={news} setNews={setNews}></NewsCard>
        </div>
    )
}

export default GetListByCategory


