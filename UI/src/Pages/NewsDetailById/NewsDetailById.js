import React, { useContext, useEffect, useState } from 'react'
import { useParams } from 'react-router-dom';
import NewsDetail from '../../Components/NewsDetail/NewsDetail'
import TokenContext from '../../Contexts/TokenContext/TokenContext';

function NewsDetailById() {
  const tkn = useContext(TokenContext);
  const token = `Bearer ${tkn.token}`
  const {id} = useParams();

  const [news, setNews] = useState({newsHeader:"",newsContext:"",photoUrl:""});
    useEffect(() => {
        fetch(`http://localhost:5277/api/News/GetById?newsId=${id}`, {
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
      <NewsDetail news={news}></NewsDetail>
    </div>
  )
}

export default NewsDetailById