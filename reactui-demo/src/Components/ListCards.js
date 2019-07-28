import React from "react";
import CreditCard from "./CreditCard";
const ListCards = props => (
  <div>
    {props.list.length > 0
      ? props.list.map((card, index) => <CreditCard Details={card} />)
      : "Norecords"}
  </div>
);

export default ListCards;
