import React, { useState } from 'react';
import { Button, Modal, ModalHeader, ModalBody, ModalFooter } from 'reactstrap';
import RegisterForm from './Forms/RegisterForm';

function ModalExample(args) {
  const [modal, setModal] = useState(false);

  const toggle = () => setModal(!modal);

  return (
    <div className='mt-2'>
      <Button color="primary" onClick={toggle}>
        Kayıt Ol
      </Button>
      <Modal isOpen={modal} toggle={toggle} {...args}>
        <ModalHeader toggle={toggle}>Kayıt Formu</ModalHeader>
        <ModalBody>
          <RegisterForm></RegisterForm>
        </ModalBody>
      </Modal>
    </div>
  );
}

export default ModalExample;