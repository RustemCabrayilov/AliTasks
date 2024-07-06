const colorBtn = document.querySelector("#changeColor");
const changeDisplay = document.querySelector("#changeDisplay");
const googleLink = document.querySelector("#googleLink");
const hiddenText = document.querySelector("#hiddenText");
const removeEvent = document.querySelector("#removeEvent");
// anonymous function
// colorBtn.addEventListener("click", function () {
//   document.body.style.backgroundColor = "blue";
// });

//arrow function
// colorBtn.addEventListener("click", (event) => {
//   console.log("Btn was clicked");
//   event.stopPropagation();
// });

// function changeColor() {
//   document.body.style.backgroundColor = "red";
// }

// googleLink.addEventListener("click", (event) => {
//   document.body.style.backgroundColor = "red";
//   event.preventDefault();
// });

// document.body.addEventListener("click", function (event) {
//   console.log("The body was clicked!");
// });

// changeDisplay.onclick = function () {
//   hiddenText.classList.toggle("showDisplay");
// };

// changeDisplay.onclick = () => {
//   hiddenText.classList.toggle("showDisplay");
// };

// changeDisplay.addEventListener("click", Test);

// removeEvent.addEventListener("click", () => {
//   changeDisplay.removeEventListener("click", Test);
// });

function Test() {
  console.log("Change Display isledi");
}

// addEventListener("DOMContentLoaded", (event) => {
//   console.log("The DOM is fully loaded.");
// });

// addEventListener("load", (event) => {
//   console.log("The page is fully loaded.");
// });

// addEventListener("beforeunload", (event) => {
//   // show the confirmation dialog
//   event.preventDefault();
//   // Google Chrome requires returnValue to be set.
//   event.returnValue = "";
// });

// addEventListener("unload", (event) => {
//   // send analytic data
// });
// remove the event listener

changeDisplay.addEventListener("mouseup", (event) => {
  let msg = document.querySelector("#message");
  switch (event.button) {
    case 0:
      msg.textContent = "Left mouse button clicked.";
      break;
    case 1:
      msg.textContent = "Middle mouse button clicked.";
      break;

    case 2:
      msg.textContent = "Right mouse button clicked.";
      break;
  }
});
changeDisplay.addEventListener("dblclick", (event) => {
  console.log("double Click ise dusdu");
});
removeEvent.addEventListener("mousedown", () => {});

let btnKeys = document.querySelector("#btnKeys");

btnKeys.addEventListener("click", (event) => {
  let keys = [];

  if (event.shiftKey) keys.push("shift");
  if (event.ctrlKey) keys.push("ctrl");
  if (event.altKey) keys.push("alt");
  if (event.metaKey) keys.push("meta");
  if (event.clientX) keys.push("x");

  let msg = document.querySelector("#messageKeys");
  msg.textContent = `Keys: ${keys.join("+")}`;
});

let msg = document.getElementById("testInput");

msg.addEventListener("keydown", (event) => {
  console.log(event.key);
});
msg.addEventListener("focus", (event) => {
  console.log("focus");
});
window.addEventListener("scroll", (event) => {
  console.log("Scrolling...");
});
