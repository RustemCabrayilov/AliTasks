const ul = document.querySelector("#cars");
const luxCars = document.querySelector("#luxCars");
const h1 = document.createElement("h1");
const h2 = document.createElement("h2");

ul.innerHTML = `<li>BMW</li>
<li>Mercedes-Benz</li>`;

const p = document.querySelector("p");

h1.innerText = "Salammm";
h2.innerText = "Necesenn";

//p.before("   $");
p.after(h1, h2);

ul.insertAdjacentHTML("afterbegin", "<li>Hyundai</li>");
ul.insertAdjacentHTML("beforebegin", "<h1>Azerbaijan cars</h1>");

const newLi = document.createElement("li");
newLi.innerText = "Kia";

ul.replaceChild(newLi, ul.firstChild);

const cars = luxCars.cloneNode(true);

//ul.innerHTML += cars.innerHTML;
newLi.innerText = "Hyundai";

ul.append(newLi);

const element = document.createElement("li");
element.innerHTML = "RR";
ul.prepend(element);
//ul.removeChild(ul.lastChild);

const input = document.querySelector("input");
input.setAttribute("id", "nameInput");
input.setAttribute("name", "name");
input.setAttribute("disabled", "");

const value = input.getAttribute("type");
console.log(value);

if (input.hasAttribute("name")) {
  console.log("duzdu");
}

input.removeAttribute("disabled");

ul.style.color = "red";

let styles = getComputedStyle(luxCars.firstElementChild);
console.log("Color:" + styles.color);
console.log("Font Weight:" + styles.fontWeight);

// p.className += " class3";
p.classList.add("class3");
p.classList.remove("class1");

p.classList.replace("class3", "classNew");

//console.log(p.classList.contains("classNew"));
p.classList.toggle("classNew");
p.classList.toggle("classToggle");
