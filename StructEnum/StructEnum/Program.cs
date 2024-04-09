


//Coordinate point = new Coordinate();
//point.x = 5; 
//point.y = 10;


//Coordinate point2 = new Coordinate(10,11);


//Console.WriteLine(point.ToString());
//Console.WriteLine(point2.ToString());


using ExampleSolution;
using StructEnum;

StructEnum.Employee employee = new StructEnum.Employee();

employee.Id = 1;
employee.Name = "Nijat";
employee.Surname = "Soltanov";
employee.ClothesSize = ClothesSize.Medium;


ExampleSolution.Employee employee2 = new ExampleSolution.Employee();
//employee2 = employee;
employee2.Id = 2;
employee2.Name = "Ali";



Console.WriteLine(employee.ToString());
Console.WriteLine(employee2.ToString());

