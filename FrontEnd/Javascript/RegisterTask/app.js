let form = document.querySelector("#register_form");
let container = document.querySelector(".container tbody");
let users = [];
form.addEventListener("submit", (event) => {
  event.preventDefault();
  let email = document.querySelector("#email");
  let password = document.querySelector("#password");
  let confirmpassword = document.querySelector("#Confirmpassword");
  let result = CheckData(email.value, password.value, confirmpassword.value);

  if (result == true) {
    users.push({ email: email.value, password: password.value });
    container.innerHTML += `<tr>
    <td>${email.value}</td>
    <td>${password.value}</td>
    </tr>`;

    email.value = "";
    password.value = "";
    confirmpassword = "";
  }
});

function CheckData(email, password, confirmpassword) {
  if (
    email == null ||
    password == null ||
    password == "" ||
    confirmpassword == null
  ) {
    alert("register olmadi");
    return false;
  }
  if (password !== confirmpassword) {
    alert("password uygun gelmir");
    return false;
  }
  return true;
}
