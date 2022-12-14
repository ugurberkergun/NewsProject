import React, { useContext, useState } from 'react'
import { Form, Row, Col, FormGroup, Label, Input, Button, Modal, Toast, ToastHeader, ToastBody } from "reactstrap"
import TokenContext from '../../Contexts/TokenContext/TokenContext';
import AlertInfo from '../Alerts/Alert';



function AddNewsForm() {
    const [form, setForm] = useState({ newsHeader: "", newsContext: "", newsCategoryId: 0, photoUrl: "" });
    const [message, setMessage] = useState({ message: "", status: false });
    const onChangeInput = (e) => {
        setForm({
            ...form, [e.target.name]: e.target.value
        });
    } 
    const tkn = useContext(TokenContext);
    const token = `Bearer ${tkn.token}`
    const onSubmitForm = async () => {
        await fetch('http://localhost:5277/api/News/add', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
                "Authorization": token
            },
            body: JSON.stringify(form),
        })
            .then((response) => response.json())
            .then((data) => { setMessage({ message: data.message, status: data.success }) })
            .catch((error) => {
                console.error('Error:', error);
            });
        setForm({
            newsHeader: "", newsContext: "", newsCategoryId: 0, photoUrl: ""
        })

    }
    return (
        <>
            <div>
                {message.status === true &&
                    <AlertInfo alertMessage={message.message} />
                }
            </div>
            <div style={{ display: "flex", justifyContent: "center" }}>

                <Form className='mt-5'>
                    <Row>
                        <Col md={2}>
                            <Label for="newsHeaderText">
                                <h5>Haber Başlığı:</h5>
                            </Label>
                        </Col>
                        <Col >
                            <Input
                                id="newsHeaderText"
                                name="newsHeader"
                                type="text"
                                value={form.newsHeader} onChange={onChangeInput}
                                style={{ width: "30rem" }}
                            />
                        </Col>
                    </Row>
                    <Row className='mt-5'>
                        <Col md={2}>
                            <Label for="newsContextText">
                                <h5>Haber İçeriği:</h5>
                            </Label>
                        </Col>
                        <Col>
                            <Input
                                id="newsContextText"
                                name="newsContext"
                                type="textarea"
                                value={form.newsContext}
                                onChange={onChangeInput}
                                style={{ width: "30rem", height: "20rem" }}
                            />
                        </Col>
                    </Row>
                    <Row>
                        <Col md={2}>
                            <Label for="newsPhoto">
                                <h5>Haber Fotoğrafı<br></br>(URL)</h5>
                            </Label>
                        </Col>
                        <Col >
                            <Input
                                id="newsPhoto"
                                name="photoUrl"
                                type="text"
                                value={form.photoUrl} onChange={onChangeInput}
                                style={{ width: "30rem" }}
                            />
                        </Col>
                    </Row>
                    <Row className='mt-5'>
                        <Col md={1}>
                            <Label for="newsCategoryText">
                                <h5>Haber Kategori:</h5>
                            </Label>
                        </Col>
                        <Col>
                            <select style={{ width: "30rem", height: "3rem", padding: "0.5rem" }} name="newsCategoryId" onChange={onChangeInput}>
                                <option value="#" selected>Seçiniz</option>
                                <option value="1">Ekonomi</option>
                                <option value="2">Spor</option>
                                <option value="3">Magazin</option>
                                <option value="4">Turizm</option>
                                <option value="5">Dünya</option>
                            </select>
                        </Col>
                    </Row>
                    
                    <Button className='mt-4' onClick={onSubmitForm}>
                        Haber Oluştur
                    </Button>

                </Form>


            </div>

        </>
    )
}

export default AddNewsForm