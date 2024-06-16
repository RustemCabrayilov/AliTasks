function GetName() {
  console.log(surname);
}

let surname = "Nijat";

function SetAge() {
  let age = 5;
  console.log(age);

  if (true) {
    age = 10;
    console.log(age);
  }
}
// const age; error

// let age = 15,
//   name = "Nijat";

// console.log(age);
// console.log(name);
// try {
//   //console.log(age); //Undecleared

//   //   let object = {
//   //     name: "nijat",
//   //     surname: "soltanov",
//   //   };

//   let num = "a" / 2;

//   console.log(num);
//   console.log(typeof num);
// } catch (ex) {
//   console.log(ex);
// }

let age = 11;

if (age > 18) {
  console.log("You can drive");
} else {
  console.log("You cannot drive");
}

for (let i = 0; i < 10; i++) {
  console.log(i);
}
