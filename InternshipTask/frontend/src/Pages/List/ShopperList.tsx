import styles from "./list.module.css";
import { useNavigate, useParams } from "react-router-dom";
import { useState } from "react";
import { useEffect } from "react";
import axios from "../../utils/axios";
import tshirt from "../../images/tshirt.jpg";
interface List {
  listId: number;
  shopperId: number;
  itemId: number;
}
interface Item {
  itemId: number;
  name: string;
  price: string;
}
const ShopperList = () => {
  const { id } = useParams();
  const [list, setList] = useState<List[]>([]);
  const [items, setItems] = useState<Item[]>([]);

  useEffect(() => {
    axios
      .get(`/ShoppingList/${id}`)
      .then((response) => {
        setList(response.data);
      })
      .catch((error) => {
        console.error(error);
      });
  }, [id]);

  useEffect(() => {
    axios
      .get("/Item")
      .then((response) => {
        const fetchedItems = response.data;

        // Filter the items based on the shopping list
        const commonIdentifier = "itemId";
        const filteredItems = fetchedItems.filter((item: Item) =>
          list.some(
            (listItem) => listItem[commonIdentifier] === item[commonIdentifier]
          )
        );

        // Set the filtered items in the state
        setItems(filteredItems);
      })
      .catch((error) => {
        console.error(error);
      });
  }, [list]);

  return (
    <div className={styles.wrapper}>
      <div className={styles.productContainer}>
        {items &&
          items.length > 0 &&
          items.map((c) => (
            <div key={c.itemId} className={styles.shopSingleProduct}>
              <img src={tshirt} className={styles.productImg}></img>
              <p className={styles.productHeaderFont}>{c.name}</p>
              <p className={styles.productPriceFont}>{c.price}</p>
              <button className={styles.buttonAdd}>ADD TO LIST</button>
            </div>
          ))}
      </div>
    </div>
  );
};

export default ShopperList;
