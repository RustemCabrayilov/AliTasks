getDatas();

setTimeout(() => {
  const deleteBtns = document.querySelectorAll(".deleteBtn");
  deleteBtns.forEach((deleteBtn) => {
    deleteBtn.addEventListener("click", () => {
      const tr = deleteBtn.parentElement.parentElement;
      const id = tr.firstElementChild.textContent;
      deleteBtn.addEventListener("click", () => {
        fetch(`https://northwind.vercel.app/api/suppliers/${id}`, {
          method: "DELETE",
        });
        tr.parentElement.removeChild(tr);
      });
    });
  });
}, 1000);

let form = document.querySelector("#register_form");
let addbtn = document.querySelector("#addbtn");

addbtn.addEventListener("click", (event) => {
  event.preventDefault();

  let companyname = document.querySelector("#companyname");
  let contactname = document.querySelector("#contactname");
  let contacttitle = document.querySelector("#contacttitle");
  fetch("https://northwind.vercel.app/api/suppliers/", {
    method: "POST",
    headers: {
      Accept: "application/json",
      "Content-Type": "application/json",
    },
    body: JSON.stringify({
      companyName: companyname.value,
      contactTitle: contacttitle.value,
      contactName: contactname.value,
    }),
  })
    .then((res) => res.json())
    .then((data) => {
      addTable(data);
    });

  companyname.value = "";
  contacttitle.value = "";
  contactname.value = "";
});

function getDatas() {
  fetch("https://northwind.vercel.app/api/suppliers")
    .then((res) => res.json())
    .then((data) => {
      data.forEach((element) => {
        addTable(element);
      });
    });
}

function addTable(element) {
  let table = document.querySelector("table>tbody");
  table.innerHTML += `<tr>
       <td>${element.id}</td>
       <td>${element.companyName}</td>
       <td>${element.contactName}</td>
       <td>${element.contactTitle}</td>
       <td><button>Edit</button></td>
       <td><button class="deleteBtn">Delete</button></td>
      </tr>
      `;
}
