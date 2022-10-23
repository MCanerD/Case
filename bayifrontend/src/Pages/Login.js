import axios from "axios";
import React, { useState } from "react";
import Button from "react-bootstrap/esm/Button";
import { Link } from "react-router-dom";
import { useNavigate } from "react-router-dom";

// https://localhost:7056/api/Authenticate/login

function Login() {
  const navigate = useNavigate();
  const postDataToServer = () => {
    axios
      .post("https://localhost:7056/api/Authenticate/login", {
        bayiAdi: loginData.bayiAdi,
        password: loginData.password,
      })
      .then((response) => {
        console.log(response);
        localStorage.setItem(response.data.token, "Token");
        navigate("/Admin");
      });
  };
  
  const handleChange = (e) => {
    setLoginData({ ...loginData, [e.target.name]: e.target.value });
    // setForm((prev) => ({ ...prev, [e.target.name]: e.target.value }));
    console.log(loginData);
  };
  const [loginData, setLoginData] = useState({ bayiAdi: "", password: "" });
  return (
    <div>
      <form>
        <label>
          Kullanıcı Adı:
          <input type="text" name="bayiAdi" onChange={handleChange} />
          Şifre:
          <input type="text" name="password" onChange={handleChange} />
        </label>
        <Button variant="success" onClick={postDataToServer}>
          Giriş yap
        </Button>
      </form>
      <Button as={Link} to={"/"} variant="warning">
        Dönüş
      </Button>{" "}
    </div>
  );
}

export default Login;
