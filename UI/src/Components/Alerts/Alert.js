import React, { useState } from 'react'
import { Toast, ToastBody, ToastHeader, Alert } from 'reactstrap'

function AlertInfo({ alertMessage }) {
    const [visible, setVisible] = useState(true);

    const onDismiss = () => setVisible(false)
    return (
        <div>
            <Alert color="info" isOpen={visible} toggle={onDismiss}>
                <h4>İşlem Başarılı</h4>
                <p>{alertMessage}</p>
            </Alert>

        </div>
    )
}

export default AlertInfo