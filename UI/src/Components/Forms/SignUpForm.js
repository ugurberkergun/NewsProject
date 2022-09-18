import React, { useContext, useState } from 'react'
import { Link, Navigate } from 'react-router-dom'
import { Form, Row, Col, FormGroup, Label, Input, Button, Modal, NavLink } from "reactstrap"
import ModalExample from '../../Components/Modal'
import Main from '../../Pages/Main/Main'
import { Route, BrowserRouter as Router, Routes } from "react-router-dom"
import Auth from '../../Pages/Authentication/Auth'
import { Redirect } from 'react-router-dom'
import TokenContext from '../../Contexts/TokenContext/TokenContext'
import AuthContext from '../../Contexts/AuthContext/AuthContext'
import DangerAlert from '../Alerts/DangerAlert'

function SignUpForm() {
    const tkn = useContext(TokenContext);
    const auth = useContext(AuthContext);
    const onSubmit = async () => {
        await fetch('http://localhost:5277/api/auth/login', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify(auth.form),
        })
            .then((response) => response.json())
            .then((data) => { tkn.setToken(data.token)})
            .catch((error) => { tkn.setToken("error");
            })
    }
    return (
        <>
            <div>
                <h1>Giriş Yap</h1>
                <Form className='mt-5'>
                {tkn.token === "error" && 
                    <DangerAlert alertMessage={"Hatalı Kullanıcı Girişi"}></DangerAlert>
                }
                    <Row>
                        <Col md={2}>
                            <Label for="exampleEmail">
                                <h5>Email:</h5>
                            </Label>
                        </Col>
                        <Col>
                            <Input
                                id="exampleEmail"
                                name="email"
                                placeholder="example@example.com"
                                type="email"
                                onChange={auth.onChangeInput}
                            />
                        </Col>
                    </Row>
                    <Row className='mt-5'>
                        <Col md={2}>
                            <Label for="examplePassword">
                                <h5>Şifre:</h5>
                            </Label>
                        </Col>
                        <Col>
                            <Input
                                id="examplePassword"
                                name="password"
                                placeholder="Lütfen Şifrenizi Giriniz"
                                type="password"
                                onChange={auth.onChangeInput}
                            />
                        </Col>
                    </Row>
                    <Link onClick={onSubmit} to={tkn.token === "error" ? "/" : "/home"} className='btn btn-primary mt-4'>Giriş Yap</Link>
                    <Row className='mt-4'>
                        <Col md={4}>Henüz Kayıt Olmadınız mı?</Col>
                        <Col md={4}><ModalExample></ModalExample></Col>
                    </Row>
                </Form>
                
            </div>
        </>
    )
}

export default SignUpForm