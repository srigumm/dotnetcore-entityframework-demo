import React from "react";

const CreditCard = ({ Details }) => (
  <div>
    <span>
      <b>Id:</b>
      {Details.Id}
      <b>CardName:</b> {Details.Name} <b>CardType:</b> {Details.Type}{" "}
      <b>IssuedBy:</b> {Details.IssuedBy}
    </span>
  </div>
);
export default CreditCard;
