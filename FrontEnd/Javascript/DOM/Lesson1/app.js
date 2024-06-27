// const redBox = document.getElementById("red");

// console.log(redBox);

// const emailInput = document.getElementsByName("emailInput");
// console.log(emailInput);

// const spans = document.getElementsByTagName("span");

// console.log(spans);

// const boxs = document.getElementsByClassName("box");

// console.log(boxs);

const ageSpan = document.querySelector("#ageParag > span");

//console.log(addressSpan.parentNode.parentNode.parentNode.parentNode);
// console.log(ageSpan.parentElement.previousElementSibling);

const blueBox = document.querySelector("#blue");
const body = document.querySelector("body");

// console.log(body.childNodes);

// const element = document.createElement("div");

// element.style.width = "300px";
// element.style.height = "300px";
// element.style.backgroundColor = "red";

// console.log(element);

// document.body.appendChild(element)

// const element = document.createElement("span");

// element.style.color = "pink";
// element.id = "test";
// element.className = "textL parag";

// element.innerHTML = "<b>Salam</b>";

// document.querySelector("#red").append(element);

//first style

const list = document.querySelector("ul");

const li = document.createElement("li");
li.textContent = "Ali";

const li2 = document.createElement("li");
li2.textContent = "Nijat";

list.append(li, li2);

const blue = document.querySelector("#blue ");

console.log(blue.innerHTML);

blue.innerHTML += `<span style="color:red"> TestRed</span>`;

//second style

// list.innerHTML += "<li>Nijat</li>";
