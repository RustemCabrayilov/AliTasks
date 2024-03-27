
namespace Relations
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//string name = "Nijat";
			//Person person1= new Person(name);
			//Person person2 = new Person("Ali");
			//Person person3 = new Person("Nijat");
			//Employee employee = new Employee("Nijat","Soltanov",20,500);


			Department ITDepartment = new Department("IT Department",25,500);
			Department HRDepartment = new Department("HR Department", 5, 900);


			Employee employee = new Employee("Nijat","Soltanov",20,500,ITDepartment);
			Employee employee2 = new Employee("Ali", "Agayev", 17, 1500, ITDepartment);


			Employee employee3 = new Employee("Nigar", "Xanim", 27, 1500, HRDepartment);
		}
	}
}
