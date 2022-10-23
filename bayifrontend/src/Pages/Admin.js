import axios from "axios";
import React, { useEffect, useState } from "react";
import Button from "react-bootstrap/Button";
import Container from "react-bootstrap/Container";
import Row from "react-bootstrap/Row";
import Col from "react-bootstrap/Col";
import { Link } from "react-router-dom";
import Modal from "react-bootstrap/Modal";
import { useNavigate } from "react-router-dom";

function Admin() {
  const navigate = useNavigate();
  const [bayi, setBayi] = useState([]);
  const [altBayi, setaltBayi] = useState([]);
  const getBayi = () => {
    axios
      .get("https://localhost:7056/api/AnaBayi")
      .then((res) => setBayi(res.data.data));
  };
  const getAltBayi = () => {
    axios
      .get("https://localhost:7056/api/AltBayi")
      .then((res) => setaltBayi(res.data.data));
  };
  useEffect(() => {
    getBayi();
  }, []);
  useEffect(() => {
    getAltBayi();
  }, []);
  console.log(altBayi);
  console.log(bayi);

  const deleteRequestHandler = async (id) => {
    const response = await axios
      .delete(`https://localhost:7056/api/AltBayi/${id}`)
      .then(() => {
        alert("Silme işlemi başarılı...");
        getBayi();
        getAltBayi();
      });
  };
  const deleteReqHandler = async (id) => {
    const response = await axios
      .delete(`https://localhost:7056/api/AnaBayi/${id}`)
      .then(() => {
        alert("Silme işlemi başarılı...");
        getBayi();
        getAltBayi();
      });
  };
  const [show, setShow] = useState(false);
  const [anashow, setanaShow] = useState(false);

  const handleClose = () => setShow(false);
  const handleShow = () => setShow(true);
  const anaHandleClose = () => setanaShow(false);
  const anaHandleShow = () => setanaShow(true);
  const [bayiData, setBayiData] = useState({
    altBayiAdi: "",
    id: 0,
    mail: "",
    telefon: 0,
    il: "",
    ilce: "",
    anaBayiId: 0,
  });
  const [anaBayiData, setanaBayiData] = useState({
    id:0,
    mail: "",
    telefon: 0,
    il: "",
    ilce: "",
    anaBayiAdi: "",
  });

  const anaBayiUpdate = () => {
    axios.put("https://localhost:7056/api/AnaBayi", {
          id:anaBayiData.id,
          anaBayiAdi: anaBayiData.anaBayiAdi,
          mail: anaBayiData.mail,
          telefon: anaBayiData.telefon,
          il: anaBayiData.il,
          ilce: anaBayiData.ilce,
    }).then((response)=>{
      console.log(response)
    })

  };
  const altBayiUpdate = () => {
    axios.put("https://localhost:7056/api/AltBayi", {
      altBayiAdi: bayiData.altBayiAdi,
      id: bayiData.id,
      mail: bayiData.mail,
      telefon: bayiData.telefon,
      il: bayiData.il,
      ilce: bayiData.ilce,
      anaBayiId: bayiData.anaBayiId,
    }).then((response)=>{
      console.log(response)
    })
  };
  const handleChange = (e) => {
    setBayiData({ ...bayiData, [e.target.name]: e.target.value });
    console.log(bayiData);
    console.log(setBayiData);
  };
  const anaHandleChange = (e) => {
    setanaBayiData({ ...anaBayiData, [e.target.name]: e.target.value });
    console.log(anaBayiData);
  };
  const exit = () => {
    localStorage.clear();
    navigate("/");
  };
  return (
    <div>
      <Button as={Link} to={"/CreateBayi"} variant="success">
        Bayi Ekle
      </Button>{" "}
      <Button as={Link} to={"/CreateAltBayi"} variant="success">
        Alt Bayi Ekle
      </Button>{" "}
      <Button variant="secondary" onClick={exit}>
        Çıkış
      </Button>{" "}
      <Container className="homeContein">
        <Row>
          <Col>
            <h2>Bayiler</h2>
            <ul>
              {bayi.map((anaBayi) => (
                <li key={anaBayi.id}>
                  <p>AnaBayi Adı: {anaBayi.anaBayiAdi}</p>
                  <p>AnaBayi Id: {anaBayi.id}</p>
                  <p>AnaBayi İL: {anaBayi.il}</p>
                  <p>AnaBayi İlçe: {anaBayi.ilce}</p>
                  <p>AnaBayi Mail: {anaBayi.mail}</p>
                  <p>AnaBayi Telefon: {anaBayi.telefon}</p>
                  <Button variant="outline-success" onClick={anaHandleShow}>
                    Düzenle
                  </Button>
                  <Modal
                    show={anashow}
                    onHide={anaHandleClose}
                    animation={false}
                  >
                    <Modal.Header closeButton>
                      <Modal.Title>Düzenleme Ekranı</Modal.Title>
                    </Modal.Header>
                    <Modal.Body>
                      <form>
                        <label>
                          Ana bayi Id:
                          <input
                            type="text"
                            name="id"
                            onChange={anaHandleChange}
                          />
                          <br/>
                          Ana bayi ad:
                          <input
                            type="text"
                            name="anaBayiAdi"
                            onChange={anaHandleChange}
                          />
                          <br />
                          Mail:
                          <input
                            type="text"
                            name="mail"
                            onChange={anaHandleChange}
                          />
                          <br />
                          Telefon:
                          <input
                            type="text"
                            name="telefon"
                            onChange={anaHandleChange}
                          />
                          <br />
                          İl:
                          <input
                            type="text"
                            name="il"
                            onChange={anaHandleChange}
                          />
                          <br />
                          İlce:
                          <input
                            type="text"
                            name="ilce"
                            onChange={anaHandleChange}
                          />
                        </label>
                      </form>
                    </Modal.Body>
                    <Modal.Footer>
                      <Button variant="success" onClick={anaBayiUpdate}>
                        Düzenle
                      </Button>
                      <Button variant="danger" onClick={anaHandleClose}>
                        Vazgeç
                      </Button>
                    </Modal.Footer>
                  </Modal>
                  <Button
                    variant="outline-danger"
                    onClick={() => {
                      deleteReqHandler(anaBayi.id);
                    }}
                  >
                    Sil
                  </Button>{" "}
                  <br />
                  <br />
                </li>
              ))}
            </ul>
          </Col>
          <Col>
            <h2>Alt Bayiler</h2>
            <ul>
              {altBayi.map((altBayiDegisken) => (
                <li key={altBayiDegisken.id}>
                  <p>AltBayi Adı: {altBayiDegisken.altBayiAdi}</p>
                  <p>AltBayi Id: {altBayiDegisken.id}</p>
                  <p>AnaBayi Id: {altBayiDegisken.anaBayiId}</p>
                  <p>AltBayi İL: {altBayiDegisken.il}</p>
                  <p>AltBayi İlçe: {altBayiDegisken.ilce}</p>
                  <p>AltBayi Mail: {altBayiDegisken.mail}</p>
                  <p>AltBayi Telefon: {altBayiDegisken.telefon}</p>
                  <Button variant="outline-success" onClick={handleShow}>
                    Düzenle
                  </Button>
                  <Modal show={show} onHide={handleClose} animation={false}>
                    <Modal.Header closeButton>
                      <Modal.Title>Düzenleme Ekranı</Modal.Title>
                    </Modal.Header>
                    <Modal.Body>
                      <form>
                        <label>
                          Ana bayi aD:
                          <input
                            type="text"
                            name="altBayiAdi"
                            onChange={handleChange}
                          />
                          <br />
                          Alt bayi id:
                          <input
                            type="text"
                            name="id"
                            onChange={handleChange}
                          />
                          <br />
                          Mail:
                          <input
                            type="text"
                            name="mail"
                            onChange={handleChange}
                          />
                          <br />
                          Telefon:
                          <input
                            type="text"
                            name="telefon"
                            onChange={handleChange}
                          />
                          <br />
                          İl:
                          <input
                            type="text"
                            name="il"
                            onChange={handleChange}
                          />
                          <br />
                          İlce:
                          <input
                            type="text"
                            name="ilce"
                            onChange={handleChange}
                          />
                          <br />
                          Ana Bayi Id
                          <input
                            type="text"
                            name="anaBayiId"
                            onChange={handleChange}
                          />
                        </label>
                      </form>
                    </Modal.Body>
                    <Modal.Footer>
                      <Button variant="success" onClick={altBayiUpdate}>
                        Düzenle
                      </Button>
                      <Button variant="danger" onClick={handleClose}>
                        Vazgeç
                      </Button>
                    </Modal.Footer>
                  </Modal>
                  <Button
                    variant="outline-danger"
                    onClick={() => {
                      deleteRequestHandler(altBayiDegisken.id);
                    }}
                  >
                    Sil
                  </Button>{" "}
                  <br />
                  <br />
                </li>
              ))}
            </ul>
          </Col>
        </Row>
      </Container>
    </div>
  );
}

export default Admin;
