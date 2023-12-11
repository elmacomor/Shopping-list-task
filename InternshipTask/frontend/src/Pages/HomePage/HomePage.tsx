import Navbar from "../../components/Navbar/Navbar";
import styles from "./homePage.module.css";
import tshirt from "../../images/tshirt.jpg";
import axios from "../../utils/axios";
import { useEffect } from "react";
import { useState } from "react";
import Select from "react-select";
import { useNavigate } from "react-router-dom";

interface Shopper {
  shopperId: number;
  name: string;
  surname: string;
}
interface Item {
  itemId: number;
  name: string;
  price: string;
}
interface ListItem {
  shopperId: number;
  itemId: number;
}

const HomePage = () => {
  const navigate = useNavigate();
  const [shoppers, setShoppers] = useState<Shopper[]>([]);
  const [items, setItems] = useState<Item[]>([]);
  const [selectedShopper, setSelectedShopper] = useState<{
    value: number;
    label: string;
  } | null>(null);

  const handleShopperChange = (
    selectedOption: { value: number; label: string } | null
  ) => {
    setSelectedShopper(selectedOption);
  };
  const handleAddToList = (id: number) => {
    if (selectedShopper == null) {
      alert("Please select a shopper before adding to the list.");
    } else {
      const listItem: ListItem = {
        shopperId: selectedShopper?.value,
        itemId: id,
      };
      axios
        .post("/ShoppingList", listItem)
        .then((response) => {
          // Handle the response as needed
          alert("Item added to list");
        })
        .catch((error) => {
          // Handle errors
          alert("Can not add item to the list");
        });
    }
    console.log(selectedShopper?.value);
    console.log(id);
  };
  useEffect(() => {
    axios
      .get("/Shoppers")
      .then((response) => {
        setShoppers(response.data);
      })
      .catch((error) => {
        console.error(error);
      });
  }, []);

  useEffect(() => {
    axios
      .get("/Item")
      .then((response) => {
        setItems(response.data);
      })
      .catch((error) => {
        console.error(error);
      });
  }, []);

  return (
    <div className={styles.wrapper}>
      <Navbar></Navbar>
      <div className={styles.selectDiv}>
        Add products to{" "}
        <Select
          options={shoppers.map((shopper) => ({
            value: shopper.shopperId,
            label: shopper.name + " " + shopper.surname,
          }))}
          onChange={handleShopperChange}
          value={selectedShopper}
          className={styles.selection}
        ></Select>
        <button
          onClick={() => navigate(`/list/${selectedShopper?.value}`)}
          className={styles.listButton}
        >
          Check the list
        </button>
        for {selectedShopper?.label}
      </div>

      <div className={styles.productContainer}>
        {items &&
          items.length > 0 &&
          items.map((c) => (
            <div key={c.itemId} className={styles.shopSingleProduct}>
              <img src={tshirt} className={styles.productImg}></img>
              <p className={styles.productHeaderFont}>{c.name}</p>
              <p className={styles.productPriceFont}>{c.price}</p>
              <button
                className={styles.buttonAdd}
                onClick={() => handleAddToList(c.itemId)}
              >
                ADD TO LIST
              </button>
            </div>
          ))}
      </div>
    </div>
  );
};
export default HomePage;
