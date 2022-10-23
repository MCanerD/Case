import axios from "axios";
import React, { useState } from "react";
import Button from "react-bootstrap/esm/Button";
import { Link } from "react-router-dom";
import { useNavigate } from "react-router-dom";

function CreateAltBayi() {
  const navigate = useNavigate();
  const [altBayiData, setAltBayiData] = useState({
    altBayiAdi: "",
    mail: "",
    telefon: 0,
    il: "",
    ilce: "",
    anaBayiId: 0,
    
  });
  const handleChange = (e) => {
    setAltBayiData({ ...altBayiData, [e.target.name]: e.target.value });
    // setForm((prev) => ({ ...prev, [e.target.name]: e.target.value }));
  };
  const postAltBayi = () => {
    axios
      .post("https://localhost:7056/api/AltBayi", {
        altBayiAdi: altBayiData.altBayiAdi,
        mail: altBayiData.mail,
        telefon: altBayiData.telefon,
        il: altBayiData.il,
        ilce: altBayiData.ilce,
        anaBayiId: altBayiData.anaBayiId,

      }).then((response)=>{
        console.log(response)
      })
  };
  const exit = () => {
    localStorage.clear();
    navigate("/");
  };
  return (
    <div>
      ALT BAYİ EKLEME ALANI.
      <Button variant="danger" className="cikis" onClick={exit}>Çıkış</Button>
      <Button as={Link} to={"/Admin"} className="donus" variant="outline-warning">
        Dönüş
      </Button>{" "}
      <form>
        <br/>
        <br/>
        <br/>
        <label>
          <p>
          Alt bayi adı:
          </p>
          <input required type="text" name="altBayiAdi" onChange={handleChange} />
          <br />
          <p>
          Mail:
          </p>
          <input required type="text" name="mail" onChange={handleChange}/>
          <br />
          <p>
          Telefon:
          </p>
          <input required type="text" name="telefon"onChange={handleChange} />
          <br />
          <p>
          İl:
          </p>
          <input required type="text" name="il" onChange={handleChange}/>
          <br />
          <p>
          İlce:
          </p>
          <input required type="text" name="ilce" onChange={handleChange}/>
          <br />
          <p>
          Ana Bayi Id:
          </p>
          <input required type="text" name="anaBayiId" onChange={handleChange} />
        </label>
        <br />
        <br />
        <Button variant="success"  onClick={postAltBayi}>EKLE</Button>
      </form>
    </div>
  );
}

export default CreateAltBayi;
