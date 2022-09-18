import React, { useContext, useEffect, useState } from 'react'
import { Form, Row, Col, FormGroup, Label, Input, Button, Modal } from "reactstrap"
import SignUpForm from '../../Components/Forms/SignUpForm'
import ModalExample from '../../Components/Modal'
import AuthContext, { AuthProvider } from '../../Contexts/AuthContext/AuthContext'
import TokenContext, { TokenProvider } from '../../Contexts/TokenContext/TokenContext'
import "./Auth.style.css"

function Auth() {
  const tkn = useContext(TokenContext);
  const auth = useContext(AuthContext);
  return (
      <AuthProvider>
    <div className='col-7 border rounded-4 p-5 auth'>
      <SignUpForm></SignUpForm>
    </div>
    </AuthProvider>
  )
}

export default Auth
