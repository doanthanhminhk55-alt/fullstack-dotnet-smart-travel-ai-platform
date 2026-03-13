import { useEffect, useState } from 'react'
import api from "./api/api";

function App() {
  const [token, setToken] = useState("");

  const login = async () => {

    const rest = await api.post("/user/auth/login");

    setToken(rest.data.token);

  };

  return (
    <div style={{ padding: 40 }}>
      <h2>Smart Travel AI Platform</h2>

      <button onClick={login}>
        Login
      </button>

      <p>Token:</p>

      <textarea
        value={token}
        rows={6}
        cols={60}
        readOnly
      />
    </div>
  )
}

export default App
