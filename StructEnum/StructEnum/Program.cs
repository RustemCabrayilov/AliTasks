


//Coordinate point = new Coordinate();
//point.x = 5; 
//point.y = 10;


//Coordinate point2 = new Coordinate(10,11);


//Console.WriteLine(point.ToString());
//Console.WriteLine(point2.ToString());


using ExampleSolution;
using StructEnum;

StructEnum.Employee employee = new StructEnum.Employee();

employee.Name = "Nijat";
employee.Surname = "Soltanov";
employee.ClothesSize = ClothesSize.medium;


ExampleSolution.Employee employee2 = new ExampleSolution.Employee();
//employee2 = employee;
employee2.Id = 2;
employee2.Name = "Ali";



Console.WriteLine(employee.ToString());
Console.WriteLine(employee2.ToString());



StructEnum.Employee employee3 = new StructEnum.Employee();


Console.Write("Enter Name:");
employee3.Name = Console.ReadLine();
Console.Write("Surname:");
employee3.Surname = Console.ReadLine();

Console.WriteLine("Clothes Size:(small,medium,large)");
string size = Console.ReadLine();

//employee3.ClothesSize=(ClothesSize)Enum.Parse(typeof(ClothesSize), size);

Enum.TryParse(size.ToLower(), out ClothesSize clothesSize);

employee3.ClothesSize = clothesSize;

Console.WriteLine(employee3.ToString());

//Console.Write("Enter Number: ");

//string deyer = Console.ReadLine();
//int.TryParse(deyer, out int result);
//int result=  int.Parse(Console.ReadLine());	

//Console.WriteLine(result);
