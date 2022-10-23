import axios from "axios";
import React, { useState } from "react";
import Button from "react-bootstrap/esm/Button";
import { Link } from "react-router-dom";
import { useNavigate } from "react-router-dom";

function CreateBayi() {
  const navigate = useNavigate();
  const [anaBayiData, setAnaBayiData] = useState({
    anaBayiAdi: "",
    mail: "",
    telefon: 0,
    il: "",
    ilce: "",
    anaBayiId: 0,
  });
  const postAnaBayi = () => {
    axios
      .post("https://localhost:7056/api/AnaBayi", {
        anaBayiAdi: anaBayiData.anaBayiAdi,
        mail: anaBayiData.mail,
        telefon: anaBayiData.telefon,
        il: anaBayiData.il,
        ilce: anaBayiData.ilce,
      })
      .then((response) => {
        console.log(response);
      });
  };
  const handleChange = (e) => {
    setAnaBayiData({ ...anaBayiData, [e.target.name]: e.target.value });
    // setForm((prev) => ({ ...prev, [e.target.name]: e.target.value }));
  };
  const exit = () => {
    localStorage.clear();
    navigate("/");
  };
  return (
    <div>
      BAYİ EKLEME ALANI
      <Button variant="danger" className="cikis" onClick={exit}>Çıkış</Button>{" "}
      <Button as={Link} to={"/Admin"} className="donus" variant="outline-warning">
        Dönüş
      </Button>{" "}
      <form>
        <br />
        <br />
        <br />
        <label>
          <p>Bayi adı:</p>
          <input
            required
            type="text"
            name="anaBayiAdi"
            onChange={handleChange}
          />
          <br />
          <p>Mail:</p>
          <input required type="text" name="mail" onChange={handleChange} />
          <br />
          <p>Telefon:</p>
          <input required type="text" name="telefon" onChange={handleChange} />
          <br />
          <p>İl:</p>
          <input required type="text" name="il" onChange={handleChange} />
          <br />
          <p>İlce:</p>
          <input required type="text" name="ilce" onChange={handleChange} />
          <br />
        </label>
        <br />
        <br />
        <Button variant="success" onClick={postAnaBayi}>
          EKLE
        </Button>
      </form>
    </div>
  );
}

export default CreateBayi;
