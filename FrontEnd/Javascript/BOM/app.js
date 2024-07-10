// var counter = 1;

// console.log(window.counter);

// console.log(window.innerWidth);
let interval = null;

document.querySelector(".start").addEventListener("click", () => {
  //   let features = "height=600,width=800",
  //     url =
  //       "https://www.javascripttutorial.net/javascript-bom/javascript-window/";
  //   let jsWindow = window.open(url, "about", features);
  //   setTimeout(() => {
  //     jsWindow.close();
  //   }, 3000);
  //   alert("Ali mene clickledin");
  //   let result = confirm("Sabah derse getmek isteyirsenmi?");
  //   console.log(result);
  //   let result = prompt("Nece yasin var");
  //   console.log(result);
  //   interval = setInterval(Clicked, 2000);
  //   setTimeout(() => {
  //     location.replace("https://www.javascripttutorial.net");
  //   }, 3000);

  //   let key = prompt("Key:");
  //   let value = prompt("Value:");

  //   localStorage.setItem(key, value);

  //   const settings = {
  //     backgroundColor: "#fff",
  //     color: "#111",
  //     theme: "light",
  //   };

  //   localStorage.setItem("settings", JSON.stringify(settings));

  fetch("https://dummyjson.com/products")
    .then((response) => response.text())
    .then((data) => console.log(JSON.parse(data)));
});

document.querySelector(".stop").addEventListener("click", () => {
  //   clearInterval(interval);
  let key = prompt("Key:");

  localStorage.removeItem(key);
});

document.querySelector(".show").addEventListener("click", () => {
  //   let key = prompt("Key:");

  //   let data = localStorage.getItem(key);
  //   console.log(data);
  var data1 = localStorage.getItem("settings");

  var data2 = JSON.parse(localStorage.getItem("settings"));
  console.log(data1);
  console.log(data2);
});

function Clicked() {
  console.log("salammm");
}
