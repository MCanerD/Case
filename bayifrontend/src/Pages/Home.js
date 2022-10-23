import React, { useEffect, useState } from "react";
import Button from "react-bootstrap/Button";
import { Link } from "react-router-dom";
import Container from "react-bootstrap/Container";
import Row from "react-bootstrap/Row";
import Col from "react-bootstrap/Col";
import axios from "axios";
function Home() {
  const [bayi, setBayi] = useState([]);
  const [altBayi, setaltBayi] = useState([]);
  useEffect(() => {
      axios
      .get("https://localhost:7056/api/AnaBayi")
      .then((res) => setBayi(res.data.data));
    }, []);
  useEffect(() => {
    axios
      .get("https://localhost:7056/api/AltBayi")

      .then((res) => setaltBayi(res.data.data));
  }, []);
  console.log(altBayi);
  console.log(bayi);
  return (
    <div className="homeConteiner">
      <div className="">
        <h1>
        MEVCUT BAYİLERİN ADLARI BURADA GÖRÜNTÜLENİYOR
        </h1>
        <Button
          as={Link}
          to={"/Login"}
          className="loginButton"
          variant="primary"
        >
          Giriş Yap
        </Button>{" "}
      </div>
      <Container className="homeContein">
        <Row>
          <Col>
            <h2>Bayiler</h2>
            <ul>
              {bayi.map((anaBayi) => (
                <li key={anaBayi.id}>{anaBayi.anaBayiAdi}</li>
              ))}
            </ul>
          </Col>
          <Col><h2>Alt Bayiler</h2>
          <ul>
              {altBayi.map((altBayi) => (
                <li key={altBayi.id}>{altBayi.altBayiAdi}</li>
              ))}
            </ul>
            </Col>
        </Row>
      </Container>
    </div>
  );
}

export default Home;
