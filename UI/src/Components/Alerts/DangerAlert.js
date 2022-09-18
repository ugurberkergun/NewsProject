import React, { useState } from 'react'
import { Toast, ToastBody, ToastHeader, Alert } from 'reactstrap'

function DangerAlert({ alertMessage }) {
    const [visible, setVisible] = useState(true);

    const onDismiss = () => setVisible(false)
    return (
        <div>
            <Alert color="danger" isOpen={visible} toggle={onDismiss}>
                <h4>Hatalı İşlem</h4>
                <p>{alertMessage}</p>
            </Alert>

        </div>
    )
}

export default DangerAlert