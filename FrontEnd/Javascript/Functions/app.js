let a = 10;

//console.log(a++); //Console cixarir sonra artirir
//console.log(++a); //Artirir sonra console cixarir

//console.log(new String("1") === new String("1"));

//onsole.log(new String("1"));

//console.log(true || false); // en az biri true olsun
//console.log(true && false); // her bir true olmalidi

// console.log((true && false) || (true && true) || false);

// const name = "sasd" ?? "Ali";

// console.log(name);

//console.log(Math.pow(2, 4));
// console.log((-2) ** 4);

let age = 21;
// let name;

// if (age > 18) {
//   name = "Nijat";
// } else {
//   name = "Ali";
// }

let name = age > 18 ? "Nijat" : "Ali";

// console.log(name);

// for (let i = 0; i < 10; i++) {
//   if (i % 2 == 0) continue;

//   console.log(i);
// }

function printName(name, surname) {
  console.log(name + " " + surname);
}

function square(number) {
  return number ** 2;
}

function DiffSquares(number1, number2, func) {
  return func(number1) / func(number2);
}

// printName("Nijat", "Soltanov");

// console.log(square(4));

let result = DiffSquares(9, 3, function (number) {
  return number ** 3;
});

//console.log(result);

let func1 = function () {
  console.log("func1");
};

let func2 = () => {
  console.log("func2");
};

let calc = (number1, number2) => number1 + number2;

func1();
func2();

console.log(calc(5, 10));

let person = {
  name: "Ali",
  age: 17,
};

let IncreaseAge = (person) => person.age++;

let IncreaseNumber = (number) => number++;

console.log(person.age);

IncreaseAge(person);

console.log(person.age);

let number = 10;

console.log(number);
IncreaseNumber(number);
console.log(number);
