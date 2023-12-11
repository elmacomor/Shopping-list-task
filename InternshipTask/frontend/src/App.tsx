import React from "react";
import logo from "./logo.svg";
import "./App.css";
import HomePage from "./Pages/HomePage/HomePage";
import List from "./Pages/List/ShopperList";
import { BrowserRouter, Routes, Route } from "react-router-dom";
import ShopperList from "./Pages/List/ShopperList";
function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<HomePage></HomePage>} />
        <Route path="/list/:id" element={<ShopperList></ShopperList>} />
      </Routes>
    </BrowserRouter>
  );
}

export default App;
