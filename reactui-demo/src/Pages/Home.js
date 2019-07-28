import React from "react";
import ListCards from "../Components/ListCards";
import data from "./data";

class Home extends React.Component {
  constructor() {
    super();
    this.state = {
      allcards: data,
      currentpageno: 1,
      pagesize: 4
    };
    this.handleClick = this.handleClick.bind(this);
  }
  handleClick(event) {
    this.setState({
      currentpageno: Number(event.target.id)
    });
  }
  render() {
    const { allcards, currentpageno, pagesize } = this.state;

    const r = currentpageno * pagesize;
    const l = r - pagesize;
    const cardsToBeShown = allcards.slice(l, r);
    console.log("cardstobeshown:" + cardsToBeShown.length);
    const pageNumbers = [];
    for (
      let i = 1;
      i <= Math.ceil(this.state.allcards.length / this.state.pagesize);
      i++
    ) {
      pageNumbers.push(i);
    }
    console.log("Page Size:" + pageNumbers.length);
    const renderPageNumbers = pageNumbers.map((num, index) => (
      <li key={num} id={num} onClick={this.handleClick}>
        {num}
      </li>
    ));

    return (
      <div>
        <span>This is home page</span>
        <ul id="page-numbers">{renderPageNumbers}</ul>
        <ListCards list={cardsToBeShown} />
      </div>
    );
  }
}
export default Home;
