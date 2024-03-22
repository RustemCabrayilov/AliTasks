using OOPIntro.Models;
#region Intro
//Principles of OOP
//1.Encapsulation
//2.Inheritance
//3.Polymorphism
//4.Abstraction

//Instance almaq
//Person person1 = new Person();

//person1.Name = "Ali";
//person1.Surname = "Agayev";
//person1.Age = 16;
//person1.Address = "Digah";
#endregion
#region InstanceAlmaq

//Car car = new Car();
//car.Marka = "BMW";
//car.Model = "528i";
//car.EngineSize = 2.0;
//car.Color = "Black";

//car.Drive();

//Car car2 = new Car();
//car2.Marka = "Mercedes-Benz";
//car2.Model = "E300";
//car2.EngineSize = 2.0;
//car2.Color = "White";

//car2.Drive();	
////Console.WriteLine(car.Marka + " "+car.Model + " "+car.EngineSize + " "+ car.Color);
//Phone phone = new Phone();

//phone.Model = "Apple Iphone 15Pro";
//phone.Memory = "1TB";
//phone.Ram = "12GB";
//phone.ProcessorSize = 2.8;
//phone.Color = "Titan Blue";

//Phone phone2 = new Phone();
//phone2.Model = "Apple Iphone 15Pro";

#endregion
#region Inheritance

Person person1 = new Person();

person1.Name = "Ali";
person1.Surname = "Agayev";
person1.Age = 16;
person1.Address = "Digah";
//person1.Eating();



Teacher teacher = new Teacher();
teacher.Name = "Mammad";
teacher.Surname = "Mammadli";
teacher.Address = "Yasamal ry";
teacher.Salary = 2000;
teacher.Age = 45;
teacher.StudyField = "Math Teacher";
//teacher.Eating();


Student student = new Student();
student.Name = "Nijat";
student.Surname = "Soltanov";
student.Address = "Zabrat";
student.Age = 20;
student.Specialty = "IT";
student.University = "ASOIU";

student.Eating();


#endregion