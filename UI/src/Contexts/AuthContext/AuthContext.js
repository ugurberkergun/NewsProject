import { Children, createContext, useState } from "react";

const AuthContext = createContext();

export const AuthProvider=({ children}) => {
    const [form, setForm] = useState({ email: "", password: "" });
    const onChangeInput = (e) => {
        setForm({ ...form, [e.target.name]: e.target.value });
    }
    const values = {
        form,
        setForm,
        onChangeInput
    };

    return <AuthContext.Provider value={values}>{children}</AuthContext.Provider>
} 

export default AuthContext;