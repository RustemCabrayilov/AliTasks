using AliTask;

Console.Write("Enter Username: ");
string username = Console.ReadLine();
Console.Write("Enter password: ");
string password = Console.ReadLine();


User user = new User(username, password);
user.Password = "Ali";
user.Password = "Ali12345";
Console.WriteLine();
//Console.WriteLine(user.Password);
