import React, { useEffect, useState } from 'react'
import { Form, Row, Col, FormGroup, Label, Input, Button, Modal, Alert } from "reactstrap"
import AlertInfo from '../Alerts/Alert';
import DangerAlert from '../Alerts/DangerAlert';


function RegisterForm() {
    const [form, setForm] = useState({ firstname: "", lastname: "",email:"",password:"" });
    const [success,setSuccess] = useState(false);
    const [message,setMessage] = useState("İşlem Başarılı");
    const onChangeInput = (e) => {
        setForm({ ...form, [e.target.name]: e.target.value });
    }
    const onSubmit = async () => {
        await fetch('http://localhost:5277/api/Auth/Register', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify(form),
        })
            .then((response) => response.json())
            .then((data) => setSuccess(true))
            .catch((error) => { setMessage("Hatalı İşlem");setSuccess(false)
            })
            setForm({ firstname: "", lastname: "",email:"",password:"" })
            

    }
    
    return (
        
        <Form className='p-4'>
            { success && 
            
                <AlertInfo alertMessage={message}></AlertInfo>
            }
            <Row className='mt-4'>
                <Col md={2}>
                    <Label for="Name">
                        Ad
                    </Label>
                </Col>
                <Col>
                    <Input
                        id="Name"
                        name="firstname"
                        placeholder="Lütfen Adınızı Giriniz"
                        type="text"
                        onChange={onChangeInput}
                        value={form.firstname}
                    />
                </Col>
            </Row>
            <Row className='mt-4'>
                <Col md={2}>
                    <Label for="lastname">
                        Soyad
                    </Label>
                </Col>
                <Col>
                    <Input
                        id="Surname"
                        name="lastname"
                        placeholder="Lütfen Soyadınızı Giriniz"
                        type="text"
                        onChange={onChangeInput}
                        value={form.lastname}
                    />
                </Col>
            </Row>
            <Row className='mt-4'>
                <Col md={2}>
                    <Label for="Email">
                        Email
                    </Label>
                </Col>
                <Col>
                    <Input
                        id="Email"
                        name="email"
                        placeholder="Lütfen Email Adresinizi Giriniz"
                        type="email"
                        onChange={onChangeInput}
                        value={form.email}
                    />
                </Col>
            </Row>
            <Row className='mt-4'>
                <Col md={2}>
                    <Label for="Password">
                        Şifre
                    </Label>
                </Col>
                <Col>
                    <Input
                        id="Password"
                        name="password"
                        placeholder="Lütfen Şifrenizi Oluşturunuz"
                        type="password"
                        onChange={onChangeInput}
                        value={form.password}
                    />
                </Col>
            </Row>

            <Button onClick={onSubmit} className='mt-4'>
                Kayıt Ol
            </Button>
        </Form>
    )
}

export default RegisterForm