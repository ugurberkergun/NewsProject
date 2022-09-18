import { Children, createContext, useEffect, useState } from "react";

const TokenContext = createContext();

export const TokenProvider=({ children}) => {
    const [token,setToken] = useState("");
    const values = {
        token,
        setToken
    };

    return <TokenContext.Provider value={values}>{children}</TokenContext.Provider>
} 

export default TokenContext;