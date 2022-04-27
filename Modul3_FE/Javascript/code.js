function Hello(){
let firstName = document.getElementById("firstName").value;
let lastName = document.getElementById("lastName").value;
let age = document.getElementById("age").value;
alert(`${firstName} ${lastName}, ${age} years old.`);
}

let Name = 'Radu';
console.log(Name.toLocaleLowerCase());
console.log(Name.charAt(0));
console.log(Name[1]);

let email = "rusu.radu12@yahoo.com";
console.log(email.match("radu"));
console.log(email.endsWith(".com"));
console.log(email.length);
console.log(email.replace('radu', 'andrei'));

var x = email.split('@');
console.log(x[0]);
console.log(x[1]);
console.log(email);
var y = email.repeat(10);
console.log(y);
var z = email.slice(0,4);
console.log(z);

let num1 = 10;
let num2 = 25;

console.log(num1**num2, num1+num2, num1-num2, num1/num2, num1*num2);

console.log(1 == '1'); //is true because it's ignoring data types
console.log(1 === 1); //true
console.log(1 === '1') //here it's not ignoring data type anymore

let state = false;
let state1; // undefined
if(num1+num2 > 10)
{
    state = true;
}
console.log(state);
console.log(state1);

let myObject = {
    firstName : 'Radu',
    lastName : 'Rusu',
    age : 21
}
console.log(myObject);

myObject.email = "rusu.radu12@yahoo.com";
console.log(myObject);

myObject.age = 22;
console.log(myObject);

myObject['firstName'] = 'Andrei';
myObject['age'] = 16;
myObject.email = "rusu.andrei08@gmail.com";
console.log(myObject);


